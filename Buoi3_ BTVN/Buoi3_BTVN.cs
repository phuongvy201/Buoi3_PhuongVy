using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3__BTVN
{
    public partial class Buoi3_BTVN : Form
    {
        public Buoi3_BTVN()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSach.Text.Length < 6)
                {
                    throw new Exception("Mã sách không hợp lệ");
                }
                if (txtTenSach.Text.Length == 0)
                {
                    throw new Exception("Tên sách không được để trống");
                }
                if (txtGia.Text.Length == 0)
                {
                    throw new Exception("Giá tiền không hợp lệ");
                }
                if (txtSoLuong.Text.Length == 0)
                {
                    throw new Exception("Số lượng không hợp lệ");
                }
                int stt = 1;
                string masach = txtMaSach.Text;
                string tensach = txtTenSach.Text;
                string gia = txtGia.Text;
                string soluong = txtSoLuong.Text;
                txtDanhSach.Text += stt + ". Mã sách: " + masach + "Tên sách: " + tensach + " Giá: " + gia + "Số lượng: " + soluong + "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
