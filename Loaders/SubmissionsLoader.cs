using CFAnalyzer.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFAnalyzer.Loaders
{
    class SubmissionsLoader
    {
        public static void Load()
        {
            JObject d = JObject.Parse(Data.jsonData);
            JArray data = JArray.Parse(d["result"].ToString());
            foreach (var submission in data)
            {
                Submission s = new Submission();
                if (!s.deserialize((JObject)submission)) continue;
                Data.submissions.Add(s);
            }

            foreach (var contestant in Data.contestants)
            {
                foreach (var problem in Data.problems)
                {
                    if (Data.submissions.Where(x => x.Problem == problem && x.Contestant == contestant && x.Verdict == Verdicts.Accepted).Count() <= 1) continue;

                    int mx = Data.submissions.Where(x => x.Problem == problem && x.Contestant == contestant && x.Verdict == Verdicts.Accepted)
                       .OrderBy(x => x.Time)
                       .First()
                       .Time;
                    int cnt = Data.submissions.RemoveAll(x => x.Problem == problem && x.Contestant == contestant && x.Time > mx);
                }
            }
        }
    }
}
