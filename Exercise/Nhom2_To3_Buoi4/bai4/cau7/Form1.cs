using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] arr;
        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            this.txtKetQua.Clear();
            this.txtNhap.Text = ThaoTacMang.chuanHoaChuoi(this.txtNhap.Text);
            arr = txtNhap.Text.Split(' ');    
            foreach (var i in arr)
            {
                txtKetQua.Text += $"{i} ";
            }
            this.txtNhap.Clear();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            this.txtNhap.Clear();
            this.txtKetQua.Clear();
            this.txtNhap.Focus();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if(this.txtKetQua.Text == "")
                MessageBox.Show("Thay bam xuat dum em cai nha thay. Cam on thay!!!", "Gui thay kinh yeu");
            int tong, tongChan, tongLe;
            tong = ThaoTacMang.tong(arr);
            tongChan = ThaoTacMang.tongChan(arr);
            tongLe = ThaoTacMang.tongLe(arr);

            this.txtTongMang.Text = tong.ToString();
            this.txtTongChan.Text = tongChan.ToString();
            this.txtTongLe.Text = tongLe.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.txtKetQua.Text == "")
                MessageBox.Show("Thay bam xuat dum em cai nha thay. Cam on thay!!!", "Gui thay kinh yeu");
            int min = ThaoTacMang.timMin(arr);
            int max = ThaoTacMang.timMax(arr);
            this.txtMin.Text = min.ToString();
            this.txtMax.Text = max.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            this.txtKetQua.Clear();
            if (this.radioSapXepTang.Checked)
            {
                ThaoTacMang.sapXepTang(arr);
                foreach (var i in arr)
                {
                    txtKetQua.Text += $"{i} ";
                }
            }
            else if (radioSapXepGiam.Checked)
            {
                ThaoTacMang.sapXepGiam(arr);
                foreach (var i in arr)
                {
                    txtKetQua.Text += $"{i} ";
                }
            }
            else
                MessageBox.Show("Thay check truoc dum em cai", "Yeu thay");
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            this.txtKetQua.Clear();
            if (this.txtSoThayThe.Text == "" || this.txtViTri.Text == "")
                MessageBox.Show("Vui long nhap gia tri", "Thong bao");
            int vt = Int32.Parse(this.txtViTri.Text);
            int gt = Int32.Parse(this.txtSoThayThe.Text);

            ThaoTacMang.thayThe(arr, vt, gt);
            foreach (var i in arr)
            {
                txtKetQua.Text += $"{i} ";
            }
        }
    }
}
