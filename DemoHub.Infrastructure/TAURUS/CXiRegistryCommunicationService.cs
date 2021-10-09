using System;
using System.Net;
using System.Text;
using DemoHub.Common;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace DemoHub.Infrastructure.TAURUS
{
    public class TAURUSCommunicationService
    {
        private const string JSON = "application/json";

        private readonly string _clientid;
        private readonly string _clientsecret;
        private readonly string _uri;
        private readonly string _audience;
        private readonly string _apiuri;
        //private readonly HttpClient client = new HttpClient();
        public TAURUSCommunicationService(
            string clientid,
            string clientsecret,
            string uri,
            string audience,
            string apiuri)
        {
            _clientid = clientid;
            _clientsecret = clientsecret;
            _uri = uri;
            _audience = audience;
            _apiuri = apiuri;
        }

        public string GetToken()
        {
            try
            {
                ServicePointManager.DefaultConnectionLimit = Process.GetCurrentProcess().Threads.Count;
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(JSON));
                    var content = $"{{\"client_id\":\"{_clientid}\",\"client_secret\":\"{_clientsecret}\",\"audience\":\"{_audience}\",\"grant_type\":\"client_credentials\"}}";
                    StringContent stringContent = new StringContent(content, Encoding.UTF8, JSON);
                    HttpResponseMessage response = client.PostAsync(_uri, stringContent).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result).access_token;
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dynamic RetrieveFrom(string apiurl)
        {
            if (!string.IsNullOrEmpty(GetToken()) && !string.IsNullOrWhiteSpace(GetToken()))
            {
                try
                {
                    ServicePointManager.DefaultConnectionLimit = Process.GetCurrentProcess().Threads.Count;
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(_apiuri);
                        var contentType = new MediaTypeWithQualityHeaderValue(JSON);
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + GetToken());
                        client.DefaultRequestHeaders.Accept.Add(contentType);
                        HttpResponseMessage response = client.GetAsync(apiurl).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            //return JsonConvert.DeserializeObject<dynamic>(response.Content.ReadAsStringAsync().Result);
                            return response.Content.ReadAsStringAsync().Result;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return Gear.UNAUTHORIZED;
            }
        }

        public string ProvideTo(string apiurl, string body)
        {
            if (!string.IsNullOrEmpty(GetToken()) && !string.IsNullOrWhiteSpace(GetToken()))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(_apiuri);
                        var contentType = new MediaTypeWithQualityHeaderValue(JSON);
                        client.DefaultRequestHeaders.Add("Authorization", "Bearer " + GetToken());
                        client.DefaultRequestHeaders.Accept.Add(contentType);
                        var content = new StringContent(body, Encoding.UTF8, JSON);
                        HttpResponseMessage response = client.PostAsync(apiurl, content).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            return response.Content.ReadAsStringAsync().Result;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return Gear.UNAUTHORIZED;
            }
        }

        #region deprecated code
        //public class TAURUSCommunicationService
        //{
        //    private readonly string _clientid;
        //    private readonly string _clientsecret;
        //    private readonly string _uri;
        //    private readonly string _audience;
        //    public TAURUSCommunicationService(string clientid, string clientsecret, string uri, string audience)
        //    {
        //        _clientid = clientid;
        //        _clientsecret = clientsecret;
        //        _uri = uri;
        //        _audience = audience;
        //    }

        //    public string GetToken()
        //    {
        //        try
        //        {
        //            HttpClient httpClient = new HttpClient();
        //            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //            var content = $"{{\"client_id\":\"{_clientid}\",\"client_secret\":\"{_clientsecret}\",\"audience\":\"{_audience}\",\"grant_type\":\"client_credentials\"}}";
        //            StringContent stringContent = new StringContent(content, Encoding.UTF8, "application/json");
        //            HttpResponseMessage httpResponseMessage = httpClient.PostAsync(_uri, stringContent).Result;
        //            string stringJWT = httpResponseMessage.Content.ReadAsStringAsync().Result;
        //            return JsonConvert.DeserializeObject<dynamic>(stringJWT).access_token;
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //            throw ex;
        //        }
        //    }
        //}
        #endregion
    }
}
