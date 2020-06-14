using CFAnalyzer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFAnalyzer.Generators
{
    public static class SpecialAwards
    {
        private static string getTime(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(seconds));
            if (t.Days > 0) return t.ToString(@"d\d\,\ hh\:mm\:ss");
            return t.ToString(@"hh\:mm\:ss");

        }
        public static string Generate(int top)
        {
            string ret = " ";

            foreach (var Problem in Data.problems)
            {
                if (Data.submissions.Where(x => x.Problem == Problem && x.Verdict == Verdicts.Accepted).Count() == 0)
                    continue;
                var first = Data.submissions.Where(x => x.Problem == Problem && x.Verdict == Verdicts.Accepted)
                           .OrderBy(x => x.Time)
                           .ThenBy(x => x.Contestant.Rank)
                           .First();
                if (first == null)
                    continue;
                ret += "First to solve Problem " + Problem.Letter + ": \"";
                ret += first.Contestant.Handle + "\" at " + getTime(first.Time) + ".";
                ret += Environment.NewLine;
            }

            var firstAccepted = Data.submissions.Where(x => x.Verdict == Verdicts.Accepted)
                           .OrderBy(x => x.Time)
                           .ThenBy(x => x.Contestant.Rank)
                           .First();
            ret += "Extreme programmer \"First Accepted in contest\":";
            ret += "\"" + firstAccepted.Contestant.Handle + "\" ";
            ret += "at " + getTime(firstAccepted.Time) + ".\n";

            var lastAccepted = Data.submissions.Where(x => x.Verdict == Verdicts.Accepted)
                           .OrderByDescending(x => x.Time)
                           .ThenBy(x => x.Contestant.Rank)
                           .First();
            ret += "Steadfast Guru \"Last Accepted in contest\":";
            ret += "\"" + lastAccepted.Contestant.Handle + "\" ";
            ret += "at " + getTime(lastAccepted.Time) + ".\n";

            var solid = Data.contestants.OrderByDescending(con =>
                Data.submissions.Where(sub => sub.Contestant == con && sub.Verdict == Verdicts.Accepted
                && Data.submissions.Where(sub2 => sub2.Contestant == con && sub2.Verdict == Verdicts.WA && sub2.Problem == sub.Problem).Count() == 0)
                .Count())
                .First();
            int cnt = Data.submissions.Where(x => x.Contestant == solid && x.Verdict == Verdicts.Accepted
            && Data.submissions.Where(y => y.Contestant == solid && y.Verdict == Verdicts.WA && y.Problem == x.Problem).Count() == 0)
                .Count();
            ret += "Solid Programmer \"Most number of accepted from first Time\":";
            ret += "\"" + solid.Handle + "\" ";
            ret += "with " + cnt.ToString() + " Problems.\n";

            var relentless = Data.submissions.Where(x => x.Verdict == Verdicts.Accepted)
                .OrderByDescending(x =>
                Data.submissions.Where(y => y.Contestant == x.Contestant && y.Problem == x.Problem && y.Verdict == Verdicts.WA)
                .Count())
                .ThenBy(x => x.Contestant.Rank)
                .First();
            int relentlessCnt = Data.submissions.Where(x => x.Problem == relentless.Problem && x.Contestant == relentless.Contestant && x.Verdict == Verdicts.WA)
                .Count();
            ret += "Relentless programmer \"Solved a Problem after the highest number of wrong submissions\":";
            ret += "\"" + relentless.Contestant.Handle + "\" ";
            ret += "Accepted Problem " + relentless.Problem.Letter + " after " + relentlessCnt.ToString() + " wrong submissions.\n";

            string[] Rank = { "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth" };
            for (int i = 0; i < Math.Min(top, Data.contestants.Count); i++)
            {
                var curr = Data.contestants[i];
                int solvedProblems = Data.submissions.Where(x => x.Contestant == curr && x.Verdict == Verdicts.Accepted).Count();
                ret += "The " + Rank[i] + " place was \"" + curr.Handle + "\" With " + solvedProblems + " Problems with Penalty: " + curr.Penalty + ".\n";
            }

            return ret;
        }
    }
}
