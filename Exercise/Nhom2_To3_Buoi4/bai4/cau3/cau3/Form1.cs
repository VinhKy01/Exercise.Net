using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(Int32.Parse(this.txtTu1.Text), Int32.Parse(this.txtMau1.Text));
            PhanSo ps2 = new PhanSo(Int32.Parse(this.txtTu2.Text), Int32.Parse(this.txtMau2.Text));
            PhanSo kq = new PhanSo();
            kq = PhanSo.Tong(ps1, ps2);

            this.txtTuKQ.Text = kq.Tu.ToString();
            this.txtMauKQ.Text = kq.Mau.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTu1.Clear();
            this.txtMau1.Clear();
            this.txtTu2.Clear();
            this.txtMau2.Clear();
            this.txtTuKQ.Clear();
            this.txtMauKQ.Clear();
            txtTu1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(Int32.Parse(this.txtTu1.Text), Int32.Parse(this.txtMau1.Text));
            PhanSo ps2 = new PhanSo(Int32.Parse(this.txtTu2.Text), Int32.Parse(this.txtMau2.Text));
            PhanSo kq = new PhanSo();
            kq = PhanSo.Hieu(ps1, ps2);

            this.txtTuKQ.Text = kq.Tu.ToString();
            this.txtMauKQ.Text = kq.Mau.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(Int32.Parse(this.txtTu1.Text), Int32.Parse(this.txtMau1.Text));
            PhanSo ps2 = new PhanSo(Int32.Parse(this.txtTu2.Text), Int32.Parse(this.txtMau2.Text));
            PhanSo kq = new PhanSo();
            kq = PhanSo.Tich(ps1, ps2);

            this.txtTuKQ.Text = kq.Tu.ToString();
            this.txtMauKQ.Text = kq.Mau.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            PhanSo ps1 = new PhanSo(Int32.Parse(this.txtTu1.Text), Int32.Parse(this.txtMau1.Text));
            PhanSo ps2 = new PhanSo(Int32.Parse(this.txtTu2.Text), Int32.Parse(this.txtMau2.Text));
            PhanSo kq = new PhanSo();
            kq = PhanSo.Thuong(ps1, ps2);

            this.txtTuKQ.Text = kq.Tu.ToString();
            this.txtMauKQ.Text = kq.Mau.ToString();
        }
    }
}
