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
    public partial class League : Form
    {
        public static List<string> Teams_Names = new List<string>();
        int num = start.number_of_teams;
        public League()
        {
            InitializeComponent();
        }

        private void League_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            remaining.Text = num.ToString();
            TeamsNameList.Left += 400;
            TeamsNameList.Width = 400;
            TeamsNameList.Height = 600;


            button3.Top += 400;

        }
        int y = 30;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Teams_Names.Contains(Select_Team.SelectedItem.ToString()) || Select_Team.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please Select diffrent team ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Teams_Names.Add(Select_Team.SelectedItem.ToString());
                num--;
                remaining.Text = num.ToString();

                Label teamName = new Label();
                Font myfont = new Font("Microsoft Sans Serif ,style=Bold, Italic", 22.0f);
                teamName.Font = myfont;
                teamName.ForeColor = Color.White;
                teamName.Location = new Point(10, y);
                teamName.Width = 200;
                teamName.AutoSize = true;
                teamName.Text = Teams_Names.ElementAt(Teams_Names.Count - 1);
                TeamsNameList.Controls.Add(teamName);
                y += 40;

                if (num == 0)
                {
                    MessageBox.Show("Teams Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Table t = new Table();
                    t.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num++;
            Teams_Names.RemoveAt(Teams_Names.Count - 1);
            remaining.Text = num.ToString();
            TeamsNameList.Controls.RemoveAt(TeamsNameList.Controls.Count - 1);
            y -= 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
