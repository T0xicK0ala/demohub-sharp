using DemoHub.Common.Enums;
using DemoHub.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoHub.Chess.migrated_temp
{
    public class ApplicationMessageHandler
    {
        public static void MT727(Tuple<string, string, bool>[] obj)
        {
            try
            {
                var fundcode = obj[1].Item2.Trim();
                var grsAmount = obj[2].Item2.Trim();
                var timestamp = obj[20].Item2;
                var proName = obj[233].Item2;

                DemoHubDBContext dc = new DemoHubDBContext();
                //TblDTransactionRequest tblDTransactionRequest = new TblDTransactionRequest();
                //tblDTransactionRequest.FkTransactionRequestResource = (int)HubEnums.TransactionRequestResource.CHESS;
                //tblDTransactionRequest.FkTransactionType = 1;
                //tblDTransactionRequest.FkTransactionRequestStatus = 1;
                //tblDTransactionRequest.SMessageId = "MT727";
                //tblDTransactionRequest.DtMessageCreationDateTime = DateTime.Now;
                //tblDTransactionRequest.SAccountId = "A1000061";
                //tblDTransactionRequest.SOrderReference = "ChessOrder";
                //tblDTransactionRequest.FkFundIdtype = 3;
                //tblDTransactionRequest.SFundId = fundcode;
                //tblDTransactionRequest.IsPhysicalDeliverable = false;
                //tblDTransactionRequest.SFundManagerId = "client";
                //tblDTransactionRequest.FkDistributorCode = 5;
                //tblDTransactionRequest.DGrossAmount = 10000;
                //tblDTransactionRequest.DGrossAmount = Convert.ToDecimal(grsAmount);
                //tblDTransactionRequest.SRegProductName = proName;

                //dc.TblDTransactionRequest.Add(tblDTransactionRequest);
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
    }
}
