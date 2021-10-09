using CalastoneServiceReference;
using DemoHub.Common.Enums;
using DemoHub.Persistence.Models;
using System;
using System.Linq;

namespace DemoHub.WebServices.MessageHandlers
{
    public class SubscriptionMessageHandler
    {
        #region Version 04
        public static void OrderV04(Document2 document)
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {
                tblDTransactionRequest.FkTransactionType = (int)CalastoneEnums.TransactionType.Subscription;
                tblDTransactionRequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.Received;
                //tblDTransactionRequest.FkTransactionRequestResource = (int)HubEnums.TransactionRequestResource.Calastone;
                tblDTransactionRequest.SMessageId = document.SbcptOrdr.MsgId.Id;
                tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(document.SbcptOrdr.MsgId.CreDtTm).ToLocalTime();
                tblDTransactionRequest.SAccountId = document.SbcptOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctId;
                tblDTransactionRequest.SAccountDesignation = document.SbcptOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;
                tblDTransactionRequest.SAgentCode = ((GenericIdentification12)document.SbcptOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr.Pty.Item).Id;

                var indvOrdrDtls = document.SbcptOrdr.MltplOrdrDtls.IndvOrdrDtls[0];
                tblDTransactionRequest.SOrderReference = indvOrdrDtls.OrdrRef;

                if (indvOrdrDtls.FinInstrmDtls.Id.ItemElementName.ToString() == "OthrPrtryId")
                {
                    tblDTransactionRequest.FkFundIdtype = (int)CalastoneEnums.FundIDType.APIR;
                    tblDTransactionRequest.SFundId = ((AlternateSecurityIdentification72)indvOrdrDtls.FinInstrmDtls.Id.Item).Id;
                }
                else
                {
                    tblDTransactionRequest.FkFundIdtype = (int)Enum.Parse(typeof(CalastoneEnums.FundIDType), indvOrdrDtls.FinInstrmDtls.Id.ItemElementName.ToString(), true);
                    tblDTransactionRequest.SFundId = indvOrdrDtls.FinInstrmDtls.Id.Item.ToString();
                }

                tblDTransactionRequest.SFundName = indvOrdrDtls.FinInstrmDtls.Nm;
                tblDTransactionRequest.SProductCode = indvOrdrDtls.FinInstrmDtls.SplmtryId;

                var itemName = indvOrdrDtls.AmtOrUnits.ItemElementName.ToString();
                switch (itemName)
                {
                    case "GrssAmt":
                        {
                            tblDTransactionRequest.DGrossAmount = ((ActiveOrHistoricCurrencyAndAmount2)indvOrdrDtls.AmtOrUnits.Item).Value;
                            ///TODO add the currency as foreign key 
                            var currency = ((ActiveOrHistoricCurrencyAndAmount2)indvOrdrDtls.AmtOrUnits.Item).Ccy;
                            //tblDTransactionRequest.FkGrossAmountCurrency = dc.TblSCurrency.FirstOrDefault(r => r.VCurrencyCode == currency).KCurrency;
                            tblDTransactionRequest.FkGrossAmountCurrency = (int)Enum.Parse<CalastoneEnums.Currency>(currency, true);
                            break;
                        }
                    case "UnitsNb":
                        {
                            tblDTransactionRequest.DUnit = (decimal)indvOrdrDtls.AmtOrUnits.Item;
                            break;
                        }
                }
                tblDTransactionRequest.IsPhysicalDeliverable = indvOrdrDtls.PhysDlvryInd;

                if (indvOrdrDtls.RndgSpecified)
                {
                    tblDTransactionRequest.FkRoundingCode = dc.TblSRoundingCode
                        .FirstOrDefault(r => r.SRoundingCode == indvOrdrDtls.Rndg.ToString())
                        .KRoundingCode;
                }

                var reqdSttlmCcy = indvOrdrDtls.ReqdSttlmCcy;
                if (!string.IsNullOrEmpty(reqdSttlmCcy))
                    tblDTransactionRequest.FkRequestedSettlementCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == reqdSttlmCcy).KCurrency;

                var reqdNAVCcy = indvOrdrDtls.ReqdNAVCcy;
                if (!string.IsNullOrEmpty(reqdNAVCcy))
                    tblDTransactionRequest.FkRequestedPricingCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == reqdNAVCcy).KCurrency;

                tblDTransactionRequest.SFundManagerId = ((GenericIdentification12)indvOrdrDtls.RltdPtyDtls[0].Id.Pty.Item).Id;
                tblDTransactionRequest.FkDistributorCode = (int)(InvestmentFundRole2Code2)indvOrdrDtls.RltdPtyDtls[0].Role.Item + 1;

                dc.TblDCalastoneTransactionRequest.Add(tblDTransactionRequest);
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
                throw ex;
            }
        }

        public static Document3 OrderConfirmationV04(TblDTransaction transaction)
        {
            try
            {
                TblDCalastoneTransactionRequest req = new TblDCalastoneTransactionRequest();

                Document3 document = new Document3();
                SubscriptionOrderConfirmationV04 sbcptOrdrConf = new SubscriptionOrderConfirmationV04();

                MessageIdentification13 msgId = new MessageIdentification13
                {
                    Id = req.SMessageId,
                    CreDtTm = DateTime.UtcNow
                };
                sbcptOrdrConf.MsgId = msgId;

                AdditionalReference83 refs = new AdditionalReference83
                {
                    Ref = transaction.SRelatedReference
                };
                sbcptOrdrConf.RltdRef = refs;

                SubscriptionMultipleExecution5 mltplExctnDtls = new SubscriptionMultipleExecution5();
                InvestmentAccount583 invstmtAcctDtls = new InvestmentAccount583
                {
                    AcctId = req.SAccountId,
                    AcctDsgnt = req.SAccountDesignation
                };

                if (!string.IsNullOrEmpty(req.SAgentCode))
                {
                    PartyIdentification1133 acctSvcr = new PartyIdentification1133
                    {
                        Pty = new PartyIdentification90Choice3()
                        {
                            Item = new GenericIdentification13()
                            {
                                Id = req.SAgentCode
                            }
                        }
                    };
                    invstmtAcctDtls.AcctSvcr = acctSvcr;
                }
                mltplExctnDtls.InvstmtAcctDtls = invstmtAcctDtls;

                var indvExctnDtls = new SubscriptionExecution13[1];
                indvExctnDtls[0] = new SubscriptionExecution13
                {
                    OrdrRef = transaction.SOrderReference,
                    DealRef = transaction.SDealReference
                };

                var finInstrmDtls = new FinancialInstrument573
                {
                    Nm = req.SFundName,
                    SplmtryId = req.SProductCode
                };

                if (req.FkFundIdtype == (int)CalastoneEnums.FundIDType.ISIN)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice3()
                    {
                        Item = req.SFundId,
                        ItemElementName = ItemChoiceType29.ISIN // 6
                    };
                }
                else if (req.FkFundIdtype == (int)CalastoneEnums.FundIDType.SEDOL)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice3()
                    {
                        Item = req.SFundId,
                        ItemElementName = ItemChoiceType29.SEDOL // 11
                    };
                }
                else if (req.FkFundIdtype == (int)CalastoneEnums.FundIDType.APIR)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice3()
                    {
                        Item = new AlternateSecurityIdentification73()
                        {
                            Id = req.SFundId,
                            IdSrc = new IdentificationSource1Choice3()
                            {
                                ItemElementName = ItemChoiceType28.Prtry,
                                Item = CalastoneEnums.FundIDType.APIR.ToString()
                            }
                        },
                        ItemElementName = ItemChoiceType29.OthrPrtryId

                    };
                }
                indvExctnDtls[0].FinInstrmDtls = finInstrmDtls;
                indvExctnDtls[0].UnitsNb = Math.Abs(transaction.DUnit ?? 0);
                indvExctnDtls[0].NetAmt = new ActiveCurrencyAndAmount3()
                {
                    Ccy = "AUD",
                    Value = Math.Abs(transaction.DNetAmount ?? decimal.Zero)
                };
                indvExctnDtls[0].GrssAmt = new ActiveCurrencyAndAmount3()
                {
                    Ccy = "AUD",
                    Value = Math.Abs(req.DGrossAmount ?? decimal.Zero)
                };
                indvExctnDtls[0].TradDtTm = new DateAndDateTimeChoice3()
                {
                    Item = Convert.ToDateTime(transaction.DtEffectiveDate)
                };
                UnitPrice221 dealgPricDtls = new UnitPrice221
                {
                    Tp = new TypeOfPrice46Choice1()
                    {
                        Item = TypeOfPrice10Code1.OFFR
                    },
                    Val = new PriceValue11()
                    {
                        Amt = new ActiveCurrencyAnd13DecimalAmount1()
                        {
                            Ccy = "AUD",
                            Value = 0 //req.DDealingPriceAmount
                        }
                    }
                };
                indvExctnDtls[0].DealgPricDtls = dealgPricDtls;
                indvExctnDtls[0].SttlmAmt = new ActiveCurrencyAndAmount3()
                {
                    Ccy = "AUD",
                    Value = Math.Abs(transaction.DSettlementAmount ?? decimal.Zero)
                };
                indvExctnDtls[0].CshSttlmDt = Convert.ToDateTime(transaction.DtSettlementDate);
                indvExctnDtls[0].CshSttlmDtSpecified = true;

                ///TODO FXDtls required if dealing with foreign currency
                //var txOverHead = new TotalFeesAndTaxes401(); // TxOvrhd

                mltplExctnDtls.IndvExctnDtls = new SubscriptionExecution13[1];
                mltplExctnDtls.IndvExctnDtls = indvExctnDtls;
                document.SbcptOrdrConf = new SubscriptionOrderConfirmationV04();
                sbcptOrdrConf.MltplExctnDtls = mltplExctnDtls;
                document.SbcptOrdrConf = sbcptOrdrConf;
                return document;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Version 03
        public static void OrderV03(Document15 docOrder)
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

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion
    }
}
