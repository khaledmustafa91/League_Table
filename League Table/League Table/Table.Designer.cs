namespace League_Table
{
    partial class Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Table));
            this.Matches = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Played = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Won = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Matches
            // 
            this.Matches.AutoScroll = true;
            this.Matches.AutoSize = true;
            this.Matches.BackColor = System.Drawing.Color.Transparent;
            this.Matches.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Matches.Location = new System.Drawing.Point(12, 26);
            this.Matches.Name = "Matches";
            this.Matches.Size = new System.Drawing.Size(362, 330);
            this.Matches.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(431, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Results";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matches";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Team,
            this.Played,
            this.Won,
            this.Drawn,
            this.Lost,
            this.GF,
            this.GA,
            this.GD,
            this.Points});
            this.dataGridView1.Location = new System.Drawing.Point(431, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 261);
            this.dataGridView1.TabIndex = 3;
            // 
            // Team
            // 
            this.Team.HeaderText = "Team";
            this.Team.Name = "Team";
            // 
            // Played
            // 
            this.Played.HeaderText = "Played";
            this.Played.Name = "Played";
            // 
            // Won
            // 
            this.Won.HeaderText = "Won";
            this.Won.Name = "Won";
            // 
            // Drawn
            // 
            this.Drawn.HeaderText = "Drawn";
            this.Drawn.Name = "Drawn";
            // 
            // Lost
            // 
            this.Lost.HeaderText = "Lost";
            this.Lost.Name = "Lost";
            // 
            // GF
            // 
            this.GF.HeaderText = "GF";
            this.GF.Name = "GF";
            // 
            // GA
            // 
            this.GA.HeaderText = "GA";
            this.GA.Name = "GA";
            // 
            // GD
            // 
            this.GD.HeaderText = "GD";
            this.GD.Name = "GD";
            // 
            // Points
            // 
            this.Points.HeaderText = "Points";
            this.Points.Name = "Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(438, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avarage Remaining Time";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Transparent;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Time.Location = new System.Drawing.Point(719, 381);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(76, 25);
            this.Time.TabIndex = 5;
            this.Time.Text = "label3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(589, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Matches);
            this.Controls.Add(this.button1);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Matches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team;
        private System.Windows.Forms.DataGridViewTextBoxColumn Played;
        private System.Windows.Forms.DataGridViewTextBoxColumn Won;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn GF;
        private System.Windows.Forms.DataGridViewTextBoxColumn GA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button button2;
    }
}