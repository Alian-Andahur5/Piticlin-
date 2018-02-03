using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace XamarinEjemplo.Providers
{
    public static class ServicesHttp
    {

        const string SERVER = "http://192.168.8.100";
        const string PORT = "3002";

        ///<summary>
        ///POST METHOD
        ///</summary>
        async static public Task<HttpResponseMessage> ConsumeAPI(string endpoint, object parameters, string token = "")
        {

            HttpClient client = new HttpClient();
            if (!string.IsNullOrEmpty(token))
            {
                //solo si exite token agrega el token de sqlite al request
                var authenticationHeader = addTokenToRequest(token);
                client.DefaultRequestHeaders.Authorization = authenticationHeader;
            }
            var content = new StringContent(JsonConvert.SerializeObject((JObject)parameters), Encoding.UTF8, "application/json");

            try
            {
                var route = SERVER + ":" + PORT + "/api/" + endpoint;
                HttpResponseMessage response = await client.PostAsync(route, content);

                return await Task.FromResult(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        async static public Task<MemoryStream> DownloadFile(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                var stream = new MemoryStream();
                var downloadStream = await client.GetStreamAsync(url);
                if (downloadStream != null)
                {
                    await downloadStream.CopyToAsync(stream);
                }
                return await Task.FromResult(stream);
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                return null;
            }
        }

        ///<summary>
        ///GET METHOD
        ///</summary>
        async static public Task<HttpResponseMessage> ConsumeAPI(string endpoint, string token = "")
        {

            HttpClient client = new HttpClient();
            if (!string.IsNullOrEmpty(token))
            {
                //solo si exite token agrega el token de sqlite al request
                var authenticationHeader = addTokenToRequest(token);
                client.DefaultRequestHeaders.Authorization = authenticationHeader;
            }

            try
            {
                var route = SERVER + ":" + PORT + "/api/" + endpoint;
                HttpResponseMessage response = await client.GetAsync(route);

                return await Task.FromResult(response);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        ///<summary>
        ///GET WITH PARAMETERS METHOD
        ///</summary>
        async static public Task<HttpResponseMessage> ConsumeApiParameter(string endpoint, string parameter, string token = "")
        {

            HttpClient client = new HttpClient();
            if (!string.IsNullOrEmpty(token))
            {
                //solo si exite token agrega el token de sqlite al request
                var authenticationHeader = addTokenToRequest(token);
                client.DefaultRequestHeaders.Authorization = authenticationHeader;
            }
            try
            {
                var route = $"{SERVER}:{PORT}/api/{endpoint}{parameter}";
                HttpResponseMessage response = await client.GetAsync(route);
                return await Task.FromResult(response);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private static AuthenticationHeaderValue addTokenToRequest(string token)
        {
            return new AuthenticationHeaderValue("Bearer", token);
        }
        ///<summary>
        ///GET METHOD
        ///</summary>
        async static public Task<HttpResponseMessage> ConsumeExternalAPI(string endpoint)
        {

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);

                return await Task.FromResult(response);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}