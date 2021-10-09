using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DemoHub.Persistence.Models;
using CalastoneServiceReference;
using DemoHub.Common;
using DemoHub.Infrastructure.MessageEngine;
using Microsoft.EntityFrameworkCore;
using DemoHub.WebServices.MessageHandlers;
using Amazon.SQS.Model;
using DemoHub.Common.Enums;

namespace DemoHub.WebServices.Helpers
{
    public class MessageHelper
    {

        public static string FeeAndTaxBuilderV4(string type)
        {
            string result = string.Empty;

            StringBuilder msg = new StringBuilder();

            // switch type
            try
            {
                #region Order
                msg.Append("<IndvFee><Tp><Cd>");
                //msg.Append(Cd);
                msg.Append("</Cd><Prtry><Id>");
                //msg.Append(Id);
                msg.Append("</Id><Issr>");
                //msg.Append(Issr);
                msg.Append("</Issr>");
                msg.Append("</Prtry>");
                msg.Append("</Tp>");

                msg.Append("<DscntDtls><Rate>");
                //msg.Append(Rate);
                msg.Append("</Rate></DscntDtls>");

                // optional field
                msg.Append("<ReqdRate>");
                //msg.Append(ReqdRate);
                msg.Append("</ReqdRate>");


                msg.Append("</IndvFee>");
                #endregion

                #region Order Confirmation - Indv Fee
                msg.Append("<IndvFee>");
                string code = "";
                msg.Append($"<Tp><Cd>{code}</Cd></Tp>");

                string basis = "";
                msg.Append($"<Bsis><Cd>{basis}</Cd></Bsis>");

                string currencyCode = "";
                string amt = "";
                msg.Append($"<StdAmt Ccy=\"{currencyCode}\">{amt}</StdAmt>");

                msg.Append("<StdRate>");
                //msg.Append(StdRate);
                msg.Append("</StdRate>");

                msg.Append("<DscntDtls>");
                string discountamt = "";
                msg.Append($"<Amt Ccy=\"{currencyCode}\">{discountamt}</Amt>");
                msg.Append("<Rate>");
                //msg.Append(Rate);
                msg.Append("</Rate>");
                msg.Append("</DscntDtls>");


                string appliedamt = "";
                msg.Append($"<ApldAmt Ccy=\"{currencyCode}\">{appliedamt}</ApldAmt>");
                msg.Append("<ApldRate>");
                //msg.Append(ApldRate);
                msg.Append("</ApldRate>");

                msg.Append("<InftvInd>");
                //msg.Append(InftvInd);
                msg.Append("</InftvInd>");


                msg.Append("</IndvFee>");
                #endregion




                #region Indv Tax
                msg.Append("<IndvTax>");
                string taxcode = "";
                msg.Append($"<Tp><Cd>{taxcode}</Cd></Tp>");

                string taxappliedamt = "";
                msg.Append($"<ApldAmt Ccy=\"{currencyCode}\">{taxappliedamt}</ApldAmt>");

                msg.Append("<ApldRate>");
                //msg.Append(ApldRate);
                msg.Append("</ApldRate>");



                msg.Append("</IndvTax>");
                #endregion



                #region InftvTaxDtls
                msg.Append("<IndvTax>");

                string infotaxcode = "";
                msg.Append($"<Tp><Cd>{infotaxcode}</Cd></Tp>");
                msg.Append("<XmptnInd>");
                //msg.Append(XmptnInd);
                msg.Append("</XmptnInd>");

                string exemcode = "";
                msg.Append($"<XmptnRsn><Cd>{exemcode}</Cd></XmptnRsn>");

                msg.Append("</IndvTax>");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public static string SendStatusReportV04(List<TblDCalastoneTransactionRequest> requests, string type)
        {
            try
            {
                object[] items = new object[requests.Count];

                for (int i = 0; i < requests.Count; i++)
                {
                    if (type == "BusinessAccept")
                    {
                        items[i] = StatusReportHandler.BusinessAcceptV04(requests[i]);
                    }
                    else if (type == "Received")
                    {
                        items[i] = StatusReportHandler.ReceivedV04(requests[i]);
                    }
                    else if (type == "BusinessReject")
                    {
                        items[i] = StatusReportHandler.BusinessRejectedBuilderV4(
                            requests[i],
                            requests[i].FkTransactionRequestRejectedReasonCode,
                            requests[i].SAdditionalRejectedReason);
                    }
                    else if (type == "InRepair")
                    {
                        items[i] = StatusReportHandler.BusinessInRepairBuilderV04(requests[i]);
                    }
                    else
                    {
                        break;
                    }
                }

                Messages messages = new Messages
                {
                    Messages1 = new MessagesType()
                };
                messages.Messages1.Items = new MessagesType[requests.Count];
                messages.Messages1.Items = items;

                SendMessagesRequest request = new SendMessagesRequest
                {
                    message = messages
                };
                string msg = XmlHelper.SerializeToXmlString(request);

                SqsMessagesService client = new SqsMessagesService("DemoHubMQ.fifo", "client");
                SendMessageResponse response = client.Enqueue(msg, MessageType.StatusReport).Result;
                return response.HttpStatusCode.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string SendOrderConfirmationV04(List<TblDTransaction> transactions)
        {
            try
            {
                object[] items = new object[transactions.Count];

                for (int i = 0; i < transactions.Count; i++)
                {
                    if (transactions[i].FkTransactionType == (int)CalastoneEnums.TransactionType.Subscription)
                        items[i] = SubscriptionMessageHandler.OrderConfirmationV04(transactions[i]);
                    else if (transactions[i].FkTransactionType == (int)CalastoneEnums.TransactionType.Redemption)
                        items[i] = RedemptionMessageHandler.OrderConfirmationV04(transactions[i]);
                }

                Messages messages = new Messages
                {
                    Messages1 = new MessagesType()
                };
                messages.Messages1.Items = new MessagesType[transactions.Count];
                messages.Messages1.Items = items;

                SendMessagesRequest request = new SendMessagesRequest
                {
                    message = messages
                };
                string msg = XmlHelper.SerializeToXmlString(request);

                SqsMessagesService client = new SqsMessagesService("DemoHubMQ.fifo", "client");
                SendMessageResponse response = client.Enqueue(msg, MessageType.OrderConfirmation).Result;
                return response.HttpStatusCode.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
