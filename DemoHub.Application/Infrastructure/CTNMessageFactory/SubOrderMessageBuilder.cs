using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Application.Infrastructure.CTNMessageFactory
{
    public class SubOrderMessageBuilder
    {
        public static string MessageStringBuilder()
        {
            string result = string.Empty;

            StringBuilder msg = new StringBuilder();
            try
            {
                msg.Append("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:setr.010.001.04\"><SbcptOrdr>");

                #region Message header
                msg.Append("<MsgId><Id>");
                // msg.Append(messageID);
                msg.Append("</Id><CreDtTm>");
                string messageCreationDateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.zzz");
                // msg.Append(messageCreationDateTime);
                msg.Append("</CreDtTm></MsgId>");
                #endregion Message header

                msg.Append("<MltplOrdrDtls>");

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

                // need to pass a tag pair here
                #region Order details
                msg.Append("<IndvOrdrDtls><OrdrRef>");
                //msg.Append(OrdrRef);

                msg.Append("</OrdrRef><FinInstrmDtls><Id>");
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


                #region Amount or units
                msg.Append("<AmtOrUnits>");
                // 1 out of 2 choices
                msg.Append("<UnitsNb>");
                //msg.Append(UnitsNb);
                msg.Append("</UnitsNb>");
                string currencyCode = "";
                msg.Append($"<GrssAmt Ccy=\"{currencyCode}\">");
                //msg.Append(GrssAmt);
                msg.Append("</GrssAmt>");
                msg.Append("</AmtOrUnits>");

                msg.Append("<Rndg>");
                //msg.Append(Rndg);
                msg.Append("</Rndg>");
                #endregion Amount or units




                #region Total fee and tax
                msg.Append("<TxOvrhd>");
                // content
                msg.Append("</TxOvrhd>");
                #endregion Total fee and tax


                msg.Append("<PhysDlvryInd>");
                //msg.Append(PhysDlvryInd);
                msg.Append("</PhysDlvryInd>");

                msg.Append("<ReqdSttlmCcy>");
                //msg.Append(ReqdSttlmCcy);
                msg.Append("</ReqdSttlmCcy>");
                msg.Append("<ReqdNAVCcy>");
                //msg.Append(ReqdNAVCcy);
                msg.Append("</ReqdNAVCcy>");


                #region Fund manager ID
                msg.Append("<RltdPtyDtls><Id><Pty><PrtryId><Id>");
                //msg.Append(Id);
                msg.Append("</Id></PrtryId></Pty></Id><Role>");
                //msg.Append(Role);
                msg.Append("</Role></RltdPtyDtls>");
                #endregion Fund manager ID
                #endregion Order details

                msg.Append("</IndvOrdrDtls></MltplOrdrDtls></SbcptOrdr></Document>");

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
