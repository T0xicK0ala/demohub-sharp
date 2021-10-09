//using System;
//using System.Text;

//namespace DemoHub.Application.Infrastructure.CTNMessageFactory
//{
//    /// <Summary>
//    /// ISO20022 setr.016.001.04
//    /// Order Instruction Status Report
//    /// </Summary>
//    public class OrderInstructionStatusReportBuilder
//    {
//        public static string MessageStringBuilderCTNConnection(CTNTransactionRequest transactionrequest)
//        {
//            string result = string.Empty;

//            StringBuilder msg = new StringBuilder();
//            try
//            {
//                msg.Append("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:setr.016.001.04\">");

//                #region Message header
//                string messageID = "";
//                msg.Append($"<OrdrInstrStsRpt><MsgId><Id>{messageID}</Id><CreDtTm>{DateTime.Now.ToString("yyyy - MM - ddTHH:mm: ss.zzz")}</CreDtTm></MsgId>");
//                #endregion Message header

//                #region Reference number
//                // [tbl_D_TransactionRequest].sMessageID
//                msg.Append("<Ref><RltdRef><Ref>");
//                // msg.Append(relatedReference);
//                msg.Append("</Ref></RltdRef></Ref>");
//                #endregion

//                #region Choose IndvOrdrDtlsRpt or SwtchOrdrDtlsRpt
//                //string str1 = "<IndvOrdrDtlsRpt>";
//                //string str2 = "<SwtchOrdrDtlsRpt>";
//                // msg.Append(str1);
//                // msg.Append(str2);
//                // [tbl_D_TransactionRequest].sOrderReference
//                msg.Append("<OrdrRef>");
//                // msg.Append(OrdrRef);
//                msg.Append("</OrdrRef>");
//                // deal reference
//                // if no DealRef then omit these tags.
//                msg.Append("<DealRef>");
//                // msg.Append(DealRef);
//                msg.Append("</DealRef>");
//                #endregion

//                #region Order status
//                msg.Append("<OrdSts>");

//                #region Business accept
//                msg.Append("<Sts>");
//                //msg.Append(Sts);
//                msg.Append("</Sts>");
//                #endregion

//                #region Business reject
//                msg.Append("<Rjctd><Rsn><Cd>");
//                //msg.Append(Cd);
//                msg.Append("</Cd><Prtry><Id>");
//                //msg.Append(Id);
//                msg.Append("</Id></Prtry></Rsn>");

//                msg.Append("<AddtlInf>");
//                //msg.Append(AddtlInf);
//                msg.Append("</AddtlInf></Rjctd>");
//                #endregion

//                #region In repair
//                msg.Append("<InRpr><RsnDtls><Rsn><Prtry><Id>");
//                //msg.Append(Id);
//                msg.Append("</Id></Prtry></Rsn></RsnDtls></InRpr>");
//                #endregion

//                msg.Append("</OrdSts>");

//                #region New details
//                msg.Append("<NewDtls><XpctdTradDtTm><Dt>");
//                //msg.Append(Dt);
//                msg.Append("</Dt><DtTm>");
//                //msg.Append(DtTm);
//                msg.Append("</DtTm></XpctdTradDtTm><XpctdCshSttlmDt>");
//                //msg.Append(XpctdCshSttlmDt);
//                msg.Append("</XpctdCshSttlmDt></NewDtls>");
//                #endregion

//                #endregion

//                //msg.Append("</IndvOrdrDtlsRpt>");
//                //msg.Append("</SwtchOrdrDtlsRpt>");

//                msg.Append("</OrdrInstrStsRpt></Document>");

//                result = msg.ToString();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex);
//            }

//            return result;
//        }

//        public static string StringBuilderV4(string status)
//        {
//            string result = string.Empty;

//            StringBuilder msg = new StringBuilder();
//            try
//            {
//                msg.Append("<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:setr.016.001.04\"><OrdrInstrStsRpt>");

//                #region Message header
//                msg.Append($"<MsgId><Id>{CalastoneMessageIdGenerator.NewMessageId()}</Id><CreDtTm>{DateTime.Now.ToString("yyyy - MM - ddTHH:mm: ss.zzz")}</CreDtTm></MsgId>");
//                #endregion Message header

//                #region Related reference
//                msg.Append($"<Ref><RltdRef><Ref>DBContext.SMessageID</Ref></RltdRef></Ref>");
//                #endregion Related reference

//                #region Choose IndvOrdrDtlsRpt or SwtchOrdrDtlsRpt
//                //string str1 = "<IndvOrdrDtlsRpt>";
//                //string str2 = "<SwtchOrdrDtlsRpt>";
//                // msg.Append(str1);
//                // msg.Append(str2);
//                // [tbl_D_TransactionRequest].sOrderReference
//                msg.Append("<OrdrRef>DemoOrdrRef12345</OrdrRef>");
//                msg.Append("<DealRef>DemoDealRef12345</DealRef>");
//                #endregion

//                #region Order status
//                msg.Append("<OrdSts>");

//                #region Business accept
//                msg.Append("<Sts>");
//                //msg.Append(Sts);
//                msg.Append("</Sts>");
//                #endregion

//                #region Business reject
//                msg.Append("<Rjctd><Rsn><Cd>");
//                //msg.Append(Cd);
//                msg.Append("</Cd><Prtry><Id>");
//                //msg.Append(Id);
//                msg.Append("</Id></Prtry></Rsn>");

//                msg.Append("<AddtlInf>");
//                //msg.Append(AddtlInf);
//                msg.Append("</AddtlInf></Rjctd>");
//                #endregion

//                #region In repair
//                msg.Append("<InRpr><RsnDtls><Rsn><Prtry><Id>");
//                //msg.Append(Id);
//                msg.Append("</Id></Prtry></Rsn></RsnDtls></InRpr>");
//                #endregion

//                msg.Append("</OrdSts>");



//                #endregion

//                #region New details
//                msg.Append("<NewDtls><XpctdTradDtTm><Dt>");
//                //msg.Append(Dt);
//                msg.Append("</Dt><DtTm>");
//                //msg.Append(DtTm);
//                msg.Append("</DtTm></XpctdTradDtTm><XpctdCshSttlmDt>");
//                //msg.Append(XpctdCshSttlmDt);
//                msg.Append("</XpctdCshSttlmDt></NewDtls>");
//                #endregion

//                //msg.Append("</IndvOrdrDtlsRpt>");
//                //msg.Append("</SwtchOrdrDtlsRpt>");

//                msg.Append("</OrdrInstrStsRpt></Document>");

//                result = msg.ToString();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex);
//            }

//            return result;
//        }

//        public static string MessageSerializationBuilder()
//        {
//            return "";
//        }
//    }
//}
