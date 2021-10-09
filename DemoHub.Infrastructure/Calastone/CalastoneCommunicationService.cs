using System;
using System.ServiceModel;
using System.Threading.Tasks;

using CalastoneServiceReference;
using static CalastoneServiceReference.Iso20022ServiceClient;

namespace DemoHub.Infrastructure.Calastone
{
    public class CalastoneCommunicationService
    {
        private readonly string _username;
        private readonly string _password;
        private readonly string _endpointAddress;
        public CalastoneCommunicationService(string username, string password, string endpointAddress)
        {
            _username = username;
            _password = password;
            _endpointAddress = endpointAddress;
        }
        public async Task<GetMessagesResponse> GetMessagesAsync()
        {
            var client = new Iso20022ServiceClient(EndpointConfiguration.ISO20022);
            try
            {
                client.Endpoint.Address = new EndpointAddress(_endpointAddress);
                var httpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);
                httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                httpBinding.MaxReceivedMessageSize = int.MaxValue; // SQS limitation is 256 Kb, 100 subscription orders is 124Kb.
                client.Endpoint.Binding = httpBinding;
                client.ClientCredentials.UserName.UserName = _username;
                client.ClientCredentials.UserName.Password = _password;
                client.ChannelFactory.Credentials.UserName.UserName = _username;
                client.ChannelFactory.Credentials.UserName.Password = _password;

                var response = await client.GetMessagesAsync();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client.State == CommunicationState.Opened)
                    await client.CloseAsync();
                else
                    client.Abort();
            }
        }
        public async Task<SendMessagesResponse> SendMessagesAsync(Messages messages)
        {
            var client = new Iso20022ServiceClient(EndpointConfiguration.ISO20022);
            try
            {
                client.Endpoint.Address = new EndpointAddress(_endpointAddress);
                var httpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);
                httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                httpBinding.MaxReceivedMessageSize = int.MaxValue;
                client.Endpoint.Binding = httpBinding;
                client.ClientCredentials.UserName.UserName = _username;
                client.ClientCredentials.UserName.Password = _password;
                client.ChannelFactory.Credentials.UserName.UserName = _username;
                client.ChannelFactory.Credentials.UserName.Password = _password;

                var response = await client.SendMessagesAsync(messages);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client.State == CommunicationState.Opened)
                    await client.CloseAsync();
                else
                    client.Abort();
            }
        }
        public async Task<SignalErrorResponse> SignalErrorAsync(string errorMessage, string errorReason)
        {
            var client = new Iso20022ServiceClient(EndpointConfiguration.ISO20022);
            try
            {
                client.Endpoint.Address = new EndpointAddress(_endpointAddress);
                var httpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);
                httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                httpBinding.MaxReceivedMessageSize = int.MaxValue;
                client.Endpoint.Binding = httpBinding;
                client.ClientCredentials.UserName.UserName = _username;
                client.ClientCredentials.UserName.Password = _password;
                client.ChannelFactory.Credentials.UserName.UserName = _username;
                client.ChannelFactory.Credentials.UserName.Password = _password;

                var response = await client.SignalErrorAsync(errorMessage, errorReason);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (client.State == CommunicationState.Opened)
                    await client.CloseAsync();
                else
                    client.Abort();
            }
        }


        #region deprecated code
        //public class CalastoneCommunicationService
        //{
        //    private readonly string _username;
        //    private readonly string _password;
        //    private readonly string _endpointAddress;
        //    public CalastoneCommunicationService(string username, string password, string endpointAddress)
        //    {
        //        _username = username;
        //        _password = password;
        //        _endpointAddress = endpointAddress;
        //    }
        //    public async Task<GetMessagesResponse> GetMessagesAsync()
        //    {
        //        try
        //        {
        //            var cal = new Iso20022ServiceClient(EndpointConfiguration.ISO20022);
        //            cal.Endpoint.Address = new EndpointAddress(_endpointAddress);
        //            var httpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);
        //            httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
        //            cal.Endpoint.Binding = httpBinding;
        //            cal.ClientCredentials.UserName.UserName = _username;
        //            cal.ClientCredentials.UserName.Password = _password;
        //            cal.ChannelFactory.Credentials.UserName.UserName = _username;
        //            cal.ChannelFactory.Credentials.UserName.Password = _password;

        //            var message = await cal.GetMessagesAsync();
        //            await cal.CloseAsync();
        //            return message;
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }

        //    }

        //    public async Task<SendMessagesResponse> SendMessagesAsync(Messages messages)
        //    {
        //        try
        //        {
        //            var cal = new Iso20022ServiceClient(EndpointConfiguration.ISO20022);
        //            cal.Endpoint.Address = new EndpointAddress(_endpointAddress);
        //            var httpBinding = new BasicHttpsBinding(BasicHttpsSecurityMode.Transport);
        //            httpBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
        //            cal.Endpoint.Binding = httpBinding;
        //            cal.ClientCredentials.UserName.UserName = _username;
        //            cal.ClientCredentials.UserName.Password = _password;
        //            cal.ChannelFactory.Credentials.UserName.UserName = _username;
        //            cal.ChannelFactory.Credentials.UserName.Password = _password;
        //            var result = await cal.SendMessagesAsync(messages);
        //            await cal.CloseAsync();
        //            return result;
        //        }
        //        catch (Exception ex)
        //        {

        //            throw;
        //        }


        //    }
        //}
        #endregion
    }
}