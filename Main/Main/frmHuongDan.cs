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
        private void Giao_Vien_Load(object sender, EventArgs e)
        {
            KhoiTao();
            dgvGiaoVien.DataSource = gv.Show();

            cbMonHoc.DataSource = gv.LayThongTinMonHoc();
            cbMonHoc.DisplayMember = "TenMon";
            cbMonHoc.ValueMember = "MaMon";
            cbMonHoc.SelectedValue = "MaMon";
            chon = 0;
            string sql = "Xoa_HS";
            SqlConnection conn = new SqlConnection(ConnectDB.getconnect());
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHS", MaHS);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTenGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbGTGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgaySinhGV.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtLuong.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbMonHoc.Text = dgvGiaoVien.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

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
