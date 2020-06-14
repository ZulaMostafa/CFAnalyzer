using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CFAnalyzer.Entities
{
    public class Problem
    {
        private string name, letter;

        public string Name { get => name; set => name = value; }
        public string Letter { get => letter; set => letter = value; }

        public void deserialize(JObject problem)
        {
            Name = problem["name"].ToString();
            Letter = problem["index"].ToString();
        }
    }
}
