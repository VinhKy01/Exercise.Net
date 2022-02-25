using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Cach1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void clearTxt()
        {
            txtBanKinh.Clear();
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
        }
        private void rdbTron_CheckedChanged(object sender, EventArgs e)
        {
            txtBanKinh.Enabled = true;
            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            clearTxt();
        }

        private void rdbVuong_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            clearTxt();
        }

        private void rdbChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Enabled = false;
            txtBanKinh.Enabled = false;
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            clearTxt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int canh = 0;
            int dai = 0;
            int rong = 0;
            int bk = 0;
            if (rdbTron.Checked)
            {
                try
                {
                    bk = Convert.ToInt32(txtBanKinh.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap ban kinh hop le", "Thong bao");
                    txtBanKinh.Focus();
                    return;
                }
                fTron f = new fTron(bk);
                f.ShowDialog();
            }
            else if (rdbVuong.Checked)
            {
                try
                {
                    canh = Convert.ToInt32(txtCanh.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap canh hop le", "Thong bao");
                    txtCanh.Focus();
                    return;
                }
                fVuong f = new fVuong(canh);
                f.ShowDialog();
            }
            else
            {
                try
                {
                    dai = Convert.ToInt32(txtDai.Text);
                    rong = Convert.ToInt32(txtRong.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap canh hop le", "Thong bao");
                    txtDai.Focus();
                    return;
                }
                fChuNhat f = new fChuNhat(dai, rong);
                f.ShowDialog();
            }
            clearTxt();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int canh = 0;
            int dai = 0;
            int rong = 0;
            int bk = 0;
            if (rdbTron.Checked)
            {
                try
                {
                    bk = Convert.ToInt32(txtBanKinh.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap ban kinh hop le", "Thong bao");
                    txtBanKinh.Focus();
                    return;
                }
                fTron f = new fTron(bk);
                f.ShowDialog();
            }
            else if (rdbVuong.Checked)
            {
                try
                {
                    canh = Convert.ToInt32(txtCanh.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap canh hop le", "Thong bao");
                    txtCanh.Focus();
                    return;
                }
                fVuong f = new fVuong(canh);
                f.ShowDialog();
            }
            else
            {
                try
                {
                    dai = Convert.ToInt32(txtDai.Text);
                    rong = Convert.ToInt32(txtRong.Text);
                }
                catch
                {
                    MessageBox.Show("Vui long nhap canh hop le", "Thong bao");
                    txtDai.Focus();
                    return;
                }
                fChuNhat f = new fChuNhat(dai, rong);
                f.ShowDialog();
            }
            clearTxt();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
