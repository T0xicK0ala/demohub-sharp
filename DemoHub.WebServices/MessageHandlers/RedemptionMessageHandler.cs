using CalastoneServiceReference;
using DemoHub.Common.Enums;
using DemoHub.Persistence.Models;
using System;
using System.Linq;

namespace DemoHub.WebServices.MessageHandlers
{
    public class RedemptionMessageHandler
    {
        #region Version 04
        public static void OrderV04(Document document)
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            TblDCalastoneTransactionRequest tblDTransactionRequest = new TblDCalastoneTransactionRequest();
            try
            {
                tblDTransactionRequest.FkTransactionType = (int)CalastoneEnums.TransactionType.Redemption;
                tblDTransactionRequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.Received;
                //tblDTransactionRequest.FkTransactionRequestResource = (int)HubEnums.TransactionRequestResource.Calastone;

                tblDTransactionRequest.SMessageId = document.RedOrdr.MsgId.Id;
                tblDTransactionRequest.DtMessageCreationDateTime = Convert.ToDateTime(document.RedOrdr.MsgId.CreDtTm).ToLocalTime();
                tblDTransactionRequest.SAccountId = document.RedOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctId;
                tblDTransactionRequest.SAccountDesignation = document.RedOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctDsgnt;
                tblDTransactionRequest.SAgentCode = ((GenericIdentification1)document.RedOrdr.MltplOrdrDtls.InvstmtAcctDtls.AcctSvcr.Pty.Item).Id;

                var indvOrdrDtls = document.RedOrdr.MltplOrdrDtls.IndvOrdrDtls[0];
                tblDTransactionRequest.SOrderReference = indvOrdrDtls.OrdrRef;
                if (indvOrdrDtls.FinInstrmDtls.Id.ItemElementName.ToString() == "OthrPrtryId")
                {
                    tblDTransactionRequest.FkFundIdtype = (int)CalastoneEnums.FundIDType.APIR;
                }
                else
                {
                    tblDTransactionRequest.FkFundIdtype = (int)Enum.Parse(typeof(CalastoneEnums.FundIDType), indvOrdrDtls.FinInstrmDtls.Id.ItemElementName.ToString(), true);
                }
                tblDTransactionRequest.SFundId = indvOrdrDtls.FinInstrmDtls.Id.Item.ToString();
                tblDTransactionRequest.SFundName = indvOrdrDtls.FinInstrmDtls.Nm;
                tblDTransactionRequest.SProductCode = indvOrdrDtls.FinInstrmDtls.SplmtryId;

                var itemName = indvOrdrDtls.AmtOrUnitsOrPctg.ItemElementName.ToString();
                switch (itemName)
                {
                    case "GrssAmt":
                        {
                            tblDTransactionRequest.DGrossAmount = ((ActiveOrHistoricCurrencyAndAmount)indvOrdrDtls.AmtOrUnitsOrPctg.Item).Value;
                            var currency = ((ActiveOrHistoricCurrencyAndAmount)indvOrdrDtls.AmtOrUnitsOrPctg.Item).Ccy;
                            tblDTransactionRequest.FkGrossAmountCurrency = dc.TblSCurrency.FirstOrDefault(r => r.VCurrencyCode == currency).KCurrency;
                            break;
                        }
                    case "UnitsNb":
                        {
                            tblDTransactionRequest.DUnit = (decimal)indvOrdrDtls.AmtOrUnitsOrPctg.Item;
                            break;
                        }
                    case "HldgsRedRate":
                        {
                            tblDTransactionRequest.DHoldingsRedemptionRate = (decimal)indvOrdrDtls.AmtOrUnitsOrPctg.Item / 100;
                            break;
                        }
                }

                if (indvOrdrDtls.RndgSpecified)
                {
                    tblDTransactionRequest.FkRoundingCode = dc.TblSRoundingCode
                        .FirstOrDefault(r => r.SRoundingCode == indvOrdrDtls.Rndg.ToString())
                        .KRoundingCode;
                }

                // Calastone doesn't implement Grp1Or2UnitsSpecified is true when Grp1Or2Units has value
                //if (indvOrdrDtls.Grp1Or2UnitsSpecified)
                tblDTransactionRequest.FkUnitGroupCode = dc.TblSGroupUnitCode
                    .FirstOrDefault(r => r.SCode == indvOrdrDtls.Grp1Or2Units.ToString())?
                    .KGroupUnitCode;

                var reqdSttlmCcy = indvOrdrDtls.ReqdSttlmCcy;
                if (!string.IsNullOrEmpty(reqdSttlmCcy))
                    tblDTransactionRequest.FkRequestedSettlementCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == reqdSttlmCcy).KCurrency;

                var reqdNAVCcy = indvOrdrDtls.ReqdNAVCcy;
                if (!string.IsNullOrEmpty(reqdNAVCcy))
                    tblDTransactionRequest.FkRequestedPricingCurrency = dc.TblSCurrency
                        .FirstOrDefault(r => r.VCurrencyCode == reqdNAVCcy).KCurrency;

                tblDTransactionRequest.IsPhysicalDeliverable = indvOrdrDtls.PhysDlvryInd;
                tblDTransactionRequest.SFundManagerId = ((GenericIdentification1)indvOrdrDtls.RltdPtyDtls[0].Id.Pty.Item).Id;
                tblDTransactionRequest.FkDistributorCode = (int)(InvestmentFundRole2Code)indvOrdrDtls.RltdPtyDtls[0].Role.Item + 1;

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

        public static Document1 OrderConfirmationV04(TblDTransaction transaction)
        {
            try
            {
                TblDCalastoneTransactionRequest req = new TblDCalastoneTransactionRequest();


                Document1 document = new Document1();
                RedemptionOrderConfirmationV04 redOrdrConf = new RedemptionOrderConfirmationV04();

                MessageIdentification11 msgId = new MessageIdentification11
                {
                    Id = req.SMessageId,
                    CreDtTm = DateTime.UtcNow
                };
                redOrdrConf.MsgId = msgId;

                AdditionalReference81 refs = new AdditionalReference81
                {
                    Ref = req.SMessageId
                };
                redOrdrConf.RltdRef = refs;

                RedemptionMultipleExecution5 mltplExctnDtls = new RedemptionMultipleExecution5();

                InvestmentAccount581 invstmtAcctDtls = new InvestmentAccount581
                {
                    AcctId = req.SAccountId,
                    AcctDsgnt = req.SAccountDesignation
                };

                if (!string.IsNullOrEmpty(req.SAgentCode))
                {
                    PartyIdentification1131 partyIdentification = new PartyIdentification1131
                    {
                        Pty = new PartyIdentification90Choice1()
                        {
                            Item = new GenericIdentification11()
                            {
                                Id = req.SAgentCode
                            }
                        }
                    };
                    invstmtAcctDtls.AcctSvcr = partyIdentification;
                }
                mltplExctnDtls.InvstmtAcctDtls = invstmtAcctDtls;

                var indvExctnDtls = new RedemptionExecution15[1];
                indvExctnDtls[0] = new RedemptionExecution15
                {
                    OrdrRef = transaction.SOrderReference,
                    DealRef = transaction.SDealReference
                };

                FinancialInstrument571 finInstrmDtls = new FinancialInstrument571
                {
                    Nm = req.SFundName,
                    SplmtryId = req.SProductCode
                };

                if (req.FkFundIdtype == (int)CalastoneEnums.FundIDType.ISIN)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice1()
                    {
                        Item = req.SFundId,
                        ItemElementName = ItemChoiceType11.ISIN
                    };
                }
                else if (req.FkFundIdtype == (int)CalastoneEnums.FundIDType.SEDOL)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice1()
                    {
                        Item = req.SFundId,
                        ItemElementName = ItemChoiceType11.SEDOL
                    };
                }
                else if (req.FkFundIdtype == (int)CalastoneEnums.FundIDType.APIR)
                {
                    finInstrmDtls.Id = new SecurityIdentification25Choice1()
                    {
                        Item = new AlternateSecurityIdentification71()
                        {
                            Id = req.SFundId,
                            IdSrc = new IdentificationSource1Choice1()
                            {
                                ItemElementName = ItemChoiceType10.Prtry,
                                Item = CalastoneEnums.FundIDType.APIR.ToString()
                            }
                        },
                        ItemElementName = ItemChoiceType11.OthrPrtryId // 7
                    };
                }

                indvExctnDtls[0].FinInstrmDtls = finInstrmDtls;

                indvExctnDtls[0].UnitsNb = 0; // Math.Abs(transaction.DUnit);
                indvExctnDtls[0].NetAmt = new ActiveCurrencyAndAmount1()
                {
                    Ccy = "AUD",
                    Value = Math.Abs(transaction.DNetAmount ?? decimal.Zero)
                };
                indvExctnDtls[0].GrssAmt = new ActiveCurrencyAndAmount1()
                {
                    Ccy = "AUD",
                    Value = Math.Abs(req.DGrossAmount ?? decimal.Zero)
                };

                indvExctnDtls[0].TradDtTm = new DateAndDateTimeChoice1()
                {
                    Item = Convert.ToDateTime(transaction.DtSettlementDate)
                };

                UnitPrice22 dealPriceDtls = new UnitPrice22
                {
                    Tp = new TypeOfPrice46Choice()
                    {
                        Item = TypeOfPrice10Code.BIDE
                    },
                    Val = new PriceValue1()
                    {
                        Amt = new ActiveCurrencyAnd13DecimalAmount()
                        {
                            Ccy = "AUD",
                            Value = 0 //transaction.DDealingPriceAmount
                        }
                    }
                };
                indvExctnDtls[0].DealgPricDtls = dealPriceDtls;

                indvExctnDtls[0].SttlmAmt = new ActiveCurrencyAndAmount1()
                {
                    Ccy = "AUD",
                    Value = Math.Abs(transaction.DSettlementAmount ?? decimal.Zero)
                };
                indvExctnDtls[0].CshSttlmDt = Convert.ToDateTime(transaction.DtSettlementDate);
                indvExctnDtls[0].CshSttlmDtSpecified = true;

                ///TODO FXDtls required if dealing with foreign currency

                //var txOverHead = new TotalFeesAndTaxes401(); // TxOvrhd
                mltplExctnDtls.IndvExctnDtls = new RedemptionExecution15[1];
                mltplExctnDtls.IndvExctnDtls = indvExctnDtls;
                document.RedOrdrConf = new RedemptionOrderConfirmationV04();
                redOrdrConf.MltplExctnDtls = mltplExctnDtls;
                document.RedOrdrConf = redOrdrConf;
                return document;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Version 03
        public static void OrderV03(Document13 docOrder)
        {
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