using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CFAnalyzer.Entities
{
    public enum Verdicts
    {
        WA = 0,
        Accepted = 1,
    }
    public class Submission
    {
        private Contestant contestant;
        private Problem problem;
        private int time;
        private Verdicts verdict;

        public Contestant Contestant { get => contestant; set => contestant = value; }
        public Problem Problem { get => problem; set => problem = value; }
        public int Time { get => time; set => time = value; }
        public Verdicts Verdict { get => verdict; set => verdict = value; }

        public bool deserialize(JObject submission)
        {
            JArray members = (JArray)submission["author"]["members"];
            if (Data.contestants.Where(x => x.Handle == members[0]["handle"].ToString()).Count() == 0) return false;
            if (submission["author"]["participantType"].ToString() != "CONTESTANT") return false;
            if (submission["verdict"].ToString() == "COMPILATION_ERROR") return false;
            Contestant = Data.contestants.Find(x => x.Handle == members[0]["handle"].ToString());
            Problem = Data.problems.Find(x => x.Name == submission["problem"]["name"].ToString());
            Time = (int)submission["relativeTimeSeconds"];
            if (submission["verdict"].ToString() == "OK") Verdict = Verdicts.Accepted;
            else Verdict = Verdicts.WA;
            return true;
        }
    }
}
