namespace League_Table
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_Of_Teams = new System.Windows.Forms.TextBox();
            this.Match_Time = new System.Windows.Forms.TextBox();
            this.Lets = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Teams ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Match Time (in min)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Num_Of_Teams
            // 
            this.Num_Of_Teams.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Num_Of_Teams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Num_Of_Teams.Location = new System.Drawing.Point(333, 86);
            this.Num_Of_Teams.Multiline = true;
            this.Num_Of_Teams.Name = "Num_Of_Teams";
            this.Num_Of_Teams.Size = new System.Drawing.Size(128, 33);
            this.Num_Of_Teams.TabIndex = 2;
            // 
            // Match_Time
            // 
            this.Match_Time.Location = new System.Drawing.Point(333, 127);
            this.Match_Time.Multiline = true;
            this.Match_Time.Name = "Match_Time";
            this.Match_Time.Size = new System.Drawing.Size(128, 33);
            this.Match_Time.TabIndex = 3;
            // 
            // Lets
            // 
            this.Lets.BackColor = System.Drawing.Color.Transparent;
            this.Lets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lets.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lets.Location = new System.Drawing.Point(112, 202);
            this.Lets.Name = "Lets";
            this.Lets.Size = new System.Drawing.Size(237, 44);
            this.Lets.TabIndex = 4;
            this.Lets.Text = "Let\'s Start !";
            this.Lets.UseVisualStyleBackColor = false;
            this.Lets.Click += new System.EventHandler(this.Lets_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Num_Of_Teams);
            this.panel1.Controls.Add(this.Lets);
            this.panel1.Controls.Add(this.Match_Time);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(130, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 246);
            this.panel1.TabIndex = 6;
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.start_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num_Of_Teams;
        private System.Windows.Forms.TextBox Match_Time;
        private System.Windows.Forms.Button Lets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

