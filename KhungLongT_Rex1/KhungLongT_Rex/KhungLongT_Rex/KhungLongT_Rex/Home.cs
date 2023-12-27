using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KhungLongT_Rex
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }
        int demnguoc = 3;
        private void timerStart_Tick(object sender, EventArgs e)
        {
            demnguoc--;
            if (demnguoc == 0)
            {
                KhungLong kl = new KhungLong();
                this.Hide();
                kl.Show();
                timerStart.Stop();
            }
        }

        private void ptbStart_Click(object sender, EventArgs e)
        {
            ptbHome.Image = Properties.Resources.loading;
            ptbFacebook.Hide();
            ptbHuongdan.Hide();
            lbYAO.Hide();
            ptbStart.Hide();
            timerStart.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/TruongDaiHocMo/?locale=vi_VN");
        }

        private void ptbHuongdan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Space: Nhảy\n R/F5: Chơi lại\n ESC: Thoát", "Thông báo");
        }
        private void Doimau()
        {
            Random r = new Random();
            lbYAO.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Doimau();
        }
    }
}
