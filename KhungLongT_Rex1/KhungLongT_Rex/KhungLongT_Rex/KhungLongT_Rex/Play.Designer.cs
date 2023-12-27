namespace KhungLongT_Rex
{
    partial class KhungLong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhungLong));
            this.timePoint = new System.Windows.Forms.Timer(this.components);
            this.txtdiem = new System.Windows.Forms.Label();
            this.ptbcay1 = new System.Windows.Forms.PictureBox();
            this.ptbcay2 = new System.Windows.Forms.PictureBox();
            this.ptbduong = new System.Windows.Forms.PictureBox();
            this.ptxphaoHoa = new System.Windows.Forms.PictureBox();
            this.KLong = new System.Windows.Forms.PictureBox();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.lbDemSo = new System.Windows.Forms.Label();
            this.txtdiemCao = new System.Windows.Forms.Label();
            this.ptbGameOV = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbduong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxphaoHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGameOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timePoint
            // 
            this.timePoint.Interval = 40;
            this.timePoint.Tick += new System.EventHandler(this.gameEvent);
            // 
            // txtdiem
            // 
            this.txtdiem.AutoSize = true;
            this.txtdiem.BackColor = System.Drawing.Color.Transparent;
            this.txtdiem.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.txtdiem.Location = new System.Drawing.Point(46, 27);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(0, 29);
            this.txtdiem.TabIndex = 4;
            // 
            // ptbcay1
            // 
            this.ptbcay1.BackColor = System.Drawing.Color.Transparent;
            this.ptbcay1.Image = ((System.Drawing.Image)(resources.GetObject("ptbcay1.Image")));
            this.ptbcay1.Location = new System.Drawing.Point(448, 408);
            this.ptbcay1.Name = "ptbcay1";
            this.ptbcay1.Size = new System.Drawing.Size(38, 57);
            this.ptbcay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbcay1.TabIndex = 17;
            this.ptbcay1.TabStop = false;
            this.ptbcay1.Tag = "cay";
            // 
            // ptbcay2
            // 
            this.ptbcay2.BackColor = System.Drawing.Color.Transparent;
            this.ptbcay2.Image = ((System.Drawing.Image)(resources.GetObject("ptbcay2.Image")));
            this.ptbcay2.Location = new System.Drawing.Point(729, 408);
            this.ptbcay2.Name = "ptbcay2";
            this.ptbcay2.Size = new System.Drawing.Size(54, 57);
            this.ptbcay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbcay2.TabIndex = 16;
            this.ptbcay2.TabStop = false;
            this.ptbcay2.Tag = "cay";
            // 
            // ptbduong
            // 
            this.ptbduong.BackColor = System.Drawing.Color.Transparent;
            this.ptbduong.Location = new System.Drawing.Point(-8, 462);
            this.ptbduong.Name = "ptbduong";
            this.ptbduong.Size = new System.Drawing.Size(1018, 47);
            this.ptbduong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbduong.TabIndex = 14;
            this.ptbduong.TabStop = false;
            // 
            // ptxphaoHoa
            // 
            this.ptxphaoHoa.BackColor = System.Drawing.Color.Transparent;
            this.ptxphaoHoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptxphaoHoa.BackgroundImage")));
            this.ptxphaoHoa.Image = ((System.Drawing.Image)(resources.GetObject("ptxphaoHoa.Image")));
            this.ptxphaoHoa.Location = new System.Drawing.Point(256, 148);
            this.ptxphaoHoa.Name = "ptxphaoHoa";
            this.ptxphaoHoa.Size = new System.Drawing.Size(567, 276);
            this.ptxphaoHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxphaoHoa.TabIndex = 12;
            this.ptxphaoHoa.TabStop = false;
            // 
            // KLong
            // 
            this.KLong.BackColor = System.Drawing.Color.Transparent;
            this.KLong.Image = ((System.Drawing.Image)(resources.GetObject("KLong.Image")));
            this.KLong.Location = new System.Drawing.Point(135, 410);
            this.KLong.Name = "KLong";
            this.KLong.Size = new System.Drawing.Size(42, 55);
            this.KLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KLong.TabIndex = 18;
            this.KLong.TabStop = false;
            this.KLong.Tag = "";
            // 
            // timerRun
            // 
            this.timerRun.Interval = 1000;
            this.timerRun.Tick += new System.EventHandler(this.timerRun_Tick);
            // 
            // lbDemSo
            // 
            this.lbDemSo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDemSo.AutoSize = true;
            this.lbDemSo.BackColor = System.Drawing.Color.Transparent;
            this.lbDemSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDemSo.ForeColor = System.Drawing.Color.Red;
            this.lbDemSo.Location = new System.Drawing.Point(490, 164);
            this.lbDemSo.Name = "lbDemSo";
            this.lbDemSo.Size = new System.Drawing.Size(63, 69);
            this.lbDemSo.TabIndex = 19;
            this.lbDemSo.Text = "3";
            this.lbDemSo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdiemCao
            // 
            this.txtdiemCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiemCao.AutoSize = true;
            this.txtdiemCao.BackColor = System.Drawing.Color.DarkOrange;
            this.txtdiemCao.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemCao.ForeColor = System.Drawing.Color.Maroon;
            this.txtdiemCao.Location = new System.Drawing.Point(496, 37);
            this.txtdiemCao.Name = "txtdiemCao";
            this.txtdiemCao.Size = new System.Drawing.Size(0, 31);
            this.txtdiemCao.TabIndex = 21;
            this.txtdiemCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbGameOV
            // 
            this.ptbGameOV.BackColor = System.Drawing.Color.Transparent;
            this.ptbGameOV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbGameOV.Image = ((System.Drawing.Image)(resources.GetObject("ptbGameOV.Image")));
            this.ptbGameOV.Location = new System.Drawing.Point(288, 164);
            this.ptbGameOV.Name = "ptbGameOV";
            this.ptbGameOV.Size = new System.Drawing.Size(478, 214);
            this.ptbGameOV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGameOV.TabIndex = 22;
            this.ptbGameOV.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // KhungLong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 588);
            this.Controls.Add(this.KLong);
            this.Controls.Add(this.ptbGameOV);
            this.Controls.Add(this.txtdiemCao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbDemSo);
            this.Controls.Add(this.ptbcay1);
            this.Controls.Add(this.ptbcay2);
            this.Controls.Add(this.ptbduong);
            this.Controls.Add(this.ptxphaoHoa);
            this.Controls.Add(this.txtdiem);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 635);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1025, 635);
            this.Name = "KhungLong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khủng Long";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.KhungLong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbcay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbduong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxphaoHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGameOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timePoint;
        private System.Windows.Forms.Label txtdiem;
        private System.Windows.Forms.PictureBox ptxphaoHoa;
        private System.Windows.Forms.PictureBox ptbduong;
        private System.Windows.Forms.PictureBox ptbcay2;
        private System.Windows.Forms.PictureBox ptbcay1;
        private System.Windows.Forms.PictureBox KLong;
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.Label lbDemSo;
        private System.Windows.Forms.Label txtdiemCao;
        private System.Windows.Forms.PictureBox ptbGameOV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

