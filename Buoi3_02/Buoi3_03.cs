using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_02
{
    public partial class Form1 : Form
    {
        int stt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không hợp lệ");
                }
                if (txtHoTen.Text.Length == 0)
                {
                    throw new Exception("Bạn chưa nhập họ tên");
                }
                if (txtNgaySinh.Text.Length != 10)
                {
                    throw new Exception("Ngày sinh không hợp lệ");
                }
                string hoten = txtHoTen.Text;
                string masv = txtMaSV.Text;

                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = (rbnNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (cbxDuLich.Checked)
                {
                    sothich += "Du lịch";
                }
                if (cbxMuaSam.Checked)
                {
                    sothich += "Mua sắm";
                }
                if (cbxTheThao.Checked)
                {
                    sothich += "Thể thao";
                }
                if (sothich != null)
                {
                    sothich += " Sở thích: " + sothich;
                }
                txtDanhSach.Text += stt + ". Họ tên: " + "Ngày sinh: " + ngaysinh + " Giới tính: " + gioitinh + sothich + "\r\n";
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không hợp lệ");
                }
                if (txtHoTen.Text.Length == 0)
                {
                    throw new Exception("Bạn chưa nhập họ tên");
                }
                if (txtNgaySinh.Text.Length != 10)
                {
                    throw new Exception("Ngày sinh không hợp lệ");
                }
                string hoten = txtHoTen.Text;
                string masv = txtMaSV.Text;

                string ngaysinh = txtNgaySinh.Text;
                string gioitinh = (rbnNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (cbxDuLich.Checked)
                {
                    sothich += "Du lịch";
                }
                if (cbxMuaSam.Checked)
                {
                    sothich += "Mua sắm";
                }
                if (cbxTheThao.Checked)
                {
                    sothich += "Thể thao";
                }
                if (sothich != null)
                {
                    sothich += " Sở thích: " + sothich;
                }
                txtDanhSach.Text += stt + ". Họ tên: " + "Ngày sinh: " + ngaysinh + " Giới tính: " + gioitinh + sothich + "\r\n";
                stt++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbxMuaSam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxDuLich_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbxTheThao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbnNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblSoThich_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblMaSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void lblThongTin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_2(object sender, EventArgs e)
        {
            txtDanhSach.Text = "";
        }

        private void btnThoat_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
