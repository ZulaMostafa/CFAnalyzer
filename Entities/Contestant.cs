using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CFAnalyzer.Entities
{
    public class Contestant
    {
        private string handle;
        private int rank, penalty;

        public string Handle { get => handle; set => handle = value; }
        public int Rank { get => rank; set => rank = value; }
        public int Penalty { get => penalty; set => penalty = value; }

        public void deserialize(JObject contestant)
        {
            JArray members = (JArray)contestant["party"]["members"];
            Handle = members[0]["handle"].ToString();
            Penalty = (int)contestant["penalty"];
            Rank = (int)contestant["rank"];
        }
    }
}
