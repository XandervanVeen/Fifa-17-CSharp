using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safefunction
{
   public  class MatchInfo
    {
        public int id { get; set; }

        public string team1 { get; set; }
        public string team2 { get; set; }

        public string matchtime { get; set; }
        public string breaktime { get; set; }
        public string resttime { get; set; }

        public string field { get; set; }

        public string team1score { get; set; }
        public string team2score { get; set; }
    }

    public class Matches
    {
        public List<MatchInfo> matchInfo = new List<MatchInfo>();
             
        public void getData()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string strmatchInfo = downloader.DownloadString("http://localhost/test-api-v5/?token=647382619&schedule=1");
            matchInfo = JsonConvert.DeserializeObject<List<MatchInfo>>(strmatchInfo);
        }

    }
}
