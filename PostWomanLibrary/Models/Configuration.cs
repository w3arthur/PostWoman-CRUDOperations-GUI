using PostWomanLibrary.Models.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PostWomanLibrary.Models
{
    public struct Configuration
    {
        private static HTTPClient _httpClient;


        public static Creator Creator = new Creator()
        {
            Url = "https://github.com/w3arthur",
            WebApp = "https://post.arthur.tk",
        };

        public static ExampleUrl ExampleUrl = new ExampleUrl() 
        {
            CheckReplace = "httpbin.org",
            Get = "http://httpbin.org/get",
            Post = "http://httpbin.org/post",
        };

        public static HTTPClient HTTPClient { get { HTTPClientStart(); return _httpClient; } set { _httpClient = value; } }

        private static void HTTPClientStart() => HTTPClient = _httpClient ?? new HTTPClient();

    }
}
