using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;

using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;

namespace PostWomanLibrary.Models
{
    public class HTTPClient
    {
        private HttpClient _httpClient;

        public HTTPClient()
        {
            using HttpClient httpclient = _httpClient;
            _httpClient = new HttpClient();
        }

        ~HTTPClient() => _httpClient.Dispose();

        public static string ObjectToJsonString<T>(T data) => JsonConvert.SerializeObject(data);
        public static T JsonStringToSingleObject<T>(string mycontent) => JsonConvert.DeserializeObject<T>(mycontent);
        public static List<T> JsonStringToObjectList<T>(string mycontent) => JsonConvert.DeserializeObject<List<T>>(mycontent);
        public static string HttpUrlDecode(string data) => HttpUtility.UrlDecode(data);
        public static Dictionary<string, string> PostMessageSplit(string requestBody)
            => requestBody.Split('&').Select(value => value.Split('=')).ToDictionary(pair => pair[0], pair => pair[1]);
        public static string JsonPretty(string str) { try { string _str = JValue.Parse(str).ToString(Formatting.Indented); if (_str != null) return _str; } catch {} return str; }
        public static void OpenUrl(string url) {
            try { Process.Start(url); } 
            catch { 
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) Process.Start(new ProcessStartInfo(url.Replace("&", "^&")) { UseShellExecute = true });
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) Process.Start("xdg-open", url); else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) Process.Start("open", url);
                else throw new Exception($"Visit in {url}");    }   }

        //Post
        public async Task<string> PostStringRequest(string postUrl, string objString, string type = "")
        {
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("type", type),
                new KeyValuePair<string, string>("data", objString)
            };
            return await PostRequest(postUrl, queries);
        }
        public async Task<string> PostRequest(string postUrl, IEnumerable<KeyValuePair<string, string>> queries) // another check method 
        {
            using HttpContent q = new FormUrlEncodedContent(queries);
            using HttpResponseMessage response = await _httpClient.PostAsync(postUrl, q);
            using HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();   //Response
            return mycontent;
        }

        //GET
        public async Task<string> GetRequest(string getUrl) //put between ?/&
        {
            using HttpResponseMessage response = await _httpClient.GetAsync( getUrl );      //!
            using HttpContent content = response.Content;
            string mycontent = await content.ReadAsStringAsync();   //Response
            return mycontent;
        }

    }
}
