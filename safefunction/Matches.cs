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
        //647382618
        public void getData()
        {
            System.Net.WebClient downloader = new System.Net.WebClient();
            string strmatchInfo = downloader.DownloadString("http://kayleboersen.nl/api/index.php?token=" + Program.key + "&schedule=1");
            matchInfo = JsonConvert.DeserializeObject<List<MatchInfo>>(strmatchInfo);

        }
    }
}
