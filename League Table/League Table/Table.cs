using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace League_Table
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
        }
        List<Teams> information = new List<Teams >();

        bool[] PlayedMatches = new bool[2000];
        int All_Matches;
        private void Table_Load(object sender, EventArgs e)
        {
            button2.Top += 350;
            button2.Left += 650;
            
            WindowState = FormWindowState.Maximized;

            string[] teams = new string[League.Teams_Names.Count];
            League.Teams_Names.CopyTo(teams);
            int count = League.Teams_Names.Count;
            int yLabel = 39, yText = 36;
            for (int i = 0; i < count; i++)
            {
                Teams t = new Teams(teams[i]);
//                KeyValuePair<int, Teams> k = new KeyValuePair<int, Teams>(0,t);

                information.Add( t);
                for (int j = i + 1; j < count; j++)
                {
                    Label team1 = new Label();
                    Label team2 = new Label();
                    Label dash = new Label();
                    TextBox team1Result = new TextBox();
                    TextBox team2Result = new TextBox();

                    Font myfont = new Font("Microsoft Sans Serif ,style=Bold, Italic", 10.0f);
                    team1.Font = myfont;
                    team1.ForeColor = Color.White;

                    team2.Font = myfont;
                    team2.ForeColor = Color.White;

                    dash.Font = myfont;
                    dash.ForeColor = Color.White;

                    team1.AutoSize = true;
                    team2.AutoSize = true;
                    team1.MaximumSize = new Size(120, 0);
                    team2.MaximumSize = new Size(150, 0);



                    team1.Text = teams[i];
                    team2.Text = teams[j];
                    dash.Text = "-";

                    team1.Size = new Size(97, 13);
                    team2.Size = new Size(97, 13);
                    dash.Size = new Size(10, 13);

                    team1Result.Size = new Size(24, 30);
                    team2Result.Size = new Size(24, 30);


                    team1.Location = new Point(16, yLabel);
                    team2.Location = new Point(256, yLabel);
                    dash.Location = new Point(181, yLabel);
                    team1Result.Location = new Point(137, yText);
                    team2Result.Location = new Point(212, yText);



                    Matches.Controls.Add(team1);
                    Matches.Controls.Add(team1Result);

                    Matches.Controls.Add(dash);

                    Matches.Controls.Add(team2Result);
                    Matches.Controls.Add(team2);

                    yLabel += 40;
                    yText += 40;

                }
            }
            All_Matches = Matches.Controls.Count/5;
            Time.Text = (Matches.Controls.Count/5 * start.match_time).ToString() ;
            for (int k = 0; k < information.Count; k++)
            {
                string[] arr = new string[9];
                arr = information[k].getinfo();
                dataGridView1.Rows.Add(arr);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PlayedMatchesMark = 0;
            int count = Matches.Controls.Count;
            int i = 0;
            for (int j = 0; j < count/5 ;j++)
            {
                if (PlayedMatches[j] == true || Matches.Controls[i + 1].Text == "" || Matches.Controls[i + 3].Text == "")
                {
                    i += 5;
                    continue;
                }
                string Team1 = Matches.Controls[i].Text;
                
                int Team1Result = Convert.ToInt32(Matches.Controls[i + 1].Text);

                string Team2 = Matches.Controls[i + 4].Text;

                int Team2Result = Convert.ToInt32(Matches.Controls[i+3].Text);


                PlayedMatches[j] = true;

                for (int k = 0; k < information.Count; k++)
                {
                    Teams t = information[k];
                    string name = t.getName();
                    if (name == Team1)
                    {
                        if (Team1Result > Team2Result)
                            t.Update(1, 0, 0, Team1Result, Team2Result);
                        else if (Team1Result == Team2Result)
                            t.Update(0, 1, 0, Team1Result, Team2Result);
                        else
                            t.Update(0, 0, 1, Team1Result, Team2Result);
                        
                    }

                    if (name == Team2)
                    {
                        if (Team2Result > Team1Result)
                            t.Update(1, 0, 0, Team2Result, Team1Result);
                        else if (Team1Result == Team2Result)
                            t.Update(0, 1, 0, Team2Result, Team1Result);
                        else
                            t.Update(0, 0, 1, Team2Result, Team1Result);
                    }
                    
                }
                i += 5;
                PlayedMatchesMark++;
            }

            dataGridView1.Rows.Clear();

            List<Teams> info = information.OrderByDescending(o => o.Points).ThenByDescending(o => o.GD).ToList();

            for (int k = 0; k < info.Count;k++)
            {
                string[] arr = new string[9];
                arr = info[k].getinfo();
                dataGridView1.Rows.Add(arr);
            }
            All_Matches -= PlayedMatchesMark;
            Time.Text = (All_Matches * start.match_time).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Teams
    {
        string TeamName;
        int Played, Won, Drawn, Lost, GF, GA;
        public int Points , GD;
        public Teams(string team)
        {
            TeamName = team;
            Played = 0;
            Won = 0;
            Drawn = 0;
            Lost = 0;
            GF = 0;
            GA = 0;
            GD = 0;
            Points = 0;
        }
        public void Update(int Won,int Drawn,int Lost,int GF, int GA)
        {
            this.Played += 1;
            this.Won += Won;
            this.Drawn += Drawn;
            this.Lost += Lost;
            this.GF += GF;
            this.GA += GA;
            this.GD = GF-GA;
            if(Won == 1)
                this.Points += 3;
            if (Drawn == 1)
                this.Points += 1;
        }
        public string getName()
        {
            return TeamName; 
        }
        public string[] getinfo()
        {
            string[] info = new string[9];
            info[0] = TeamName; 
            info[1] = Played.ToString();
            info[2] = Won   .ToString();
            info[3] = Drawn .ToString();
            info[4] = Lost  .ToString();
            info[5] = GF    .ToString();
            info[6] = GA    .ToString();
            info[7] = GD    .ToString();
            info[8] = Points.ToString();
            return info;
        }
    }
}
