using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHub.Application.Infrastructure.CTNMessageFactory
{
    internal class FeeAndTaxBuilder
    {
        internal static string MessageStringBuilder(string type)
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
    }
}
