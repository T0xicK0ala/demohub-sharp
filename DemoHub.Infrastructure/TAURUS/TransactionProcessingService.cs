using System;
using System.Collections.Generic;
using System.Text;
using DemoHub.Application.Interfaces;
using DemoHub.Application.CTNTransactionRequests.Models;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;


namespace DemoHub.Infrastructure.TAURUS
{
    public class TransactionProcessingService : ITransactionProcessingService
    {
        // get transaction from taurus public api

        // append transaction request from tbl_D_TransactionRequest to tbl_D_Transaction

        // Get the effective date from registry
        // calculate settlement date base on effective date
        // get unit price against the effective date
        // call unitisation public api to get the transaction unitised
        // change transaction status in tbl_D_Transaction
        // ready to be sent to SQS as an order confirmation


    }

    // test pipeline
    //public class AppendTransactionStep:IPipelineStep<CTNTransactionRequestDto, Transaction>{
    //    public Transaction Process(CTNTransactionRequestDto input){
    //        CTNTransactionRequestDto dto = new CTNTransactionRequestDto(); // call dbcontext for transaction request
    //        Transaction tr = new Transaction();// call dbcontext for transaction
    //        // copy entity from one to the other
    //        return tr;
    //    }
    //}
}
