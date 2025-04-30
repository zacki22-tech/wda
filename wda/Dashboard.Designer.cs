namespace wda
{
    partial class Dashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnactivestudents = new System.Windows.Forms.Button();
            this.btninactivestudents = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlogouts = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(54, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(256, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 137);
            this.panel1.TabIndex = 1;
            // 
            // btnactivestudents
            // 
            this.btnactivestudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivestudents.Location = new System.Drawing.Point(54, 217);
            this.btnactivestudents.Name = "btnactivestudents";
            this.btnactivestudents.Size = new System.Drawing.Size(106, 57);
            this.btnactivestudents.TabIndex = 2;
            this.btnactivestudents.Text = "Active Students";
            this.btnactivestudents.UseVisualStyleBackColor = true;
            // 
            // btninactivestudents
            // 
            this.btninactivestudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninactivestudents.Location = new System.Drawing.Point(54, 295);
            this.btninactivestudents.Name = "btninactivestudents";
            this.btninactivestudents.Size = new System.Drawing.Size(106, 61);
            this.btninactivestudents.TabIndex = 3;
            this.btninactivestudents.Text = "Inactive Students";
            this.btninactivestudents.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Controls.Add(this.btnlogouts);
            this.panel3.Controls.Add(this.btnlogs);
            this.panel3.Controls.Add(this.lbldashboard);
            this.panel3.Controls.Add(this.btnactivestudents);
            this.panel3.Controls.Add(this.lbldate);
            this.panel3.Controls.Add(this.btninactivestudents);
            this.panel3.Controls.Add(this.lblname);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 596);
            this.panel3.TabIndex = 7;
            // 
            // btnlogouts
            // 
            this.btnlogouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogouts.Location = new System.Drawing.Point(54, 452);
            this.btnlogouts.Name = "btnlogouts";
            this.btnlogouts.Size = new System.Drawing.Size(106, 61);
            this.btnlogouts.TabIndex = 5;
            this.btnlogouts.Text = "LOG OUTS";
            this.btnlogouts.UseVisualStyleBackColor = true;
            // 
            // btnlogs
            // 
            this.btnlogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogs.Location = new System.Drawing.Point(54, 376);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(106, 61);
            this.btnlogs.TabIndex = 4;
            this.btnlogs.Text = "LOGS";
            this.btnlogs.UseVisualStyleBackColor = true;
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.BackColor = System.Drawing.Color.Transparent;
            this.lbldashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.Location = new System.Drawing.Point(32, 173);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(137, 24);
            this.lbldashboard.TabIndex = 3;
            this.lbldashboard.Text = "DASHBOARD";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(81, 144);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(40, 16);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(70, 111);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 24);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(480, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 137);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(480, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 137);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(256, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 137);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Location = new System.Drawing.Point(480, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 137);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Location = new System.Drawing.Point(256, 401);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 137);
            this.panel7.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(747, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnactivestudents;
        private System.Windows.Forms.Button btninactivestudents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnlogouts;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}