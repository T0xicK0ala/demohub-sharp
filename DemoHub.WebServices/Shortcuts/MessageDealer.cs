using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using CalastoneServiceReference;
using DemoHub.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DemoHub.WebServices.Shortcuts
{
    public class MessageDealer
    {
        public static void SubOrderV3Settler(Document15 docOrder)
        {
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
                            var grssAmt = (docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls[0].Item as ActiveOrHistoricCurrencyAndAmount).Value;
                            tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(grssAmt);
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
                dc.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static void SubOrderV4Settler(Document2 docOrder)
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

        private static void SaveOrder(string ordermsg)
        {
            //DemoHubDBContext dc = new DemoHubDBContext();
            //TblDTransactionRequest tblDTransactionRequest = new TblDTransactionRequest();

            //try
            //{
            //    XDocument doc = XDocument.Parse(ordermsg); //or XDocument.Load(path)
            //    string jsonText = JsonConvert.SerializeXNode(doc);
            //    dynamic obj = JsonConvert.DeserializeObject<dynamic>(jsonText);

            //    if (obj != null)
            //    {
            //        if (docOrder["@xmlns"] == "urn:iso:std:iso:20022:tech:xsd:setr.010.001.03")
            //        {
            //            tblDTransactionRequest.FkTransactionType = 1;
            //        }

            //        if (docOrder["@xmlns"] == "urn:iso:std:iso:20022:tech:xsd:setr.004.001.04")
            //        {
            //            tblDTransactionRequest.FkTransactionType = 2;
            //        }

            //        tblDTransactionRequest.FkTransactionRequestStatus = 1;
            //        tblDTransactionRequest.FkTransactionRequestResource = 2;

            //        tblDTransactionRequest.SMessageId = docOrder.SbcptOrdrV03.MsgId.Id;
            //        tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(docOrder.SbcptOrdrV03.MsgId.CreDtTm);
            //        tblDTransactionRequest.SAccountId = docOrder.SbcptOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctId;
            //        tblDTransactionRequest.SAccountDesignation = docOrder.SbcptOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;
            //        tblDTransactionRequest.SAgentCode = docOrder.SbcptOrdrV03.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr.Pty.PrtryId.Id;

            //        tblDTransactionRequest.SOrderReference = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls.OrdrRef;
            //        tblDTransactionRequest.FkFundIdtype = 1;
            //        tblDTransactionRequest.SFundId = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls.FinInstrmDtls.Id.ISIN;
            //        tblDTransactionRequest.SFundName = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls.FinInstrmDtls.Nm;

            //        tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls.AmtOrUnits.GrssAmt["#text"]);
            //        tblDTransactionRequest.IsPhysicalDeliverable = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls.PhysDlvryInd;
            //        tblDTransactionRequest.SFundManagerId = docOrder.SbcptOrdrV03.MltplOrdrDtls.IndvOrdrDtls.RltdPtyDtls.Id.Pty.PrtryId.Id;
            //        tblDTransactionRequest.FkDistributorCode = 5;
            //    }

            //    dc.TblDTransactionRequest.Add(tblDTransactionRequest);
            //    dc.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        public static string StatusReportShortcutBuilder(int? statusid)
        {
            string result = string.Empty;

            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = dc.TblDCalastoneTransactionRequest
                .FirstOrDefault();

            StringBuilder msg = new StringBuilder();
            try
            {
                msg.Append("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:setr.016.001.04\">");

                #region Message header
                string messageID = "Demo" + DateTime.Now.ToShortDateString();
                msg.Append($"<OrdrInstrStsRpt><MsgId><Id>{messageID}</Id><CreDtTm>{DateTime.Now.ToString("yyyy - MM - ddTHH:mm: ss.zzz")}</CreDtTm></MsgId>");
                #endregion Message header

                #region Reference number
                msg.Append($"<Ref><RltdRef><Ref>{tblDTransactionRequest.SMessageId}</Ref></RltdRef></Ref>");
                #endregion

                #region Choose IndvOrdrDtlsRpt or SwtchOrdrDtlsRpt
                //string str1 = "<IndvOrdrDtlsRpt>";
                msg.Append("<IndvOrdrDtlsRpt>");
                //string str2 = "<SwtchOrdrDtlsRpt>";
                msg.Append("<OrdrRef>DemoOrdrRef12345</OrdrRef>");
                msg.Append("<DealRef>DemoDealRef12345</DealRef>");
                #endregion



                #region Order status
                if (tblDTransactionRequest.FkTransactionRequestStatus == statusid) // received
                {
                    msg.Append("<OrdSts><Sts>RECE</Sts></OrdSts>");
                }

                if (tblDTransactionRequest.FkTransactionRequestStatus == statusid) // accepted
                {
                    msg.Append("<OrdSts><Sts>PACK</Sts></OrdSts>");
                }

                if (tblDTransactionRequest.FkTransactionRequestStatus == statusid) // rejected
                {
                    msg.Append($"<Rjctd><Rsn><Cd>FEEE</Cd><Prtry><Id><ISIN>{tblDTransactionRequest.SFundId}</Id></Prtry></Rsn>");
                    msg.Append("<AddtlInf>Unrecognised or invalid fee or commission.</AddtlInf></Rjctd>");
                }



                #region Business reject
                //msg.Append("<Rjctd><Rsn><Cd>");
                ////msg.Append(Cd);
                //msg.Append("</Cd><Prtry><Id>");
                ////msg.Append(Id);
                //msg.Append("</Id></Prtry></Rsn>");

                //msg.Append("<AddtlInf>");
                ////msg.Append(AddtlInf);
                //msg.Append("</AddtlInf></Rjctd>");
                #endregion

                #region In repair
                //msg.Append("<InRpr><RsnDtls><Rsn><Prtry><Id>");
                //msg.Append(Id);
                //msg.Append("</Id></Prtry></Rsn></RsnDtls></InRpr>");
                #endregion

                //msg.Append("</OrdSts>");

                #region New details
                msg.Append($"<NewDtls><XpctdTradDtTm><DtTm>{DateTime.Now.ToString("yyyy - MM - ddTHH:mm: ss.zzz")}</DtTm></XpctdTradDtTm>");
                //msg.Append("<Dt>");
                //msg.Append(Dt);
                //msg.Append("</Dt>");
                msg.Append($"<XpctdCshSttlmDt>{DateTime.Now.ToString("yyyy - MM - ddTHH:mm: ss.zzz")}</XpctdCshSttlmDt></NewDtls>");
                #endregion

                #endregion

                msg.Append("</IndvOrdrDtlsRpt>");
                //msg.Append("</SwtchOrdrDtlsRpt>");

                msg.Append("</OrdrInstrStsRpt></Document>");

                result = msg.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public static string OrderConfShortcutBuilder()
        {
            string result = string.Empty;

            DemoHubDBContext dc = new DemoHubDBContext();
            TblDTransaction tblDTransaction = dc.TblDTransaction
                .FirstOrDefault();

            StringBuilder msg = new StringBuilder();
            //try
            //{
            //    msg.Append("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:setr.012.001.04\">");
            //    msg.Append($"<SbcptOrdrConf><MsgId><Id>{tblDTransaction.SMessageId}</Id><CreDtTm>{DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.zzz")}</CreDtTm></MsgId>");

            //    msg.Append($"<RltdRef><Ref>{tblDTransaction.SRelatedReference}</Ref></RltdRef><MltplExctnDtls>");

            //    msg.Append($"<InvstmtAcctDtls><AcctId>{tblDTransaction.SAccountId}</AcctId><AcctDsgnt>{tblDTransaction.SAccountDesignation}</AcctDsgnt><AcctSvcr><Pty><PrtryId><Id>{tblDTransaction.SAgentCode}</Id></PrtryId></Pty></AcctSvcr></InvstmtAcctDtls>");


            //    #region IndvExctnDtls
            //    msg.Append($"<OrdrRef>{tblDTransaction.SOrderReference}</OrdrRef>");
            //    msg.Append($"<DealRef>{tblDTransaction.SDealReference}</DealRef>");



            //    msg.Append("<FinInstrmDtls><Id>");
            //    // 1 out of 3 choices
            //    //var fundID = "";
            //    //switch (fundID)
            //    //{
            //    //    case ("ISIN"):
            //    //        var a = "";
            //    //        break;
            //    //    case ("SEDOL"):
            //    //        break;
            //    //    default:
            //    //        break;
            //    //}

            //    msg.Append($"<ISIN>{tblDTransaction.SFundId}</ISIN>");

            //    //msg.Append("<SEDOL>");
            //    //msg.Append(SEDOL);
            //    //msg.Append("</SEDOL>");

            //    #region APIR - message version 3
            //    // ...
            //    #endregion APIR - message version 3

            //    msg.Append("</Id>");

            //    //msg.Append("<Nm>");
            //    //msg.Append(Nm);
            //    //msg.Append("</Nm>");
            //    //msg.Append("<SplmtryId>");
            //    //msg.Append(SplmtryId);
            //    //msg.Append("</SplmtryId>");


            //    msg.Append("</FinInstrmDtls>");

            //    msg.Append($"<UnitsNb>{tblDTransaction.DUnit}</UnitsNb>");
            //    msg.Append($"<NetAmt Ccy=\"AUD\">{tblDTransaction.DNetAmount}</NetAmt>");
            //    msg.Append($"<GrssAmt Ccy=\"AUD\">{tblDTransaction.DGrossAmount}</GrssAmt>");

            //    //string currencyCode = "";
            //    //msg.Append($"<NetAmt Ccy=\"{currencyCode}\">");
            //    ////msg.Append(NetAmt);
            //    //msg.Append("</NetAmt>");



            //    //msg.Append($"<GrssAmt Ccy=\"{currencyCode}\">");
            //    ////msg.Append(GrssAmt);
            //    //msg.Append("</GrssAmt>");


            //    // Effective Date

            //    msg.Append("<TradDtTm>");
            //    // 1 of 2
            //    //string date = "";
            //    //string datetime = "";
            //    //msg.Append($"<Dt>{date}</Dt>");
            //    msg.Append($"<DtTm>{tblDTransaction.DtEffectiveDate}</DtTm>");
            //    msg.Append("</TradDtTm>");

            //    // price
            //    msg.Append("<DealgPricDtls>");
            //    //string code = "";
            //    msg.Append($"<Tp><Cd>OFFR</Cd></Tp>");
            //    //string amt = "";
            //    msg.Append($"<Val><Amt Ccy=\"AUD\">{tblDTransaction.DDealingPriceAmount}</Amt></Val>");
            //    msg.Append("</DealgPricDtls>");



            //    msg.Append($"<SttlmAmt Ccy=\"AUD\">{tblDTransaction.DSettlementAmount}</SttlmAmt>");

            //    // settlement
            //    //string sdate = "";
            //    msg.Append($"<CshSttlmDt>{tblDTransaction.DtSettlementDate}</CshSttlmDt>");

            //    msg.Append($"<PrtlyExctdInd>false</PrtlyExctdInd>");
            //    msg.Append($"<CumDvddInd>false</CumDvddInd>");

            //    #endregion

            //    msg.Append($"<PhysDlvryInd>false</PhysDlvryInd>");
            //    msg.Append("</SbcptOrdrConf></Document>");



            //    result = msg.ToString();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            return result;
        }
    }
}
