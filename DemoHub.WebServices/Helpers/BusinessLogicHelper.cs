using System;
using System.Linq;
using DemoHub.Common;
using System.Text.Json;
using DemoHub.Common.Enums;
using System.Threading.Tasks;
using DemoHub.Persistence.Models;
using DemoHub.WebServices.Models;
using System.Collections.Generic;

namespace DemoHub.WebServices.Helpers
{
    public class BusinessLogicHelper
    {
        public static Task SendToRegistry(string uri, string token, TblDCalastoneTransactionRequest request)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                if (request.FkTransactionType == (int)CalastoneEnums.TransactionType.Subscription)
                {
                    #region Subscription
                    TAURUSNewApplication application = new TAURUSNewApplication
                    {
                        ReceivedAt = request.DtMessageCreationDateTime,
                        ProductID = request.IRegProductId
                    };
                    InvestmentDetails invDetails = new InvestmentDetails
                    {
                        ClassID = request.IRegFundClassId,
                        InvestmentAmount = request.DGrossAmount
                    };
                    application.investmentDetails.Add(invDetails);
                    string requestBody = JsonSerializer.Serialize(application);
                    string newSubscriptionApi = $"v1/api/admin/Transaction/{request.SAccountId}/Applications";
                    string newSubscriptionResult = HttpHelper.GetTAURUSResult(uri, token, newSubscriptionApi, requestBody, (int)HubEnums.HTTPMethod.Post);
                    if (!string.IsNullOrEmpty(newSubscriptionResult))
                    {
                        var element = JsonSerializer.Deserialize<JsonElement>(newSubscriptionResult, options);
                        request.SRegTransactionNumber = element.GetProperty("transactionNumber").GetString();
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.SentToRegistry;
                    }
                    else
                    {
                        request.SAdditionalRejectedReason = Gear.REJECT_REASON;
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                    }
                    #endregion Subscription
                }
                else if (request.FkTransactionType == (int)CalastoneEnums.TransactionType.Redemption)
                {
                    #region Redemption
                    #region Redeem unit/amount by holding rate
                    decimal? unitToBeRedeemed = null;
                    if (request.DHoldingsRedemptionRate != null && (request.DGrossAmount == null || request.DUnit == null))
                    {
                        string accountHoldingsApi = $"v1/api/admin/Account/{request.SAccountId}/holdings";
                        string accountHoldingsResult = HttpHelper.GetTAURUSResult(uri, token, accountHoldingsApi, null, (int)HubEnums.HTTPMethod.Get);

                        if (!string.IsNullOrEmpty(accountHoldingsResult))
                        {
                            var jsonElement = JsonSerializer.Deserialize<JsonElement>(accountHoldingsResult, options);
                            var element = jsonElement.EnumerateArray()
                                .SingleOrDefault(h => h.GetProperty("classID").GetInt32() == request.IRegFundClassId);
                            element.GetProperty("units").TryGetDecimal(out decimal units);
                            var holdings = Math.Abs(units);
                            unitToBeRedeemed ??= holdings * request.DHoldingsRedemptionRate;
                        }
                        else
                        {
                            request.SAdditionalRejectedReason = Gear.REJECT_REASON;
                            request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                        }
                    }
                    #endregion Redeem unit/amount by holding rate

                    TAURUSNewRedemption redemption = new TAURUSNewRedemption
                    {
                        ReceivedAt = request.DtMessageCreationDateTime,
                        ProductID = request.IRegProductId.ToString(),
                        ClassID = request.IRegFundClassId,
                        Amount = request.DGrossAmount,
                        Units = request.DUnit ?? unitToBeRedeemed
                    };
                    List<TAURUSNewRedemption> redemptions = new List<TAURUSNewRedemption> { redemption };
                    string requestBody = JsonSerializer.Serialize(redemptions);
                    string newRedemptionApi = $"v1/api/admin/Transaction/{request.SAccountId}/Redemptions";
                    string newRedemptionResult = HttpHelper.GetTAURUSResult(uri, token, newRedemptionApi, requestBody, (int)HubEnums.HTTPMethod.Post);
                    if (!string.IsNullOrEmpty(newRedemptionResult))
                    {
                        var element = JsonSerializer.Deserialize<JsonElement>(newRedemptionResult, options);
                        request.SRegTransactionNumber = element[0].GetProperty("transactionNumber").GetString();
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.SentToRegistry;
                    }
                    else
                    {
                        request.SAdditionalRejectedReason = Gear.REJECT_REASON;
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                    }
                    #endregion
                }
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ProcessTransaction(string uri, string token, TblDCalastoneTransactionRequest request)
        {
            string newTransactionNumber = string.Empty;
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };
                List<TransactionNumbers> listTranNumber = new List<TransactionNumbers>
                {
                    new TransactionNumbers()
                    {
                        TransactionNumber = request.SRegTransactionNumber
                    }
                };

                string requestBody = JsonSerializer.Serialize(listTranNumber);
                string approveFullyFundAndUnitiseApi = $"v1/api/admin/Transaction/ApproveFullyFundAndUnitise";
                string approveFullyFundAndUnitiseResult = HttpHelper.GetTAURUSResult(uri, token, approveFullyFundAndUnitiseApi, requestBody, (int)HubEnums.HTTPMethod.Post);
                if (!string.IsNullOrEmpty(approveFullyFundAndUnitiseResult))
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(approveFullyFundAndUnitiseResult, options);
                    var isDeserialized = jsonElement.TryGetProperty("unitise", out JsonElement element);
                    if (!isDeserialized || element.GetArrayLength() == 0)
                    {
                        request.SAdditionalRejectedReason = Gear.REJECT_REASON_UNUNITISED;
                        //request.SAdditionalRejectedReason = approveFullyFundAndUnitiseResult;
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                    }
                    else
                    {
                        newTransactionNumber = element[0].GetProperty("newTransactionNumber").GetString();
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.ProcessingInRegistry;
                    }
                }
                else
                {
                    request.SAdditionalRejectedReason = Gear.REJECT_REASON;
                    request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                }
                return newTransactionNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static TblDTransaction AppendTransaction(string uri, string token, string newTransactionNumber, TblDCalastoneTransactionRequest request)
        {
            TblDTransaction transaction = new TblDTransaction();
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                string transactionDetailApi = $"v1/api/admin/Transaction/{newTransactionNumber}";
                var transactionDetailResult = HttpHelper.GetTAURUSResult(uri, token, transactionDetailApi, null, (int)HubEnums.HTTPMethod.Get);
                if (!string.IsNullOrEmpty(transactionDetailResult))
                {
                    var element = JsonSerializer.Deserialize<JsonElement>(transactionDetailResult, options);
                    var classId = element[0].GetProperty("classID").GetInt32();
                    if (element.GetArrayLength() == 1 && classId == request.IRegFundClassId)
                    {
                        #region append transaction table
                        var units = element[0].GetProperty("units").GetDecimal();
                        var price = element[0].GetProperty("price").GetDecimal();
                        element[0].GetProperty("amount").TryGetDecimal(out decimal amount); // net amount
                        element[0].GetProperty("transactionDate").TryGetDateTime(out DateTime effectiveDate); // effective date

                        var isGrsAmtDeserialized = element[0].TryGetProperty("grossAmount", out JsonElement grsamtElement);
                        if (isGrsAmtDeserialized)
                        {
                            grsamtElement.TryGetDecimal(out decimal grossAmount);
                            //transaction.DGrossAmount = grossAmount;
                        }

                        var isSttlDtDeserialized = element[0].TryGetProperty("settlementDate", out JsonElement sttlDtElement);
                        if (isSttlDtDeserialized)
                        {
                            sttlDtElement.TryGetDateTime(out DateTime settlementDate);
                            transaction.DtSettlementDate = settlementDate;
                        }

                        transaction.FkTransactionRequest = request.KTransactionRequest;
                        transaction.SRegTransactionNumber = newTransactionNumber;
                        transaction.FkTransactionType = request.FkTransactionType;
                        //transaction.FkTransactionStatus = (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed;
                        //transaction.FkTransactionResource = request.FkTransactionRequestResource;
                        //transaction.DtMessageCreationDateTime = DateTime.Now;
                        transaction.SRelatedReference = request.SMessageId;
                        //transaction.SAccountId = request.SAccountId;
                        //transaction.SAccountDesignation = request.SAccountDesignation;
                        //transaction.SAgentCode = request.SAgentCode;
                        transaction.SOrderReference = request.SOrderReference;
                        transaction.SDealReference = "Deal" + request.SOrderReference;
                        //transaction.FkFundIdtype = request.FkFundIdtype;
                        //transaction.SFundId = request.SFundId;
                        //transaction.SFundName = request.SFundName;
                        //transaction.SProductCode = request.SProductCode;
                        //transaction.SRegProductName = request.SRegProductName;
                        transaction.DNetAmount = amount;
                        transaction.DUnit = units;
                        transaction.DDealingPriceAmount = price;
                        transaction.DtEffectiveDate = effectiveDate;

                        if (request.FkTransactionType == (int)CalastoneEnums.TransactionType.Subscription)
                        {
                            transaction.FkDealingPriceTypeCode = (int)CalastoneEnums.PriceType.OFFR;
                            transaction.DSettlementAmount = amount;
                            //transaction.SMessageId = "OCS" + request.SMessageId;
                        }
                        else if (request.FkTransactionType == (int)CalastoneEnums.TransactionType.Redemption)
                        {
                            transaction.FkDealingPriceTypeCode = (int)CalastoneEnums.PriceType.BIDE;
                            transaction.DSettlementAmount = amount;
                            //transaction.SMessageId = "OCR" + request.SMessageId;
                        }
                        else if (request.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchRedemption)
                        {
                            transaction.FkDealingPriceTypeCode = (int)CalastoneEnums.PriceType.SWIC;
                            //transaction.SMessageId = "OCSO" + request.SMessageId;
                            //transaction.SLegOrderReference = request.SLegOrderReference;
                            //transaction.SLegDealReference = "leg_" + request.SLegOrderReference;
                        }
                        else if (request.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchSubscription)
                        {
                            transaction.FkDealingPriceTypeCode = (int)CalastoneEnums.PriceType.SWIC;
                            //transaction.SMessageId = "OCSI" + request.SMessageId;
                            //transaction.SLegOrderReference = request.SLegOrderReference;
                            transaction.SLegDealReference = "leg_" + request.SLegOrderReference;
                        }

                        transaction.IsPartiallyExecuted = false;
                        transaction.IsCumDividend = false;
                        //transaction.IsPhysicalDeliverable = request.IsPhysicalDeliverable;
                        transaction.VCreatedBy = 1;
                        transaction.VUpdatedBy = 1;
                        transaction.Dt2CreatedAt = DateTime.Now;
                        transaction.Dt2UpdatedAt = DateTime.Now;
                        #endregion
                    }
                    else
                    {
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.InRepair; // duplicate transaction numbers
                    }
                }
                else
                {
                    request.SAdditionalRejectedReason = Gear.REJECT_REASON;
                    request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                }
                return transaction;
            }
            catch (Exception ex)
            {
                throw ex ?? ex.InnerException;
            }
        }

        public static string SendSwitchRequest(string uri, string token, TblDCalastoneTransactionRequest outrequest, TblDCalastoneTransactionRequest inrequest)
        {
            string newTransactionNumber = string.Empty;
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                SwitchFrom switchFrom = new SwitchFrom
                {
                    ClassID = outrequest.IRegFundClassId
                };
                SwitchTo switchTo = new SwitchTo
                {
                    ClassID = inrequest.IRegFundClassId
                };
                Switch switchOrder = new Switch
                {
                    AccountNumber = outrequest.SAccountId,
                    ReceiptDateTime = outrequest.DtMessageCreationDateTime,
                    Units = outrequest.DUnit,
                    Amount = outrequest.DGrossAmount,
                    From = switchFrom,
                    To = switchTo
                };

                string requestBody = JsonSerializer.Serialize(switchOrder);
                string newSwitchApi = $"v1/api/admin/Switches";
                string newSwitchResult = HttpHelper.GetTAURUSResult(uri, token, newSwitchApi, requestBody, (int)HubEnums.HTTPMethod.Post);
                if (!string.IsNullOrEmpty(newSwitchResult))
                {
                    var element = JsonSerializer.Deserialize<JsonElement>(newSwitchResult, options);
                    newTransactionNumber = element.GetProperty("transactionNumber").GetString();
                    outrequest.SRegTransactionNumber = newTransactionNumber;
                    inrequest.SRegTransactionNumber = newTransactionNumber;

                    outrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.SentToRegistry;
                    inrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.SentToRegistry;
                }
                return newTransactionNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ProcessSwitch(string uri, string token,
            TblDCalastoneTransactionRequest outrequest, TblDCalastoneTransactionRequest inrequest,
            out string newOutTransactionNumber, out string newInTransactionNumber)
        {
            bool ind = false;
            newOutTransactionNumber = string.Empty;
            newInTransactionNumber = string.Empty;
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                List<TransactionNumbers> listTranNumber = new List<TransactionNumbers>
                {
                    new TransactionNumbers() { TransactionNumber = outrequest.SRegTransactionNumber }
                };

                string requestBody = JsonSerializer.Serialize(listTranNumber);
                string approveAndPostApi = $"v1/api/admin/Switches/ApproveAndPost";
                string approveAndPostResult = HttpHelper.GetTAURUSResult(uri, token, approveAndPostApi, requestBody, (int)HubEnums.HTTPMethod.Post);
                if (!string.IsNullOrEmpty(approveAndPostResult))
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(approveAndPostResult, options);
                    var isDeserialized = jsonElement[0].TryGetProperty("status", out JsonElement element);
                    if (!isDeserialized || element.GetString() != "Success")
                    {
                        outrequest.SAdditionalRejectedReason = jsonElement[0].GetProperty("resultMessage").GetString();
                        outrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                        inrequest.SAdditionalRejectedReason = jsonElement[0].GetProperty("resultMessage").GetString();
                        inrequest.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                    }
                    else
                    {
                        string newTransactionNumbers = jsonElement[0].GetProperty("transactionNumber").GetString();
                        newOutTransactionNumber = newTransactionNumbers.Split(',', 2)[0];
                        newInTransactionNumber = newTransactionNumbers.Split(',', 2)[1];
                        if (!string.IsNullOrEmpty(newOutTransactionNumber) && !string.IsNullOrEmpty(newInTransactionNumber))
                        {
                            ind = true;
                        }
                    }
                }
                return ind;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<TblDTransaction> GetAllReadyToBeSentToCTNTransactionSub()
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            List<TblDTransaction> tblDTransaction = new List<TblDTransaction>();

            try
            {
                tblDTransaction = dc.TblDTransaction
                    .Where(r => //r.FkTransactionStatus == (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed
                                //&& 
                        r.FkTransactionType == (int)CalastoneEnums.TransactionType.Subscription)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tblDTransaction;
        }

        public static List<TblDTransaction> GetAllReadyToBeSentToCTNTransactionRed()
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            List<TblDTransaction> tblDTransaction = new List<TblDTransaction>();

            try
            {
                tblDTransaction = dc.TblDTransaction
                    .Where(r => //r.FkTransactionStatus == (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed
                                //&& 
                        r.FkTransactionType == (int)CalastoneEnums.TransactionType.Redemption)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tblDTransaction;
        }

        public static List<Tuple<TblDTransaction, TblDTransaction>> GetAllReadyToBeSentToCTNTransactionSwitch()
        {
            DemoHubDBContext dc = new DemoHubDBContext();
            List<Tuple<TblDTransaction, TblDTransaction>> tranPairList = new List<Tuple<TblDTransaction, TblDTransaction>>();

            try
            {
                List<TblDTransaction> tblSwitchDTransaction = dc.TblDTransaction
                   .Where(o => //o.FkTransactionStatus == (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed
                               //&& 
                        (o.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchRedemption
                            || o.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchSubscription))
                   .ToList();

                foreach (TblDTransaction tran in tblSwitchDTransaction)
                {
                    tranPairList.Add(
                        Tuple.Create(
                            tran, tblSwitchDTransaction
                                .SingleOrDefault(o => //o.FkTransactionStatus == (int)CalastoneEnums.TransactionStatus.ReadyToBeConfirmed
                                                      //&& 
                                    o.FkTransactionType == (int)CalastoneEnums.TransactionType.SwitchSubscription
                                    && o.SOrderReference == tran.SOrderReference)
                            )
                    );
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tranPairList;
        }
    }
}