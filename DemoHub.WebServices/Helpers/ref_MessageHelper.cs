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

namespace DemoHub.WebServices.Helpers
{
    public class ref_MessageHelper
    {
        public static string SubOrderV3Processor(Document15 docOrder)
        {
            string ackMessage = string.Empty;

            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {
                tblDTransactionRequest.FkTransactionType = 1;
                tblDTransactionRequest.FkTransactionRequestStatus = 1;
                //tblDTransactionRequest.FkTransactionRequestResource = 2;

                tblDTransactionRequest.SMessageId = docOrder.SbcptOrdrV03.MsgId.Id;
                tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(docOrder.SbcptOrdrV03.MsgId.CreDtTm);
                tblDTransactionRequest.SAccountId = docOrder.SbcptOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctId.Prtry.Id;
                tblDTransactionRequest.SAccountDesignation = docOrder.SbcptOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;

                //tblDTransactionRequest.SAgentCode = (docOrder.SbcptOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr?.Item as GenericIdentification1)?.Id;

                tblDTransactionRequest.SOrderReference = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].OrdrRef;
                tblDTransactionRequest.FkFundIdtype = 1;
                tblDTransactionRequest.SFundId = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Id.Item.ToString();
                //tblDTransactionRequest.SFundName = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Nm;             
                var itemName = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].ItemElementName.ToString();

                switch (itemName)
                {
                    case "GrssAmt":
                        {
                            var grssAmt = (docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].Item as ActiveOrHistoricCurrencyAndAmount14).Value;
                            tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(grssAmt);
                            ///TODO add the currency as foreign key 
                            //tblDTransactionRequest.FkGrossAmountCurrency = ;
                            break;
                        }
                    case "UnitsNb":
                        {
                            var somefields = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].Item as FinancialInstrumentQuantity14;
                            var unitsNb = somefields.Unit;
                            tblDTransactionRequest.DUnit = unitsNb;
                            break;
                        }
                }
                tblDTransactionRequest.IsPhysicalDeliverable = false;
                tblDTransactionRequest.SFundManagerId = (docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].RltdPtyDtls[0].Id.Item as GenericIdentification117).Id;
                tblDTransactionRequest.FkDistributorCode = 5;

                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequest);
                int insertedRowCount = dc.SaveChanges();

                if (insertedRowCount == 0)
                {
                    // insertion failed
                }
                else
                {
                    ackMessage = OrderReceivedBuilderV3(tblDTransactionRequest);
                }
                return ackMessage;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static string SubOrderV4Processor(Document2 docOrder)
        {
            string ackMessage = string.Empty;

            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {
                tblDTransactionRequest.FkTransactionType = 1;
                tblDTransactionRequest.FkTransactionRequestStatus = 1;
                //tblDTransactionRequest.FkTransactionRequestResource = 2;

                tblDTransactionRequest.SMessageId = docOrder.SbcptOrdr.MsgId.Id;
                tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(docOrder.SbcptOrdr.MsgId.CreDtTm).ToLocalTime();
                tblDTransactionRequest.SAccountId = docOrder.SbcptOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctId;
                tblDTransactionRequest.SAccountDesignation = docOrder.SbcptOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;

                tblDTransactionRequest.SAgentCode = (docOrder.SbcptOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr?.Pty.Item as GenericIdentification12)?.Id;

                tblDTransactionRequest.SOrderReference = docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].OrdrRef;
                tblDTransactionRequest.FkFundIdtype = 1;
                tblDTransactionRequest.SFundId = docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Id.Item.ToString();
                tblDTransactionRequest.SFundName = docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Nm;
                var itemName = docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnits.ItemElementName.ToString();

                switch (itemName)
                {
                    case "GrssAmt":
                        {
                            var grssAmt = (docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnits.Item as ActiveOrHistoricCurrencyAndAmount2).Value;
                            tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(grssAmt);
                            ///TODO add the currency as foreign key 
                            var currency = (docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnits.Item as ActiveOrHistoricCurrencyAndAmount2).Ccy;
                            tblDTransactionRequest.FkGrossAmountCurrency = dc.TblSCurrency.FirstOrDefault(x => x.VCurrencyCode == currency).KCurrency;
                            break;
                        }
                    case "UnitsNb":
                        {
                            var units = docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnits.Item;
                            tblDTransactionRequest.DUnit = units != null ? Convert.ToDecimal(units) : 0;
                            break;
                        }
                }
                tblDTransactionRequest.IsPhysicalDeliverable = false;
                tblDTransactionRequest.SFundManagerId = ((docOrder.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0]?.RltdPtyDtls[0]?.Id?.Pty?.Item) as GenericIdentification12)?.Id;
                tblDTransactionRequest.FkDistributorCode = 5;

                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequest);
                int insertedRowCount = dc.SaveChanges();

                if (insertedRowCount == 0)
                {
                    // insertion failed
                }
                else
                {
                    ackMessage = OrderReceivedBuilderV4(tblDTransactionRequest);
                }
                return ackMessage;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static string RedOrderV3Processor(Document13 docOrder)
        {
            string ackMessage = string.Empty;
            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {
                tblDTransactionRequest.FkTransactionType = 2;
                tblDTransactionRequest.FkTransactionRequestStatus = 1;
                //tblDTransactionRequest.FkTransactionRequestResource = 2;

                tblDTransactionRequest.SMessageId = docOrder.RedOrdrV03.MsgId.Id;
                tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(docOrder.RedOrdrV03.MsgId.CreDtTm);
                tblDTransactionRequest.SAccountId = docOrder.RedOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctId.Prtry.Id;
                tblDTransactionRequest.SAccountDesignation = docOrder.RedOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;

                tblDTransactionRequest.SAgentCode = (docOrder.RedOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr?.Item as GenericIdentification113)?.Id;

                tblDTransactionRequest.SOrderReference = docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].OrdrRef;
                tblDTransactionRequest.FkFundIdtype = 1;
                tblDTransactionRequest.SFundId = docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Id.Item.ToString();
                tblDTransactionRequest.SFundName = docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Nm;
                var itemName = docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].ItemElementName.ToString();

                switch (itemName)
                {
                    case "GrssAmt":
                        {
                            var grssAmt = (docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].Item as ActiveOrHistoricCurrencyAndAmount12).Value;
                            tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(grssAmt);
                            ///TODO add the currency as foreign key 
                            //tblDTransactionRequest.FkGrossAmountCurrency = ;
                            break;
                        }
                    case "UnitsNb":
                        {
                            var somefields = docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].Item as FinancialInstrumentQuantity12;
                            var unitsNb = somefields.Unit;
                            tblDTransactionRequest.DUnit = unitsNb;
                            break;
                        }
                    case "HldgsRedRate":
                        {

                            ///TODO percentage of holdings save.
                            break;
                        }
                }
                tblDTransactionRequest.IsPhysicalDeliverable = false;
                tblDTransactionRequest.SFundManagerId = (docOrder.RedOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].RltdPtyDtls[0].Id.Item as GenericIdentification113).Id;
                tblDTransactionRequest.FkDistributorCode = 5;

                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequest);
                int insertedRowCount = dc.SaveChanges();

                if (insertedRowCount == 0)
                {
                    // insertion failed
                }
                else
                {
                    ackMessage = OrderReceivedBuilderV3(tblDTransactionRequest);
                }
                return ackMessage;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string RedOrderV4Processor(Document docOrder)
        {
            string ackMessage = string.Empty;
            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {
                tblDTransactionRequest.FkTransactionType = 2;
                tblDTransactionRequest.FkTransactionRequestStatus = 1;
                //tblDTransactionRequest.FkTransactionRequestResource = 2;

                tblDTransactionRequest.SMessageId = docOrder.RedOrdr.MsgId.Id;
                tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(docOrder.RedOrdr.MsgId.CreDtTm).ToLocalTime();
                tblDTransactionRequest.SAccountId = docOrder.RedOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctId;
                tblDTransactionRequest.SAccountDesignation = docOrder.RedOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;

                tblDTransactionRequest.SAgentCode = ((docOrder.RedOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr?.Pty as PartyIdentification90Choice)?.Item
                    as GenericIdentification1).Id;

                tblDTransactionRequest.SOrderReference = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].OrdrRef;
                tblDTransactionRequest.FkFundIdtype = 1;
                tblDTransactionRequest.SFundId = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Id.Item.ToString();
                tblDTransactionRequest.SFundName = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].FinInstrmDtls.Nm;
                var itemName = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnitsOrPctg.ItemElementName.ToString();

                switch (itemName)
                {
                    case "GrssAmt":
                        {
                            var grssAmt = (docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnitsOrPctg.Item
                                as FinancialInstrumentQuantity28Choice).Item as ActiveOrHistoricCurrencyAndAmount;
                            tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(grssAmt.Value);
                            break;
                        }
                    case "UnitsNb":
                        {
                            var somefields = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnitsOrPctg.Item as FinancialInstrumentQuantity28Choice;
                            var unitsNb = somefields.Item != null ? Convert.ToDecimal(somefields.Item) : 0;
                            tblDTransactionRequest.DUnit = unitsNb;
                            break;
                        }
                    case "HldgsRedRate":
                        {
                            var somefields = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].AmtOrUnitsOrPctg.Item as FinancialInstrumentQuantity28Choice;
                            var unitsNb = Convert.ToDecimal(somefields.Item);
                            ///TODO percentage of holdings save

                            break;
                        }
                }

                if (docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].RndgSpecified)
                {
                    var roundingCodeValue = docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].Rndg;
                    tblDTransactionRequest.FkRoundingCode = dc.TblSRoundingCode.FirstOrDefault(x => x.SCodeName == roundingCodeValue.ToString()).KRoundingCode;
                }

                tblDTransactionRequest.IsPhysicalDeliverable = false;
                tblDTransactionRequest.SFundManagerId = (docOrder.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0].RltdPtyDtls[0].Id.Pty.Item as GenericIdentification1).Id;
                tblDTransactionRequest.FkDistributorCode = 5;

                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequest);
                int insertedRowCount = dc.SaveChanges();

                if (insertedRowCount == 0)
                {
                    // insertion failed
                }
                else
                {
                    ackMessage = OrderReceivedBuilderV4(tblDTransactionRequest);
                }
                return ackMessage;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void SwitchOrderV3Processor(Document17 docOrder)
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SwitchOrderV4Processor(Document4 docOrder)
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            try
            {

                //common things
                var msgId = docOrder.SwtchOrdr.MsgId.Id;
                var creDtTm = docOrder.SwtchOrdr.MsgId.CreDtTm.ToLocalTime();

                var ordrRef = docOrder.SwtchOrdr.SwtchOrdrDtls[0].OrdrRef;
                var acctId = docOrder.SwtchOrdr.SwtchOrdrDtls[0].InvstmtAcctDtls.AcctId;
                var acctDsgnt = docOrder.SwtchOrdr.SwtchOrdrDtls[0].InvstmtAcctDtls.AcctDsgnt;
                var agentCode = (docOrder.SwtchOrdr.SwtchOrdrDtls[0].InvstmtAcctDtls.AcctSvcr.Pty.Item as GenericIdentification14).Id;

                ///TODO use these as well
                var distId = (docOrder.SwtchOrdr.SwtchOrdrDtls[0].RltdPtyDtls[0].Id.Pty.Item as GenericIdentification14).Id;
                var distRole = (docOrder.SwtchOrdr.SwtchOrdrDtls[0].RltdPtyDtls[0].Role.Item).ToString();


                //split into switch out and switch in and save two times
                //switch out
                TblDCalastoneTransactionRequest tblDTransactionRequestSwitchOut = new TblDCalastoneTransactionRequest();
                tblDTransactionRequestSwitchOut.FkTransactionType = 3;
                tblDTransactionRequestSwitchOut.FkTransactionRequestStatus = 1;
                tblDTransactionRequestSwitchOut.FkTransactionRequestStatus = 1;
                //tblDTransactionRequestSwitchOut.FkTransactionRequestResource = 2;

                tblDTransactionRequestSwitchOut.DtMessageCreationDateTime = creDtTm;
                tblDTransactionRequestSwitchOut.SAccountId = acctId;
                tblDTransactionRequestSwitchOut.SAccountDesignation = acctDsgnt;
                tblDTransactionRequestSwitchOut.SOrderReference = ordrRef;
                tblDTransactionRequestSwitchOut.SAgentCode = agentCode;

                tblDTransactionRequestSwitchOut.SLegOrderReference = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].LegId;
                tblDTransactionRequestSwitchOut.SFundId = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmDtls.Id.Item.ToString();
                tblDTransactionRequestSwitchOut.SFundName = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmDtls.Nm;
                tblDTransactionRequestSwitchOut.SProductCode = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmDtls.SplmtryId;

                var switchOrderItemType = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmQtyChc.ItemElementName.ToString();
                switch (switchOrderItemType)
                {
                    case "GrssAmt":
                        {
                            var grssAmt = (docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmQtyChc.Item as ActiveOrHistoricCurrencyAndAmount4);
                            tblDTransactionRequestSwitchOut.DGrossAmount = Convert.ToDecimal(grssAmt.Value);
                            tblDTransactionRequestSwitchOut.FkGrossAmountCurrency = dc.TblSCurrency.FirstOrDefault(x => x.VCurrencyCode == grssAmt.Ccy).KCurrency;
                            break;
                        }
                    case "UnitsNb":
                        {
                            var somefields = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmQtyChc.Item;
                            var unitsNb = somefields != null ? Convert.ToDecimal(somefields) : 0;
                            tblDTransactionRequestSwitchOut.DUnit = unitsNb;
                            break;
                        }
                    case "HldgsRedRate":
                        {
                            var somefields = docOrder.SwtchOrdr.SwtchOrdrDtls[0].RedLegDtls[0].FinInstrmQtyChc.Item;
                            var holdPercent = somefields != null ? Convert.ToDecimal(somefields) : 0;
                            ///TODO percentage of holdings save
                            break;
                        }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string OrderReceivedBuilderV4(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {

            try
            {

                var doc = new Document6();
                var ordrInstrStsRptV04 = new OrderInstructionStatusReportV04();

                var msgId = new MessageIdentification16();
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                ordrInstrStsRptV04.MsgId = msgId;

                var refs = new References61Choice();
                refs.Items = new AdditionalReference86[1];
                refs.Items[0] = new AdditionalReference86() { Ref = tblDTransactionRequest.SMessageId };
                refs.ItemsElementName = new ItemsChoiceType[1] { ItemsChoiceType.RltdRef };
                ordrInstrStsRptV04.Ref = new References61Choice();
                ordrInstrStsRptV04.Ref = refs;

                var stsRpt = new Status24Choice();

                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {
                    var items = new List<IndividualOrderStatusAndReason7>();
                    var ordrStatus = new OrderStatus5Choice();
                    ordrStatus.Items = new object[1];
                    ordrStatus.Items[0] = OrderStatus4Code.RECE;
                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();

                    // ordrInstrStsRptV04.StsRpt = new Status24Choice();
                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    var items = new List<SwitchOrderStatusAndReason2>();
                    var ordrStatus = new OrderStatus4Choice();
                    ordrStatus.Items = new object[1];
                    ordrStatus.Items[0] = OrderStatus4Code.RECE;
                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }


                doc.OrdrInstrStsRpt = ordrInstrStsRptV04;
                var result = XmlHelper.SerializeToXmlString(doc);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static string OrderReceivedBuilderV3(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {


            try
            {
                var doc = new Document19();


                var ordrInstrStsRptV03 = new OrderInstructionStatusReportV03();

                var msgId = new MessageIdentification117();
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                ordrInstrStsRptV03.MsgId = msgId;

                var additionalRef = new List<AdditionalReference37>();
                additionalRef.Add(new AdditionalReference37() { Ref = tblDTransactionRequest.SMessageId });
                ordrInstrStsRptV03.Items = additionalRef.ToArray();


                var sts = new OrderStatus5Choice();
                sts.Items = new object[1];
                sts.Items[0] = OrderStatus4Code.PACK;

                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {

                    ordrInstrStsRptV03.ItemsElementName = new ItemsChoiceType1[1] { ItemsChoiceType1.RltdRef };

                    var orderStatus = new List<IndividualOrderStatusAndReason2>();
                    var item = new IndividualOrderStatusAndReason2();
                    item.Items = new object[1];
                    item.Items[0] = OrderStatus4Code1.RECE;
                    item.OrdrRef = tblDTransactionRequest.SOrderReference;
                    item.DealRef = CalastoneMessageIdGenerator.NewDealReference();
                    orderStatus.Add(item);
                    ordrInstrStsRptV03.Items1 = orderStatus.ToArray();
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    var switchOrderStatus = new List<SwitchOrderStatusAndReason1>();
                    switchOrderStatus.Add(new SwitchOrderStatusAndReason1() { OrdrRef = tblDTransactionRequest.SOrderReference, DealRef = CalastoneMessageIdGenerator.NewDealReference() });
                    ordrInstrStsRptV03.Items1 = switchOrderStatus.ToArray();
                    ordrInstrStsRptV03.ItemsElementName = new ItemsChoiceType1[1] { ItemsChoiceType1.OthrRef };

                    var orderStatus = new List<SwitchOrderStatusAndReason1>();
                    var item = new SwitchOrderStatusAndReason1();
                    item.OrdrRef = tblDTransactionRequest.SOrderReference;
                    item.DealRef = CalastoneMessageIdGenerator.NewDealReference();
                    item.Items = new object[1];
                    item.Items[0] = OrderStatus4Code1.RECE;

                    orderStatus.Add(item);
                    ordrInstrStsRptV03.Items1 = orderStatus.ToArray();
                }


                doc.OrdrInstrStsRptV03 = ordrInstrStsRptV03;
                var result = XmlHelper.SerializeToXmlString(doc);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static string BusinessAcceptedBuilderV4(TblDCalastoneTransactionRequest tblDTransactionRequest)
        {

            try
            {

                var doc = new Document6();


                var ordrInstrStsRptV04 = new OrderInstructionStatusReportV04();

                var msgId = new MessageIdentification16();
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                ordrInstrStsRptV04.MsgId = msgId;

                var refs = new References61Choice();
                refs.Items = new AdditionalReference86[1];
                refs.Items[0] = new AdditionalReference86() { Ref = tblDTransactionRequest.SMessageId };
                refs.ItemsElementName = new ItemsChoiceType[1] { ItemsChoiceType.RltdRef };
                ordrInstrStsRptV04.Ref = refs;

                var stsRpt = new Status24Choice();




                if (tblDTransactionRequest.FkTransactionType == 1 || tblDTransactionRequest.FkTransactionType == 2)
                {
                    var items = new List<IndividualOrderStatusAndReason7>();
                    var ordrStatus = new OrderStatus5Choice();
                    ordrStatus.Items = new object[1];
                    ordrStatus.Items[0] = OrderStatus4Code.PACK;

                    var expectedSettlementDtls = new ExpectedExecutionDetails4();
                    expectedSettlementDtls.XpctdCshSttlmDt = DateTime.Now;
                    expectedSettlementDtls.XpctdTradDtTm = new DateAndDateTimeChoice6() { Item = DateTime.Now };

                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                        NewDtls = expectedSettlementDtls
                    });
                    stsRpt.Items = items.ToArray();

                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }
                if (tblDTransactionRequest.FkTransactionType == 3)
                {
                    var items = new List<SwitchOrderStatusAndReason2>();
                    var ordrStatus = new OrderStatus4Choice();
                    ordrStatus.Items = new object[1];
                    ordrStatus.Items[0] = OrderStatus4Code.PACK;

                    var expectedSettlementDtls = new ExpectedExecutionDetails2();
                    expectedSettlementDtls.XpctdCshSttlmDt = DateTime.Now;
                    expectedSettlementDtls.XpctdTradDtTm = new DateAndDateTimeChoice6() { Item = DateTime.Now };

                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransactionRequest.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                        NewDtls = expectedSettlementDtls
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }


                doc.OrdrInstrStsRpt = ordrInstrStsRptV04;
                var result = XmlHelper.SerializeToXmlString(doc);
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static string BusinessRejectedBuilderV4(TblDTransaction tblDTransaction, string rejectCode, string addtionalRejectInfo)
        {

            try
            {
                TblDCalastoneTransactionRequest req = new TblDCalastoneTransactionRequest();

                var doc = new Document6();


                var ordrInstrStsRptV04 = new OrderInstructionStatusReportV04();

                var msgId = new MessageIdentification16();
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                ordrInstrStsRptV04.MsgId = msgId;

                var refs = new References61Choice();
                refs.Items = new AdditionalReference86[1];
                refs.Items[0] = new AdditionalReference86() { Ref = req.SMessageId };
                ordrInstrStsRptV04.Ref = refs;

                var stsRpt = new Status24Choice();

                var reject = new RejectedStatus9();
                var rejectReason = new RejectedReason20Choice(); //item = Cd or Prtry

                if (String.IsNullOrEmpty(rejectCode))
                {
                    rejectReason.Item = rejectCode; // RejectedStatusReason11Code.BLCA; //Cd 
                }
                else
                {
                    rejectReason.Item = new GenericIdentification16() { Id = req.SFundId };
                }

                reject.AddtlInf = addtionalRejectInfo; ///TODO fill in the additional information here
                reject.Rsn = rejectReason;

                if (tblDTransaction.FkTransactionType == 1 || tblDTransaction.FkTransactionType == 2)
                {
                    var items = new List<IndividualOrderStatusAndReason7>();
                    var ordrStatus = new OrderStatus5Choice();
                    ordrStatus.Items = new string[1];

                    ordrStatus.Items[0] = reject; //rejected
                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransaction.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();

                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }
                if (tblDTransaction.FkTransactionType == 3)
                {
                    var items = new List<SwitchOrderStatusAndReason2>();
                    var ordrStatus = new OrderStatus4Choice();
                    ordrStatus.Items = new string[1];
                    ordrStatus.Items[0] = reject; //rejected
                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransaction.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }


                doc.OrdrInstrStsRpt = ordrInstrStsRptV04;
                var result = XmlHelper.SerializeToXmlString(doc);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string BusinessInRepairBuilderV4(TblDTransaction tblDTransaction)
        {


            try
            {
                TblDCalastoneTransactionRequest req = new TblDCalastoneTransactionRequest();

                var doc = new Document6();


                var ordrInstrStsRptV04 = new OrderInstructionStatusReportV04();

                var msgId = new MessageIdentification16();
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                ordrInstrStsRptV04.MsgId = msgId;

                var refs = new References61Choice();
                refs.Items = new AdditionalReference86[1];
                refs.Items[0] = new AdditionalReference86() { Ref = req.SMessageId };
                ordrInstrStsRptV04.Ref = refs;

                var stsRpt = new Status24Choice();

                var repairDetails = new InRepairStatusReason4Choice();
                repairDetails.Items = new object[1];

                var repairStatusReason = new InRepairStatusReason4();
                repairStatusReason.Rsn = new InRepairStatusReason5Choice() { Item = new GenericIdentification16() { Id = req.SFundId } };

                if (tblDTransaction.FkTransactionType == 1 || tblDTransaction.FkTransactionType == 2)
                {
                    var items = new List<IndividualOrderStatusAndReason7>();
                    var ordrStatus = new OrderStatus5Choice();
                    ordrStatus.Items = new string[1];

                    ordrStatus.Items[0] = repairDetails; //repair reason
                    items.Add(new IndividualOrderStatusAndReason7()
                    {
                        OrdrRef = tblDTransaction.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();

                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }
                if (tblDTransaction.FkTransactionType == 3)
                {
                    var items = new List<SwitchOrderStatusAndReason2>();
                    var ordrStatus = new OrderStatus4Choice();
                    ordrStatus.Items = new string[1];
                    ordrStatus.Items[0] = repairDetails; //repair
                    items.Add(new SwitchOrderStatusAndReason2()
                    {
                        OrdrRef = tblDTransaction.SOrderReference,
                        DealRef = CalastoneMessageIdGenerator.NewDealReference(),
                        OrdrSts = ordrStatus,
                    });
                    stsRpt.Items = items.ToArray();
                    ordrInstrStsRptV04.StsRpt = stsRpt;
                }


                doc.OrdrInstrStsRpt = ordrInstrStsRptV04;
                var result = XmlHelper.SerializeToXmlString(doc);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string SubOrderConfirmationBuilderV4(TblDTransaction tblDTransaction)
        {

            try
            {
                TblDCalastoneTransactionRequest req = new TblDCalastoneTransactionRequest();

                var doc = new Document3();
                var subscriptionOrderConfirmationV04 = new SubscriptionOrderConfirmationV04();

                var msgId = new MessageIdentification13(); //MsgId
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                //msgId.Id = tblDTransaction.SMessageId;

                msgId.CreDtTm = DateTime.UtcNow;
                subscriptionOrderConfirmationV04.MsgId = msgId;

                var refs = new AdditionalReference83(); //RltdRef
                refs.Ref = tblDTransaction.SRelatedReference;
                subscriptionOrderConfirmationV04.RltdRef = refs;

                var multipleOrdersExecutionDetails = new SubscriptionMultipleExecution5(); //MltplExctnDtls
                var investmentAccount583 = new InvestmentAccount583(); //InvstmtAcctDtls
                investmentAccount583.AcctId = req.SAccountId;
                investmentAccount583.AcctDsgnt = req.SAccountDesignation;

                if (!String.IsNullOrEmpty(req.SAgentCode))
                {
                    var partyIdentification1133 = new PartyIdentification1133();
                    partyIdentification1133.Pty = new PartyIdentification90Choice3() { Item = new GenericIdentification13() { Id = req.SAgentCode } };
                    investmentAccount583.AcctSvcr = partyIdentification1133;
                }
                multipleOrdersExecutionDetails.InvstmtAcctDtls = investmentAccount583;

                var indvExctnDtls = new SubscriptionExecution13[1]; //IndvExctnDtls
                indvExctnDtls[0] = new SubscriptionExecution13();
                indvExctnDtls[0].OrdrRef = tblDTransaction.SOrderReference; //OrdrRef
                indvExctnDtls[0].DealRef = tblDTransaction.SDealReference; //DealRef

                var finInstrmDtls = new FinancialInstrument573(); //FinInstrmDtls
                finInstrmDtls.Nm = req.SFundName; //Nm
                finInstrmDtls.SplmtryId = req.SProductCode; //SplmtryId

                if (req.FkFundIdtype == 1)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice3() { Item = req.SFundId, ItemElementName = ItemChoiceType29.ISIN };
                }
                else if (req.FkFundIdtype == 2)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice3() { Item = req.SFundId, ItemElementName = ItemChoiceType29.SEDOL };
                }
                indvExctnDtls[0].FinInstrmDtls = finInstrmDtls;

                indvExctnDtls[0].UnitsNb = tblDTransaction.DUnit ?? 0; //UnitsNb
                indvExctnDtls[0].NetAmt = new ActiveCurrencyAndAmount3() { Ccy = "AUD", Value = tblDTransaction.DNetAmount ?? 0 };
                indvExctnDtls[0].GrssAmt = new ActiveCurrencyAndAmount3() { Ccy = "AUD", Value = req.DGrossAmount ?? 0 };

                indvExctnDtls[0].TradDtTm = new DateAndDateTimeChoice3() { Item = Convert.ToDateTime(tblDTransaction.DtSettlementDate) }; //TradDtTm

                var dealPriceDtls = new UnitPrice221(); //DealgPricDtls
                dealPriceDtls.Tp = new TypeOfPrice46Choice1() { Item = TypeOfPrice10Code1.OFFR };
                dealPriceDtls.Val = new PriceValue11() { Amt = new ActiveCurrencyAnd13DecimalAmount1() { Ccy = "AUD", Value = tblDTransaction.DDealingPriceAmount ?? 0 } };
                indvExctnDtls[0].DealgPricDtls = dealPriceDtls;

                indvExctnDtls[0].SttlmAmt = new ActiveCurrencyAndAmount3() { Ccy = "AUD", Value = tblDTransaction.DSettlementAmount ?? 0 }; //SttlmAmt
                indvExctnDtls[0].CshSttlmDt = Convert.ToDateTime(tblDTransaction.DtSettlementDate); //CshSttlmDt

                ///TODO FXDtls required if dealing with foreign currency

                //var txOverHead = new TotalFeesAndTaxes401(); // TxOvrhd

                multipleOrdersExecutionDetails.IndvExctnDtls = new SubscriptionExecution13[1];
                multipleOrdersExecutionDetails.IndvExctnDtls = indvExctnDtls;

                doc.SbcptOrdrConf = new SubscriptionOrderConfirmationV04();
                subscriptionOrderConfirmationV04.MltplExctnDtls = multipleOrdersExecutionDetails;

                doc.SbcptOrdrConf = subscriptionOrderConfirmationV04;

                var result = XmlHelper.SerializeToXmlString(doc);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string RedOrderConfirmationBuilderV4(TblDTransaction tblDTransaction)
        {

            try
            {
                TblDCalastoneTransactionRequest req = new TblDCalastoneTransactionRequest();
                var doc = new Document1();
                var redOrdrConf = new RedemptionOrderConfirmationV04();

                var msgId = new MessageIdentification11(); //MsgId
                msgId.Id = CalastoneMessageIdGenerator.NewMessageId();
                msgId.CreDtTm = DateTime.UtcNow;
                redOrdrConf.MsgId = msgId;

                var refs = new AdditionalReference81(); //RltdRef
                refs.Ref = req.SMessageId;
                redOrdrConf.RltdRef = refs;

                var multipleOrdersExecutionDetails = new RedemptionMultipleExecution5(); //MltplExctnDtls

                var investmentAccount = new InvestmentAccount581(); //InvstmtAcctDtls
                investmentAccount.AcctId = req.SAccountId;
                investmentAccount.AcctDsgnt = req.SAccountDesignation;

                if (!String.IsNullOrEmpty(req.SAgentCode))
                {
                    var partyIdentification = new PartyIdentification1131();
                    partyIdentification.Pty = new PartyIdentification90Choice1() { Item = new GenericIdentification11() { Id = req.SAgentCode } };
                    investmentAccount.AcctSvcr = partyIdentification;
                }
                multipleOrdersExecutionDetails.InvstmtAcctDtls = investmentAccount;

                var indvExctnDtls = new RedemptionExecution15[1]; //IndvExctnDtls
                indvExctnDtls[0] = new RedemptionExecution15();
                indvExctnDtls[0].OrdrRef = tblDTransaction.SOrderReference; //OrdrRef
                indvExctnDtls[0].DealRef = tblDTransaction.SDealReference; //DealRef

                var finInstrmDtls = new FinancialInstrument571(); //FinInstrmDtls
                finInstrmDtls.Nm = req.SFundName; //Nm
                finInstrmDtls.SplmtryId = req.SProductCode; //SplmtryId

                if (req.FkFundIdtype == 1)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice1() { Item = req.SFundId, ItemElementName = ItemChoiceType11.ISIN };
                }
                else if (req.FkFundIdtype == 2)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice1() { Item = req.SFundId, ItemElementName = ItemChoiceType11.SEDOL };
                }
                indvExctnDtls[0].FinInstrmDtls = finInstrmDtls;

                indvExctnDtls[0].UnitsNb = tblDTransaction.DUnit ?? 0; //UnitsNb
                indvExctnDtls[0].NetAmt = new ActiveCurrencyAndAmount1() { Ccy = "AUD", Value = tblDTransaction.DNetAmount ?? 0 };
                indvExctnDtls[0].GrssAmt = new ActiveCurrencyAndAmount1() { Ccy = "AUD", Value = req.DGrossAmount ?? 0 };

                indvExctnDtls[0].TradDtTm = new DateAndDateTimeChoice1() { Item = Convert.ToDateTime(tblDTransaction.DtSettlementDate) }; //TradDtTm

                var dealPriceDtls = new UnitPrice22(); //DealgPricDtls
                dealPriceDtls.Tp = new TypeOfPrice46Choice() { Item = TypeOfPrice10Code1.BIDE };
                dealPriceDtls.Val = new PriceValue1() { Amt = new ActiveCurrencyAnd13DecimalAmount() { Ccy = "AUD", Value = tblDTransaction.DDealingPriceAmount ?? 0 } };
                indvExctnDtls[0].DealgPricDtls = dealPriceDtls;

                indvExctnDtls[0].SttlmAmt = new ActiveCurrencyAndAmount1() { Ccy = "AUD", Value = tblDTransaction.DSettlementAmount ?? 0 }; //SttlmAmt
                indvExctnDtls[0].CshSttlmDt = Convert.ToDateTime(tblDTransaction.DtSettlementDate); //CshSttlmDt

                ///TODO FXDtls required if dealing with foreign currency

                //var txOverHead = new TotalFeesAndTaxes401(); // TxOvrhd
                multipleOrdersExecutionDetails.IndvExctnDtls = new RedemptionExecution15[1];
                multipleOrdersExecutionDetails.IndvExctnDtls = indvExctnDtls;

                doc.RedOrdrConf = new RedemptionOrderConfirmationV04();
                doc.RedOrdrConf.MltplExctnDtls = new RedemptionMultipleExecution5();
                redOrdrConf.MltplExctnDtls = multipleOrdersExecutionDetails;

                doc.RedOrdrConf = redOrdrConf;

                var result = XmlHelper.SerializeToXmlString(doc);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string SwitchOrderConfirmationBuilderV4()
        {
            return "";
        }

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

        public string MultipleMessagesBuilderV4(List<string> messages)
        {
            string result = string.Empty;
            StringBuilder msg = new StringBuilder();
            try
            {
                msg.Append("<Messages>");
                foreach (var message in messages)
                {
                    msg.Append(message);
                }
                msg.Append("</Messages>");
                result = msg.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return result;
        }
    }
}

