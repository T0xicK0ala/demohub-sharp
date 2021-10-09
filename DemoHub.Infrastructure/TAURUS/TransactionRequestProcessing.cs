//using System;
//using System.Collections.Generic;
//using System.Text;
//using DemoHub.Application.Interfaces;
//using System.Threading.Tasks;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using Newtonsoft.Json;
//using System.Linq;

//namespace DemoHub.Infrastructure.TAURUS
//{
//    public class TransactionRequestProcessing
//    {
//        // Get Transaction request by ID
//        // get this request's ISIN/APIR code
//        // call the below function to get class info
//        // save these info into tbl_D_transactionRequest

//        public string GetClassByFundID(string isin)
//        {
//            var url = @"url";

//            string clientid = @"clientid";
//            string clientsecret = @"clientsecret";

//            string accessToken = AuthenticationService.GetBearerToken(clientid, clientsecret);
//            HttpClient client = new HttpClient();
//            client.BaseAddress = new Uri(url);
//            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
//            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
//            client.DefaultRequestHeaders.Accept.Add(contentType);

//            string fundIDkey = "ISIN";
//            string fundIDvalue = "IE0000123456";

//            HttpResponseMessage response = client.GetAsync($"v1/api/admin/Classes/filter?{fundIDkey}={fundIDvalue}").Result;
//            string stringJWT = response.Content.ReadAsStringAsync().Result;

//            var foundClass = JsonConvert.DeserializeObject<dynamic>(stringJWT);
//            string classname = foundClass.className;

//            return classname;


//        }

//    }
//}