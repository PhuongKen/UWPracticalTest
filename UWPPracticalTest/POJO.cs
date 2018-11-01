using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UWPPracticalTest
{
    public class POJO
    {
        public async static Task<List<RootObject>> GetData()
        {
            var http = new HttpClient();
            var url = String.Format("http://youtube-video-api-1608.appspot.com/youtube/api");
            var response = await http.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();

            List<RootObject> data = JsonConvert.DeserializeObject<List<RootObject>>(result);

            return data;
        }
    }

    public class RootObject
    {
        public string videoId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string category { get; set; }
        public string genre { get; set; }
        public string authorName { get; set; }
        public string authorEmail { get; set; }
        public string birthday { get; set; }
    }
}
