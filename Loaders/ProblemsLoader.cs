using CFAnalyzer.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAnalyzer.Loaders
{
    public class ProblemsLoader
    {
        public static void Load()
        {
            JObject all = JObject.Parse(Data.jsonData);
            JObject result = (JObject)all["result"];
            JArray problems = (JArray)result["problems"];
            foreach (var problem in problems)
            {
                Problem p = new Problem();
                p.deserialize((JObject)problem);
                Data.problems.Add(p);
            }
        }
    }
}
