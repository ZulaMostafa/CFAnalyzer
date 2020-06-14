using CFAnalyzer.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAnalyzer.Loaders
{
    class ContestantsLoader
    {
        public static void Load()
        {
            JObject all = JObject.Parse(Data.jsonData);
            JObject result = (JObject)all["result"];
            JArray contestants = (JArray)result["rows"];
            foreach (var contestant in contestants)
            {
                Contestant c = new Contestant();
                c.deserialize((JObject)contestant);
                Data.contestants.Add(c);
            }    
        }
    }
}
