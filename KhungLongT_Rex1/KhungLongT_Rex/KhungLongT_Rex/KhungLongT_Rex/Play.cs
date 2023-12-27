using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KhungLongT_Rex
{
    public partial class KhungLong : Form
    {
        bool nhay = false;//nhảy or không
        int tdnhay = 5;// tốc độ nhảy
        int soluong = 12;//Lực nhảy
        int diem = 0;//Điểm bắt đầu = 0
        int tdcay = 8;//giá trị cho chướng ngại vật
        Random rd = new Random();//thêm ngẫu nhiên lớp mới(cây)
        private string diemcao;
        

        public KhungLong()
        {
            InitializeComponent();
            resetGame();//thiết lập chức năng để chạy khi trò chơi bắt đầu
          
           
        }

        private void gameEvent(object sender, EventArgs e)
        {

            //Liên kết tốc độ nhảy với KL với vị trí
            KLong.Top += tdnhay;
            txtdiem.Text = "" + diem;//Điểm
            Random rnd = new Random();
            if (diem > 1 && diem % 100 == 0)
            {
                txtdiem.ForeColor = Color.FromArgb(rd.Next(0, 255), rd.Next(255, 255), rd.Next(255, 255));
            }
            if (nhay && soluong < 0)
            {//sluong < 0 thì
                nhay = false;
            }
            if (nhay)
            {
                tdnhay = -10;//độ cao khi nhảy
                soluong -= 1;
            }
            else
            {
                tdnhay = 9;//độ chậm khi rớt
            }

            foreach (Control x in this.Controls)
            {//X: hình, là thẻ tag của cây
                diemcao =diemcao + " ";
               
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "cay")//kiểu chuỗi để lưu các giá trị của KL
                {
                 
                    x.Left -= tdcay;//di chuyển cây qua bên trái
                    if (x.Left + x.Width < -120)
                    {//cây bị bắt, tạo cây mới phía bên phải
                        //Đi qua 1 cây, thêm cây mới và cộng thêm điểm
                        x.Left = this.ClientSize.Width + rd.Next(300, 1000);
                        //diem++;
                      
                    }
                    if (KLong.Bounds.IntersectsWith(x.Bounds))//Giao:va chạm cây
                    {
                        timePoint.Stop();
                        KLong.Image = Properties.Resources.dead;//hình khi KL chết
                        txtdiem.Text += " Nhấn R để chơi lại";
                        ptbGameOV.Show();
                        int diemcao2 = int.Parse(diemcao);
                        if (diem > diemcao2)
                        {
                            ptxphaoHoa.Show();
                            ptbGameOV.Hide();
                            ghifile();
                        }
                        
                    }
                }
            }
            if (KLong.Top >= 380 && !nhay)
            {
                soluong = 12;
                KLong.Top = ptbduong.Top - KLong.Height;
                tdnhay = 0;
            }
            if (timePoint.Interval == 40 || timePoint.Interval == 37 || timePoint.Interval == 36 || timePoint.Interval == 35 || timePoint.Interval == 33 || timePoint.Interval == 30)
            {
                diem += 1;
            }
            if (timePoint.Interval == 28 || timePoint.Interval == 25 || timePoint.Interval == 22)
            {
                diem += 2;
            }
            if (timePoint.Interval == 20 || timePoint.Interval == 18)
            {
                diem += 3;
            }
            if (diem >= 50)
            {//>= 2 điểm: thay đổi kích thước KL
                tdcay = 9;
                KLong.Height = 55;
                KLong.Width = 42;
                timePoint.Interval = 37;
            }
            if (diem >= 100)
            {//>= 2 điểm: thay đổi kích thước KL
                tdcay = 10;
                KLong.Height = 55;
                KLong.Width = 42;
                timePoint.Interval = 36;
            }
            if (diem >= 200)
            {//>= 2 điểm: thay đổi kích thước KL
                tdcay = 10;
                KLong.Height = 55;
                KLong.Width = 42;
                timePoint.Interval = 35;
            }
            if (diem >= 300)
            {//>= 2 điểm: thay đổi kích thước KL
                tdcay = 10;
                KLong.Height = 55;
                KLong.Width = 42;
                timePoint.Interval = 33;
            }
            if (diem >= 500)
            {//>= 2 điểm: thay đổi kích thước KL
                tdcay = 13;
                KLong.Height = 55;
                KLong.Width = 42;
                timePoint.Interval = 30;
            }
            if (diem >= 800)
            {//>= 2 điểm: thay đổi kích thước KL
                tdcay = 15;
                KLong.Height = 55;
                KLong.Width = 42;
                timePoint.Interval = 28;
            }
            if (diem >= 1000)
            {//Tương tự
                tdcay = 17;
                KLong.Height = 60;
                KLong.Width = 43;
                timePoint.Interval = 25;
            }
            if (diem >= 2000)
            {
                KLong.Height = 61;
                KLong.Width = 43;
                timePoint.Interval = 22;
                tdcay = 20;
            }
            if (diem >= 5000)
            {
                KLong.Height = 63;
                KLong.Width = 44;
                timePoint.Interval = 20;
                tdcay = 20;
            }
            if (diem >= 10000)
            {
                KLong.Height = 75;
                KLong.Width = 52;
                timePoint.Interval = 18;
                tdcay = 25;
            }
        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //
            if (e.KeyCode == Keys.Space && !nhay)
            {
                nhay = true;
            }
            if (e.KeyCode == Keys.Up && !nhay)
            {
                nhay = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R /*|| /*e.KeyCode == Keys.Space*/)
            {
                KLong.Image = Properties.Resources.running;
                timerRun.Start();
                timePoint.Start();
                resetGame();
                
            }
            if (e.KeyCode == Keys.F5)
            {
                resetGame();
            }
            // nếu key là ESC thoát game
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            //Nếu nhảy là đúng
            if (nhay)
            {
                nhay = false;
            }
        }

        public void resetGame()
        {
            loaddiem();
            txtdiemCao.Text = "" + diemcao;     
            ptbGameOV.Hide();
            ptxphaoHoa.Hide();
            timerRun.Start();
            soluong = 12;
            KLong.Top = ptbduong.Top - KLong.Height;
            tdnhay = 0;
            nhay = false;
            diem = 0;
            tdcay = 10;
            txtdiem.Text = "" + diem;
            KLong.Image = Properties.Resources.running;
            // 1 Cây....
            if (diem <= 500)
            {
                ptbcay2.Enabled = false;
            }
            if (diem >= 800)
            {
                ptbcay2.Enabled = true;
            }
            //Vòng lặp
            foreach (Control x in this.Controls){
                if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "cay")
                {//X: hình, là thẻ tag của cây
                    int vitri = rd.Next(600,1000);
                    //Thay đổi vị trí cây
                    x.Left = 680 + (x.Left + vitri + x.Width * 8);
                }
            }
            

        }
       
       
        //đọc dữ liệu lên file text
        public void ghifile() {
            String dulieunhap = Console.ReadLine();
            String file = "D:/KhungLongT/KhungLongT_Rex/diemcao.txt";// đường dẫn của file muốn tạo
            FileStream fs = new FileStream(file, FileMode.Open);        
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
            sw.WriteLine("" + diem);
            sw.WriteLine(dulieunhap);
            // Ghi và đóng file
            sw.Flush();
            fs.Close();
        }
        public void loaddiem()
        {
            //Ghi điểm cao
            String file = "D:/KhungLongT/KhungLongT_Rex1/KhungLongT_Rex/KhungLongT_Rex/diemcao.txt";// đường dẫn của file muốn tạo
            if (File.Exists(file) == false)
            {
                FileStream fs = new FileStream(file, FileMode.Create);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                diemcao = sr.ReadLine();//ReadLine(): đọc 1 dòng đầu, ReadToEnd(): đọc hết
                if (diemcao == null)
                {
                    diemcao = "0";
                }
                Console.WriteLine(diemcao);
                sr.Close();
                Console.ReadLine();
            }
            else
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                diemcao = sr.ReadLine();//ReadLine(): đọc 1 dòng đầu, ReadToEnd(): đọc hết
                if (diemcao == null)
                {
                    diemcao = "0";
                }
                Console.WriteLine(diemcao);
                sr.Close();
                Console.ReadLine();
            }
           
        }
        private void doimau()
        {
            Random rd = new Random();
            lbDemSo.ForeColor = Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
        }
        int giay = 3;

        private void KhungLong_Load(object sender, EventArgs e)
        {

        }
        private void timerRun_Tick(object sender, EventArgs e)
        {
            giay--;
            lbDemSo.Text = "" + giay;
            lbDemSo.BackColor = Color.Transparent;
            if (giay == 2)
            {
                lbDemSo.Text = "" + giay;
                lbDemSo.ForeColor = Color.Yellow;
                lbDemSo.BackColor = Color.Transparent;
            }
            if (giay == 1)
            {
                lbDemSo.Text = "" + giay;
                lbDemSo.ForeColor = Color.Blue;
                lbDemSo.BackColor = Color.Transparent;
            }
            if (giay == 0)
            {
               
                lbDemSo.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbDemSo.Size = new System.Drawing.Size(612, 71);
                lbDemSo.BackColor = Color.Transparent;
                doimau();
                lbDemSo.Location = new Point(420, 150);
                lbDemSo.Text = "START";
            }
            if (giay == -1)
            {
                lbDemSo.BackColor = Color.Transparent;
                timerRun.Stop();
                lbDemSo.Hide();
                timePoint.Start();
                KLong.Image = Properties.Resources.running;
            }
        }
    }
    
}
