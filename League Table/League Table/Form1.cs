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
    public partial class start : Form
    {
        public static int number_of_teams;
        public static int match_time;

        public start()
        {
            InitializeComponent();
        }

        private void Lets_Click(object sender, EventArgs e)
        {
            int TeamsCount;
            int Time;
            if ( !int.TryParse(Num_Of_Teams.Text , out TeamsCount) || !int.TryParse(Match_Time.Text, out Time))
            {
                MessageBox.Show("Please enter only numbers","Error" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (TeamsCount > 1 && Convert.ToInt32(Match_Time.Text) > 0)
                {
                    number_of_teams = TeamsCount;
                    match_time = Convert.ToInt32(Match_Time.Text);
                    League l = new League();
                    this.Hide();
                    l.Show();
                }
                else
                {
                    if (TeamsCount <= 1 && Convert.ToInt32(Match_Time.Text) <= 0)
                        MessageBox.Show("Num of teams should be greater than 1 and time greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (TeamsCount <= 1)
                        MessageBox.Show("Num of teams should be greater than 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (Convert.ToInt32(Match_Time.Text) <= 0)
                        MessageBox.Show("Time should be greater than 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void start_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Lets.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
            
          /*  Num_Of_Teams.Left = (Num_Of_Teams.Parent.Width - Num_Of_Teams.Parent.Height) / 2;
            Num_Of_Teams.Left += 350;
            Num_Of_Teams.Top = (Num_Of_Teams.Parent.Width - Num_Of_Teams.Parent.Height) / 2;

            label1.Left = (label1.Parent.Width - label1.Parent.Height) / 2;
            label1.Top = (label1.Parent.Width - label1.Parent.Height) / 2;


            Match_Time.Left = (label1.Parent.Width - label1.Parent.Height) / 2;
            Match_Time.Left += 350;
            Match_Time.Top = (label1.Parent.Width - label1.Parent.Height) / 2;
            Match_Time.Top += 50;

            label2.Left = (label1.Parent.Width - label1.Parent.Height) / 2;
            label2.Top = (label1.Parent.Width - label1.Parent.Height) / 2;
            label2.Top += 50;
            */
            panel1.Left = (panel1.Parent.Width - panel1.Parent.Height) / 2;
            panel1.Top = (panel1.Parent.Width - panel1.Parent.Height) / 2;

            panel1.Left += 100;
            panel1.Top -= 150;


            button1.Top = (label1.Parent.Width - label1.Parent.Height) / 2;
            button1.Top += 490;

            Font myfont = new Font("Times New Roman", 12.0f);
            Num_Of_Teams.Font = myfont;
            Match_Time.Font = myfont;
           // Num_Of_Teams.Font = new Font(Num_Of_Teams.Font, FontStyle.Regular);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
