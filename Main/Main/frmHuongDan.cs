using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Main
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }
        private void GetFileAll(string tenfile)
        {
            StreamReader text = File.OpenText(tenfile);
            string text1 = text.ReadToEnd();
            txtGioiThieu.Text = s;
        }
private void trViewGioiThieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "gtPhanMem")
            {
                GetFileAll("GioiThieuChung.txt");
                Image img = Image.FromFile(@"truong.jpg");
                pictureBox1.BackgroundImage = img;
            }
            else
                if (e.Node.Name == "gtDangNhap")
                {
                    GetFileAll("PhanDangNhap.txt");
                    Image img = Image.FromFile(@"b2 dang nhap.png");
                    pictureBox1.BackgroundImage = img;
                }
        }
  
        private void Giao_Vien_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvGiaoVien.DataSource = gv.Show();

            cbMonHoc.DataSource = gv.LayThongTinMonHoc();
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
            cbMonHoc.SelectedValue = "MaMon";
            chon = 0;
        }

        private void frmHuongDan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 huongdan = new Form1();
            huongdan.Show();
        }

      
    }
}
