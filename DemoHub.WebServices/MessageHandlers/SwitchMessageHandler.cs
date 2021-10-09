using CalastoneServiceReference;
using DemoHub.Common.Enums;
using DemoHub.Persistence.Models;
using System;
using System.Linq;

namespace DemoHub.WebServices.MessageHandlers
{
    public class SwitchMessageHandler
    {
        #region Version 04
        public static void OrderV04(Document4 document)
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            try
            {
                var msgId = document.SwtchOrdr.MsgId.Id;
                var creDtTm = document.SwtchOrdr.MsgId.CreDtTm.ToLocalTime();
                var swtchOrdrDtls = document.SwtchOrdr.SwtchOrdrDtls[0];
                var ordrRef = swtchOrdrDtls.OrdrRef;

                // Parent level investment account details
                var acctId = swtchOrdrDtls.InvstmtAcctDtls.AcctId;
                var acctDsgnt = swtchOrdrDtls.InvstmtAcctDtls.AcctDsgnt;
                var agentCode = ((GenericIdentification14)swtchOrdrDtls.InvstmtAcctDtls.AcctSvcr.Pty.Item).Id;

                var rltdPtyDtls = swtchOrdrDtls.RltdPtyDtls[0];
                var distId = ((GenericIdentification14)rltdPtyDtls.Id.Pty.Item).Id;
                var distRole = (int)(InvestmentFundRole2Code4)rltdPtyDtls.Role.Item + 1;

                // Switch out
                #region Switch out
                var redLegDtls = swtchOrdrDtls.RedLegDtls[0];
                int redFundIdtype;
                if (redLegDtls.FinInstrmDtls.Id.ItemElementName.ToString() == "OthrPrtryId")
                {
                    redFundIdtype = (int)CalastoneEnums.FundIDType.APIR;
                }
                else
                {
                    redFundIdtype = (int)Enum.Parse(typeof(CalastoneEnums.FundIDType), redLegDtls.FinInstrmDtls.Id.ItemElementName.ToString(), true);
                }
                TblDCalastoneTransactionRequest tblDTransactionRequestSwitchOut = new TblDCalastoneTransactionRequest
                {
                    SMessageId = msgId,
                    DtMessageCreationDateTime = creDtTm,
                    SOrderReference = ordrRef,
                    FkTransactionType = (int)CalastoneEnums.TransactionType.SwitchRedemption,
                    FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.Received,
                    //FkTransactionRequestResource = (int)HubEnums.TransactionRequestResource.Calastone,
                    SAccountId = acctId,
                    SAccountDesignation = acctDsgnt,
                    SAgentCode = agentCode,
                    SLegOrderReference = redLegDtls.LegId,
                    FkFundIdtype = redFundIdtype,
                    SFundId = redLegDtls.FinInstrmDtls.Id.Item.ToString(),
                    SFundName = redLegDtls.FinInstrmDtls.Nm,
                    SProductCode = redLegDtls.FinInstrmDtls.SplmtryId,
                    SFundManagerId = distId,
                    FkDistributorCode = distRole,
                    IsPhysicalDeliverable = redLegDtls.PhysDlvryInd
                };

                switch (redLegDtls.FinInstrmQtyChc.ItemElementName.ToString())
                {
                    case "GrssAmt":
                        {
                            var grssAmt = (ActiveOrHistoricCurrencyAndAmount4)redLegDtls.FinInstrmQtyChc.Item;
                            tblDTransactionRequestSwitchOut.DGrossAmount = Convert.ToDecimal(grssAmt.Value);
                            tblDTransactionRequestSwitchOut.FkGrossAmountCurrency = dc.TblSCurrency
                                .FirstOrDefault(r => r.VCurrencyCode == grssAmt.Ccy).KCurrency;
                            break;
                        }
                    case "UnitsNb":
                        {
                            tblDTransactionRequestSwitchOut.DUnit = (decimal)redLegDtls.FinInstrmQtyChc.Item;
                            break;
                        }
                    case "HldgsRedRate":
                        {
                            tblDTransactionRequestSwitchOut.DHoldingsRedemptionRate = (decimal)redLegDtls.FinInstrmQtyChc.Item / 100;
                            break;
                        }
                }

                tblDTransactionRequestSwitchOut.FkUnitGroupCode = dc.TblSGroupUnitCode
                        .FirstOrDefault(r => r.SCode == redLegDtls.Grp1Or2Units.ToString())?
                        .KGroupUnitCode;

                var soreqdSttlmCcy = redLegDtls.ReqdSttlmCcy;
                if (!string.IsNullOrEmpty(soreqdSttlmCcy))
                    tblDTransactionRequestSwitchOut.FkRequestedSettlementCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == soreqdSttlmCcy).KCurrency;

                var soreqdNAVCcy = redLegDtls.ReqdNAVCcy;
                if (!string.IsNullOrEmpty(soreqdNAVCcy))
                    tblDTransactionRequestSwitchOut.FkRequestedPricingCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == soreqdNAVCcy).KCurrency;
                #endregion

                // Switch in
                #region Switch in
                var sbcptLegDtls = swtchOrdrDtls.SbcptLegDtls[0];
                int sbcptFundIdtype;
                if (sbcptLegDtls.FinInstrmDtls.Id.ItemElementName.ToString() == "OthrPrtryId")
                {
                    sbcptFundIdtype = (int)CalastoneEnums.FundIDType.APIR;
                }
                else
                {
                    sbcptFundIdtype = (int)Enum.Parse(typeof(CalastoneEnums.FundIDType), sbcptLegDtls.FinInstrmDtls.Id.ItemElementName.ToString(), true);
                }
                TblDCalastoneTransactionRequest tblDTransactionRequestSwitchIn = new TblDCalastoneTransactionRequest
                {
                    SMessageId = msgId,
                    DtMessageCreationDateTime = creDtTm,
                    SOrderReference = ordrRef,
                    FkTransactionType = (int)CalastoneEnums.TransactionType.SwitchSubscription,
                    FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.Received,
                    //FkTransactionRequestResource = (int)HubEnums.TransactionRequestResource.Calastone,
                    SAccountId = acctId,
                    SAccountDesignation = acctDsgnt,
                    SAgentCode = agentCode,
                    SLegOrderReference = sbcptLegDtls.LegId,
                    FkFundIdtype = sbcptFundIdtype,
                    SFundId = sbcptLegDtls.FinInstrmDtls.Id.Item.ToString(),
                    SFundName = sbcptLegDtls.FinInstrmDtls.Nm,
                    SProductCode = sbcptLegDtls.FinInstrmDtls.SplmtryId,
                    SFundManagerId = distId,
                    FkDistributorCode = distRole,
                    IsPhysicalDeliverable = sbcptLegDtls.PhysDlvryInd
                };

                switch (sbcptLegDtls.FinInstrmQtyChc.ItemElementName.ToString())
                {
                    case "PctgOfTtlRedAmt":
                        {
                            tblDTransactionRequestSwitchIn.DPercentageOfRedemptionAmount = ((decimal)sbcptLegDtls.FinInstrmQtyChc.Item) / 100;
                            break;
                        }
                }

                var sireqdSttlmCcy = sbcptLegDtls.ReqdSttlmCcy;
                if (!string.IsNullOrEmpty(sireqdSttlmCcy))
                    tblDTransactionRequestSwitchIn.FkRequestedSettlementCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == sireqdSttlmCcy).KCurrency;

                var sireqdNAVCcy = sbcptLegDtls.ReqdNAVCcy;
                if (!string.IsNullOrEmpty(sireqdNAVCcy))
                    tblDTransactionRequestSwitchIn.FkRequestedPricingCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == sireqdNAVCcy).KCurrency;
                #endregion


                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequestSwitchOut);
                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequestSwitchIn);

                int insertedRowCount = dc.SaveChanges();
                if (insertedRowCount == 0)
                {
                    // insertion failed
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static Document5 OrderConfirmationV04(
            TblDTransaction sotransaction,
            TblDTransaction sitransaction)
        {
            return null;
            //try
            //{
            //    Document5 document = new Document5();
            //    SwitchOrderConfirmationV04 switchOrderConfirmation = new SwitchOrderConfirmationV04();

            //    MessageIdentification15 msgId = new MessageIdentification15
            //    {
            //        Id = sotransaction.SMessageId,
            //        CreDtTm = DateTime.UtcNow
            //    };
            //    switchOrderConfirmation.MsgId = msgId;

            //    AdditionalReference85 rltdRef = new AdditionalReference85
            //    {
            //        Ref = sotransaction.SRelatedReference
            //    };
            //    switchOrderConfirmation.RltdRef = rltdRef;

            //    var swtchExctnDtls = new SwitchExecution7[1];
            //    swtchExctnDtls[0] = new SwitchExecution7
            //    {
            //        OrdrRef = sotransaction.SOrderReference,
            //        DealRef = sotransaction.SDealReference
            //    };

            //    InvestmentAccount585 invstmentAcctDtls = new InvestmentAccount585
            //    {
            //        AcctId = sotransaction.SAccountId,
            //        AcctDsgnt = sotransaction.SAccountDesignation
            //    };

            //    if (!string.IsNullOrEmpty(sotransaction.SAgentCode))
            //    {
            //        PartyIdentification1135 acctSvr = new PartyIdentification1135
            //        {
            //            Pty = new PartyIdentification90Choice5()
            //            {
            //                Item = new GenericIdentification15()
            //                {
            //                    Id = sotransaction.SAgentCode
            //                }
            //            }
            //        };
            //        invstmentAcctDtls.AcctSvcr = acctSvr;
            //    }
            //    swtchExctnDtls[0].InvstmtAcctDtls = invstmentAcctDtls;
            //    swtchExctnDtls[0].CshSttlmDt = sotransaction.DtSettlementDate;
            //    swtchExctnDtls[0].CshSttlmDtSpecified = true;

            //    #region Item1 -switch out
            //    var redLegDtls = new SwitchRedemptionLegExecution4[1];
            //    redLegDtls[0] = new SwitchRedemptionLegExecution4
            //    {
            //        LegId = sotransaction.SLegOrderReference,
            //        LegExctnId = sotransaction.SLegDealReference
            //    };

            //    FinancialInstrument575 oFinInstrmDtls = new FinancialInstrument575();
            //    if (sotransaction.FkFundIdtype == (int)CalastoneEnums.FundIDType.ISIN)
            //    {
            //        oFinInstrmDtls.Id = new SecurityIdentification25Choice5()
            //        {
            //            Item = sotransaction.SFundId,
            //            ItemElementName = ItemChoiceType51.ISIN
            //        };
            //    }
            //    else if (sotransaction.FkFundIdtype == (int)CalastoneEnums.FundIDType.SEDOL)
            //    {
            //        oFinInstrmDtls.Id = new SecurityIdentification25Choice5()
            //        {
            //            Item = sotransaction.SFundId,
            //            ItemElementName = ItemChoiceType51.SEDOL
            //        };
            //    }
            //    else if (sotransaction.FkFundIdtype == (int)CalastoneEnums.FundIDType.APIR)
            //    {
            //        oFinInstrmDtls.Id = new SecurityIdentification25Choice5()
            //        {
            //            Item = new AlternateSecurityIdentification75()
            //            {
            //                Id=sotransaction.SFundId,
            //                IdSrc = new IdentificationSource1Choice5()
            //                {
            //                    ItemElementName = ItemChoiceType50.Prtry,
            //                    Item = CalastoneEnums.FundIDType.APIR.ToString()
            //                }
            //            },
            //            ItemElementName = ItemChoiceType51.OthrPrtryId // 7
            //        };
            //    }

            //    oFinInstrmDtls.Nm = sotransaction.SFundName;
            //    oFinInstrmDtls.SplmtryId = sotransaction.SProductCode;
            //    redLegDtls[0].FinInstrmDtls = oFinInstrmDtls;

            //    redLegDtls[0].UnitsNb = Math.Abs(sotransaction.DUnit);
            //    redLegDtls[0].NetAmt = new ActiveCurrencyAndAmount5()
            //    {
            //        Ccy = "AUD",
            //        Value = Math.Abs(sotransaction.DNetAmount ?? decimal.Zero)
            //    };

            //    if (sotransaction.DGrossAmount != null)
            //    {
            //        redLegDtls[0].GrssAmt = new ActiveCurrencyAndAmount5()
            //        {
            //            Ccy = "AUD",
            //            Value = Math.Abs(sotransaction.DGrossAmount ?? decimal.Zero)
            //        };
            //    }

            //    //var switchOutinvstmtAcctDtls = new InvestmentAccount585();
            //    //switchOutinvstmtAcctDtls.AcctId = tblDTransactionSwitchOut.SAccountId;
            //    //switchOutinvstmtAcctDtls.AcctDsgnt = tblDTransactionSwitchOut.SAccountDesignation;

            //    redLegDtls[0].TradDtTm = new DateAndDateTimeChoice5()
            //    {
            //        Item = sotransaction.DtEffectiveDate
            //    };

            //    UnitPrice222 oPriceDtls = new UnitPrice222
            //    {
            //        Tp = new TypeOfPrice46Choice2()
            //        {
            //            Item = TypeOfPrice10Code2.SWIC
            //        },
            //        Val = new PriceValue12()
            //        {
            //            Amt = new ActiveCurrencyAnd13DecimalAmount2()
            //            {
            //                Ccy = "AUD",
            //                Value = sotransaction.DDealingPriceAmount
            //            }
            //        }
            //    };
            //    redLegDtls[0].PricDtls = oPriceDtls;
            //    redLegDtls[0].CumDvddInd = sotransaction.IsCumDividend;
            //    #endregion

            //    #region Item2 - switch in
            //    var subLegDtls = new SwitchSubscriptionLegExecution4[1];
            //    subLegDtls[0] = new SwitchSubscriptionLegExecution4
            //    {
            //        LegId = sitransaction.SLegOrderReference,
            //        LegExctnId = sitransaction.SLegDealReference
            //    };

            //    FinancialInstrument575 iFinInstrmDtls = new FinancialInstrument575();
            //    if (sitransaction.FkFundIdtype == (int)CalastoneEnums.FundIDType.ISIN)
            //    {
            //        iFinInstrmDtls.Id = new SecurityIdentification25Choice5()
            //        {
            //            Item = sitransaction.SFundId,
            //            ItemElementName = ItemChoiceType51.ISIN
            //        };
            //    }
            //    else if (sitransaction.FkFundIdtype == (int)CalastoneEnums.FundIDType.SEDOL)
            //    {
            //        iFinInstrmDtls.Id = new SecurityIdentification25Choice5()
            //        {
            //            Item = sitransaction.SFundId,
            //            ItemElementName = ItemChoiceType51.SEDOL
            //        };
            //    }
            //    else if (sitransaction.FkFundIdtype == (int)CalastoneEnums.FundIDType.APIR)
            //    {
            //        iFinInstrmDtls.Id = new SecurityIdentification25Choice5()
            //        {
            //            Item = new AlternateSecurityIdentification75()
            //            {
            //                Id = sitransaction.SFundId,
            //                IdSrc = new IdentificationSource1Choice5()
            //                {
            //                    ItemElementName = ItemChoiceType50.Prtry,
            //                    Item = CalastoneEnums.FundIDType.APIR.ToString()
            //                }
            //            },
            //            ItemElementName = ItemChoiceType51.OthrPrtryId // 7
            //        };
            //    }

            //    iFinInstrmDtls.Nm = sitransaction.SFundName;
            //    iFinInstrmDtls.SplmtryId = sitransaction.SProductCode;
            //    subLegDtls[0].FinInstrmDtls = iFinInstrmDtls;
            //    subLegDtls[0].UnitsNb = Math.Abs(sitransaction.DUnit);
            //    subLegDtls[0].NetAmt = new ActiveCurrencyAndAmount5()
            //    {
            //        Ccy = "AUD",
            //        Value = Math.Abs(sitransaction.DNetAmount ?? decimal.Zero)
            //    };

            //    if (sitransaction.DGrossAmount != null)
            //    {
            //        subLegDtls[0].GrssAmt = new ActiveCurrencyAndAmount5()
            //        {
            //            Ccy = "AUD",
            //            Value = Math.Abs(sitransaction.DGrossAmount ?? decimal.Zero)
            //        };
            //    }

            //    //var switchOutinvstmtAcctDtls = new InvestmentAccount585();
            //    //switchOutinvstmtAcctDtls.AcctId = tblDTransactionSwitchOut.SAccountId;
            //    //switchOutinvstmtAcctDtls.AcctDsgnt = tblDTransactionSwitchOut.SAccountDesignation;
            //    subLegDtls[0].TradDtTm = new DateAndDateTimeChoice5()
            //    {
            //        Item = sitransaction.DtEffectiveDate
            //    };

            //    UnitPrice222 inPriceDtls = new UnitPrice222
            //    {
            //        Tp = new TypeOfPrice46Choice2()
            //        {
            //            Item = TypeOfPrice10Code2.SWIC
            //        },
            //        Val = new PriceValue12()
            //        {
            //            Amt = new ActiveCurrencyAnd13DecimalAmount2()
            //            {
            //                Ccy = "AUD",
            //                Value = sitransaction.DDealingPriceAmount
            //            }
            //        }
            //    };
            //    subLegDtls[0].PricDtls = inPriceDtls;
            //    subLegDtls[0].CumDvddInd = sitransaction.IsCumDividend;
            //    #endregion

            //    swtchExctnDtls[0].RedLegDtls = redLegDtls;
            //    swtchExctnDtls[0].SbcptLegDtls = subLegDtls;

            //    document.SwtchOrdrConf = new SwitchOrderConfirmationV04();
            //    switchOrderConfirmation.SwtchExctnDtls = swtchExctnDtls;
            //    document.SwtchOrdrConf = switchOrderConfirmation;
            //    return document;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
        #endregion

        #region Version 03
        public static void OrderV03(Document17 document)
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
        #endregion
    }
}