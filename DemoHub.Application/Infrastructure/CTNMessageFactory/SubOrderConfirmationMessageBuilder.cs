using System;
using System.Collections.Generic;
using System.Text;


namespace DemoHub.Application.Infrastructure.CTNMessageFactory
{
    /// <Summary>
    /// ISO20022 setr.012.001.04
    /// Subscription Order Confirmation
    /// </Summary>
    public class SubOrderConfirmationMessageBuilder
    {
        public static string MessageStringBuilder()
        {
            string result = string.Empty;

            StringBuilder msg = new StringBuilder();

            try
            {
                msg.Append("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:setr.012.001.04\">");

                #region Message header
                msg.Append("<SbcptOrdrConf><MsgId><Id>");
                // msg.Append(messageID);
                msg.Append("</Id><CreDtTm>");
                string messageCreationDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.zzz");
                // msg.Append(messageCreationDateTime);
                msg.Append("</CreDtTm></MsgId>");
                #endregion Message header

                string relatedRef = "";
                msg.Append($"<RltdRef><Ref>{relatedRef}</Ref></RltdRef>");
                msg.Append("<MltplExctnDtls>");


                #region Account
                msg.Append("<InvstmtAcctDtls><AcctId>");
                //msg.Append(AcctId);
                msg.Append("</AcctId>");

                // optional fields
                msg.Append("<AcctDsgnt>");
                //msg.Append(AcctDsgnt);
                msg.Append("</AcctDsgnt>");

                msg.Append("<AcctSvcr><Pty><PrtryId><Id>");
                //msg.Append(Id);
                msg.Append("</Id></PrtryId></Pty></AcctSvcr>");


                msg.Append("</InvstmtAcctDtls>");
                #endregion


                #region IndvExctnDtls
                string orderRef = "";
                msg.Append($"<OrdrRef>{orderRef}</OrdrRef>");
                string dealRef = "";
                msg.Append($"<DealRef>{dealRef}</DealRef>");



                msg.Append("<FinInstrmDtls><Id>");
                // 1 out of 3 choices
                //var fundID = "";
                //switch (fundID)
                //{
                //    case ("ISIN"):
                //        var a = "";
                //        break;
                //    case ("SEDOL"):
                //        break;
                //    default:
                //        break;
                //}

                msg.Append("<ISIN>");
                //msg.Append(ISIN);
                msg.Append("</ISIN>");
                msg.Append("<SEDOL>");
                //msg.Append(SEDOL);
                msg.Append("</SEDOL>");

                #region APIR - message version 3
                // ...
                #endregion APIR - message version 3

                msg.Append("</Id>");

                msg.Append("<Nm>");
                //msg.Append(Nm);
                msg.Append("</Nm>");
                msg.Append("<SplmtryId>");
                //msg.Append(SplmtryId);
                msg.Append("</SplmtryId>");


                msg.Append("</FinInstrmDtls>");







                msg.Append("<UnitsNb>");
                //msg.Append(UnitsNb);
                msg.Append("</UnitsNb>");

                string currencyCode = "";
                msg.Append($"<NetAmt Ccy=\"{currencyCode}\">");
                //msg.Append(NetAmt);
                msg.Append("</NetAmt>");



                msg.Append($"<GrssAmt Ccy=\"{currencyCode}\">");
                //msg.Append(GrssAmt);
                msg.Append("</GrssAmt>");


                // Effective Date

                msg.Append("<TradDtTm>");
                // 1 of 2
                string date = "";
                string datetime = "";
                msg.Append($"<Dt>{date}</Dt>");
                msg.Append($"<DtTm>{datetime}</DtTm>");
                msg.Append("</TradDtTm>");

                // price
                msg.Append("<DealgPricDtls>");
                string code = "";
                msg.Append($"<Tp><Cd>{code}</Cd></Tp>");
                string amt = "";
                msg.Append($"<Val><Amt Ccy=\"{currencyCode}\">{amt}</Amt></Val>");
                msg.Append("</DealgPricDtls>");



                msg.Append($"<SttlmAmt Ccy=\"{currencyCode}\">{amt}</SttlmAmt>");

                // settlement
                string sdate = "";
                msg.Append($"<CshSttlmDt>{sdate}</CshSttlmDt>");

                msg.Append($"<PrtlyExctdInd>false</PrtlyExctdInd>");
                msg.Append($"<CumDvddInd>false</CumDvddInd>");

                #endregion



                #region Foreign Exchange

                #endregion

                #region Indv Fee

                #endregion

                #region Indv Tax

                #endregion

                #region InftvTaxDtls

                #endregion

                msg.Append($"<PhysDlvryInd>false</PhysDlvryInd>");
                msg.Append("</SbcptOrdrConf></Document>");
                result = msg.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        public static string MessageSerializationBuilder()
        {
            return "";
        }
    }
}
