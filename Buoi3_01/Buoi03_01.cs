using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_01
{
    public partial class Buoi03_01 : Form
    {
        public Buoi03_01()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải số");
                }
                txtKetQua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void lblSoB_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải số");
                }
                txtKetQua.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải số");
                }
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtSoA.Text, out a))
                {
                    throw new Exception("Số A không được để trống hoặc phải số");
                }
                if (!double.TryParse(txtSoB.Text, out b))
                {
                    throw new Exception("Số B không được để trống hoặc phải số");
                }
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtKetQua.Text = ex.Message;
            }
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void lblChuongTrinh_Click(object sender, EventArgs e)
        {

        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSoA_Click(object sender, EventArgs e)
        {

        }
    }
}
