using CFAnalyzer.HTTP;
using CFAnalyzer.Loaders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFAnalyzer
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Data.problems = new List<Entities.Problem>();
            Data.submissions = new List<Entities.Submission>();
            Data.contestants = new List<Entities.Contestant>();


            var client = new HttpClient();
            Data.jsonData = 
                await client.GetStringAsync(Request.RequestCreator("contest.standings", APIKeyTB.Text, APISecretTB.Text, ContestIDTB.Text));
            ProblemsLoader.Load();
            ContestantsLoader.Load();

            Data.jsonData =
                await client.GetStringAsync(Request.RequestCreator("contest.status", APIKeyTB.Text, APISecretTB.Text, ContestIDTB.Text));
            SubmissionsLoader.Load();

            ResultTB.Text = Generators.SpecialAwards.Generate(int.Parse(TopTB.Text));

        }
    }
}
