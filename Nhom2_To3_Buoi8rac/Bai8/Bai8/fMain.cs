using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rdbHinhVuong.Checked == true)
            {
                if (txtCanh.Equals(""))
                {
                    MessageBox.Show("Ban phai nhap vao gi do !!!", "Thong bao");
                    txtCanh.Focus();
                }
                else
                {
                    float canh = float.Parse(txtCanh.Text);
                    fSquare f = new fSquare();
                    Class.HinhVuong hv = new Class.HinhVuong(canh);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    txtCanh.Clear();
                    txtDai.Clear();
                    txtRong.Clear();
                    txtBanKinh.Clear();
                }
            }
            else if (rdbHinhChuNhat.Checked == true)
            {
                if (txtDai.Equals("") || txtRong.Equals(""))
                {
                    MessageBox.Show("Ban phai nhap vao gi do !!!", "Thong bao");
                    txtDai.Focus();
                }
                else
                {
                    fRectangular f = new fRectangular();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    txtCanh.Clear();
                    txtDai.Clear();
                    txtRong.Clear();
                    txtBanKinh.Clear();
                }
            }
            else if (rdbHinhTron.Checked == true)
            {
                if (txtBanKinh.Equals(""))
                {
                    MessageBox.Show("Ban phai nhap vao gi do !!!", "Thong bao");
                    txtDai.Focus();
                }
                else
                {
                    fCircle f = new fCircle();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    txtCanh.Clear();
                    txtDai.Clear();
                    txtRong.Clear();
                    txtBanKinh.Clear();
                }
            }
        }

        private void HinhChuNhat(float canh)
        {
            throw new NotImplementedException();
        }

        private void rdbHinhVuong_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBanKinh.Clear();
            txtCanh.Focus();
        }

        private void rdbHinhChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtCanh.Enabled = false;
            txtBanKinh.Enabled = false;
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBanKinh.Clear();
            txtDai.Focus();
        }

        private void rdbHinhTron_CheckedChanged(object sender, EventArgs e)
        {
            txtBanKinh.Enabled = true;
            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBanKinh.Clear();
            txtBanKinh.Focus();
        }
    }
}
