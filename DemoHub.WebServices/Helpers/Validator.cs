using System;
using DemoHub.Common;
using System.Text.Json;
using DemoHub.Common.Enums;
using DemoHub.Persistence.Models;
using System.Collections.Generic;

namespace DemoHub.WebServices.Helpers
{
    public class Validator
    {
        public static void Validate(string uri, string token, TblDCalastoneTransactionRequest request)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string accountNumberExitenceApi = $"v1/api/admin/Account/{request.SAccountId}/exists";
                string accountNumberExitenceResult = HttpHelper.GetTAURUSResult(uri, token, accountNumberExitenceApi, null, (int)HubEnums.HTTPMethod.Get);

                string type = Enum.GetName(typeof(CalastoneEnums.FundIDType), request.FkFundIdtype).ToLower();
                string getClassByFundIdApi = $"v1/api/admin/Classes/filter?{type}={request.SFundId}";
                string getClassByFundIdResult = HttpHelper.GetTAURUSResult(uri, token, getClassByFundIdApi, null, (int)HubEnums.HTTPMethod.Get);

                if (!string.IsNullOrEmpty(accountNumberExitenceResult) && !string.IsNullOrEmpty(getClassByFundIdResult))
                {
                    if (JsonSerializer.Deserialize<bool>(accountNumberExitenceResult, options))
                    {
                        var element = JsonSerializer.Deserialize<JsonElement>(getClassByFundIdResult, options);
                        if (element.GetProperty(type).GetString().Equals(request.SFundId))
                        {
                            request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessAccepted;
                            request.SFundName = element.GetProperty("className").GetString();
                            request.SProductCode = element.GetProperty("productCode").GetString();
                            request.SRegProductName = element.GetProperty("productName").GetString();
                            element.GetProperty("classID").TryGetInt32(out int classId);
                            request.IRegFundClassId = classId;
                            element.GetProperty("productID").TryGetInt32(out int productID);
                            request.IRegProductId = productID;
                        }
                        else
                        {
                            request.FkTransactionRequestRejectedReasonCode = (int)CalastoneEnums.RejectedReasonCode.DSEC;
                            request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                        }
                    }
                    else
                    {
                        request.FkTransactionRequestRejectedReasonCode = (int)CalastoneEnums.RejectedReasonCode.SAFE;
                        request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                    }
                }
                else
                {
                    request.SAdditionalRejectedReason = Gear.REJECT_REASON;
                    request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                }
            }
            catch (Exception ex)
            {
                throw ex ?? ex.InnerException;
            }
        }

        public static bool ValidateChess(string uri, string token, TblDCalastoneTransactionRequest request)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                string accountNumberExitenceApi = $"v1/api/admin/Account/{request.SAccountId}/exists";
                string accountNumberExitenceResult = HttpHelper.GetTAURUSResult(uri, token, accountNumberExitenceApi, null, (int)HubEnums.HTTPMethod.Get);

                string type = Enum.GetName(typeof(CalastoneEnums.FundIDType), request.FkFundIdtype).ToLower();
                string getClassByFundIdApi = $"v1/api/admin/Classes/filter?{type}={request.SFundId}";
                string getClassByFundIdResult = HttpHelper.GetTAURUSResult(uri, token, getClassByFundIdApi, null, (int)HubEnums.HTTPMethod.Get);

                if (!string.IsNullOrEmpty(accountNumberExitenceResult) && !string.IsNullOrEmpty(getClassByFundIdResult))
                {
                    if (JsonSerializer.Deserialize<bool>(accountNumberExitenceResult, options))
                    {
                        var element = JsonSerializer.Deserialize<JsonElement>(getClassByFundIdResult, options);
                        if (element.GetProperty(type).GetString().Equals(request.SFundId))
                        {
                            request.FkTransactionRequestStatus = 4;
                            request.SFundName = element.GetProperty("className").GetString();
                            request.SProductCode = element.GetProperty("productCode").GetString();
                            request.SRegProductName = element.GetProperty("productName").GetString();
                            element.GetProperty("classID").TryGetInt32(out int classId);
                            request.IRegFundClassId = classId;
                            element.GetProperty("productID").TryGetInt32(out int productID);
                            request.IRegProductId = productID;
                        }
                        else
                        {


                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex ?? ex.InnerException;
            }
        }

        public static void SyncSwitchOrders(List<TblDCalastoneTransactionRequest> requests)
        {
            try
            {
                foreach (var request in requests)
                {
                    var ordRef = request.SOrderReference;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ValidateTransactionRequest(List<TblDCalastoneTransactionRequest> requests)
        {
            try
            {
                DemoHubDBContext dc = new DemoHubDBContext();
                requests.ForEach(r => r.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.Validated);
                dc.TblDCalastoneTransactionRequest.UpdateRange(requests);
                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static void RejectTransactionRequest(TblDCalastoneTransactionRequest request, int? code)
        {
            try
            {
                DemoHubDBContext dc = new DemoHubDBContext();
                request.FkTransactionRequestRejectedReasonCode = code;
                request.FkTransactionRequestStatus = (int)CalastoneEnums.TransactionStatus.BusinessRejected;
                dc.TblDCalastoneTransactionRequest.Update(request);
                dc.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}