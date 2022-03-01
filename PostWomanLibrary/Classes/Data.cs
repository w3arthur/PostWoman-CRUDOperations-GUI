using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostWomanLibrary.Enums;
using PostWomanLibrary.Models;

namespace PostWomanLibrary.Classes
{
    public class Data
    {
        public static string EmptyMesage { get; } = "{\r\n \"\": \"\" \r\n}";

        public HTTPClient HTTPClient { private get; set; }
        public string Action { private get; set; }  //set trim()
        public Method Type { private get; set; }
        public string Message { private get; set; } //turn to json /pairs
        public bool IsMessageData { get; private set; }
        public bool IsFileUpload { get; private set; }

        

        public async Task<string> SentAsync()
        {
            try
            {
                switch (Type)
                {
                    case Method.Get: return await HTTPClient.GetRequest(Action);
                    case Method.Post: return null;
                    case Method.Put: return null;
                    case Method.Delete: return null;
                }
                return null;
            }
            catch (Exception ex) { return ex.Message; }
        }

    }
}
