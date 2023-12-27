using System;

namespace KhungLongT_Rex
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.lbYAO = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ptbFacebook = new System.Windows.Forms.PictureBox();
            this.ptbHuongdan = new System.Windows.Forms.PictureBox();
            this.ptbStart = new System.Windows.Forms.PictureBox();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHuongdan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStart
            // 
            this.timerStart.Interval = 1000;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // lbYAO
            // 
            this.lbYAO.AutoSize = true;
            this.lbYAO.BackColor = System.Drawing.Color.Transparent;
            this.lbYAO.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYAO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbYAO.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbYAO.Location = new System.Drawing.Point(291, 70);
            this.lbYAO.Name = "lbYAO";
            this.lbYAO.Size = new System.Drawing.Size(358, 53);
            this.lbYAO.TabIndex = 5;
            this.lbYAO.Text = "T-Rex Running";
            // 
            // ptbFacebook
            // 
            this.ptbFacebook.BackColor = System.Drawing.Color.Transparent;
            this.ptbFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFacebook.Image = ((System.Drawing.Image)(resources.GetObject("ptbFacebook.Image")));
            this.ptbFacebook.Location = new System.Drawing.Point(159, 19);
            this.ptbFacebook.Name = "ptbFacebook";
            this.ptbFacebook.Size = new System.Drawing.Size(44, 42);
            this.ptbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFacebook.TabIndex = 22;
            this.ptbFacebook.TabStop = false;
            this.ptbFacebook.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbHuongdan
            // 
            this.ptbHuongdan.BackColor = System.Drawing.Color.Transparent;
            this.ptbHuongdan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbHuongdan.Image = ((System.Drawing.Image)(resources.GetObject("ptbHuongdan.Image")));
            this.ptbHuongdan.Location = new System.Drawing.Point(242, 19);
            this.ptbHuongdan.Name = "ptbHuongdan";
            this.ptbHuongdan.Size = new System.Drawing.Size(47, 42);
            this.ptbHuongdan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHuongdan.TabIndex = 21;
            this.ptbHuongdan.TabStop = false;
            this.ptbHuongdan.Click += new System.EventHandler(this.ptbHuongdan_Click);
            // 
            // ptbStart
            // 
            this.ptbStart.BackColor = System.Drawing.Color.Transparent;
            this.ptbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbStart.Image = global::KhungLongT_Rex.Properties.Resources._110_1109463_start_button_pixel_speech_bubble_kpop_png;
            this.ptbStart.Location = new System.Drawing.Point(658, 407);
            this.ptbStart.Name = "ptbStart";
            this.ptbStart.Size = new System.Drawing.Size(221, 103);
            this.ptbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStart.TabIndex = 4;
            this.ptbStart.TabStop = false;
            this.ptbStart.Click += new System.EventHandler(this.ptbStart_Click);
            // 
            // ptbHome
            // 
            this.ptbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ptbHome.BackgroundImage = global::KhungLongT_Rex.Properties.Resources.ptbHome_BackgroundImage;
            this.ptbHome.Image = ((System.Drawing.Image)(resources.GetObject("ptbHome.Image")));
            this.ptbHome.Location = new System.Drawing.Point(0, -1);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(928, 623);
            this.ptbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHome.TabIndex = 3;
            this.ptbHome.TabStop = false;
            this.ptbHome.Click += new System.EventHandler(this.ptbHome_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 610);
            this.Controls.Add(this.ptbFacebook);
            this.Controls.Add(this.ptbHuongdan);
            this.Controls.Add(this.lbYAO);
            this.Controls.Add(this.ptbStart);
            this.Controls.Add(this.ptbHome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(938, 657);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(938, 657);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHuongdan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ptbHome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.PictureBox ptbHome;
        private System.Windows.Forms.PictureBox ptbStart;
        private System.Windows.Forms.Label lbYAO;
        private System.Windows.Forms.PictureBox ptbHuongdan;
        private System.Windows.Forms.PictureBox ptbFacebook;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}