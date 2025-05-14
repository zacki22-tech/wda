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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.btninactivestudents = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnactivestudents = new System.Windows.Forms.Button();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.btnlogs = new System.Windows.Forms.Button();
            this.btnlogouts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(63, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(113, 221);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(65, 24);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // btninactivestudents
            // 
            this.btninactivestudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninactivestudents.Location = new System.Drawing.Point(117, 635);
            this.btninactivestudents.Name = "btninactivestudents";
            this.btninactivestudents.Size = new System.Drawing.Size(133, 67);
            this.btninactivestudents.TabIndex = 3;
            this.btninactivestudents.Text = "Inactive Students";
            this.btninactivestudents.UseVisualStyleBackColor = true;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(138, 267);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(40, 16);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // btnactivestudents
            // 
            this.btnactivestudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivestudents.Location = new System.Drawing.Point(108, 518);
            this.btnactivestudents.Name = "btnactivestudents";
            this.btnactivestudents.Size = new System.Drawing.Size(133, 67);
            this.btnactivestudents.TabIndex = 2;
            this.btnactivestudents.Text = "Active Students";
            this.btnactivestudents.UseVisualStyleBackColor = true;
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.BackColor = System.Drawing.Color.Transparent;
            this.lbldashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.Location = new System.Drawing.Point(90, 320);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(137, 24);
            this.lbldashboard.TabIndex = 3;
            this.lbldashboard.Text = "DASHBOARD";
            this.lbldashboard.Click += new System.EventHandler(this.lbldashboard_Click);
            // 
            // btnlogs
            // 
            this.btnlogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogs.Location = new System.Drawing.Point(129, 750);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(133, 67);
            this.btnlogs.TabIndex = 4;
            this.btnlogs.Text = "LOGS";
            this.btnlogs.UseVisualStyleBackColor = true;
            // 
            // btnlogouts
            // 
            this.btnlogouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogouts.Location = new System.Drawing.Point(94, 408);
            this.btnlogouts.Name = "btnlogouts";
            this.btnlogouts.Size = new System.Drawing.Size(133, 67);
            this.btnlogouts.TabIndex = 5;
            this.btnlogouts.Text = "LOG OUTS";
            this.btnlogouts.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 920);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogs);
            this.Controls.Add(this.btnlogouts);
            this.Controls.Add(this.btninactivestudents);
            this.Controls.Add(this.btnactivestudents);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbldashboard);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbldate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btninactivestudents;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnactivestudents;
        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnlogouts;
        private System.Windows.Forms.Button button1;
    }
}