using System;
using System.Text;
using System.Net.Http;
using DemoHub.Common.Enums;
using System.Net.Http.Headers;

namespace DemoHub.WebServices.Helpers
{
    public static class HttpHelper
    {
        public static string GetTAURUSResult(string uri, string token, string url, string body, int httpmethod)
        {
            try
            {
                using HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(uri)
                };
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = httpmethod switch
                {
                    (int)HubEnums.HTTPMethod.Get => client.GetAsync(url).Result,
                    (int)HubEnums.HTTPMethod.Post => client.PostAsync(url, new StringContent(body, Encoding.UTF8, "application/json")).Result,
                    (int)HubEnums.HTTPMethod.Put => client.PutAsync(url, new StringContent(body, Encoding.UTF8, "application/json")).Result,
                    _ => throw new ArgumentException(message: "Invalid HTTP method", paramName: nameof(httpmethod))
                };

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}