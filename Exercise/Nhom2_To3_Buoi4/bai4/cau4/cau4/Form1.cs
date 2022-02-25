using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            reset();
            this.grbNhap.Visible = true;
            if (rdbTron.Checked)
            {
                this.grbNhap.Text = "Hinh tron";
                this.lb1.Text = "Ban kinh:";
                this.lb1.Location = new System.Drawing.Point(35, 40);
                this.lb1.Visible = true;
                this.txt1.Location = new System.Drawing.Point(135, 35);
                this.txt1.Visible = true;

                this.lbChuVi.Location = new System.Drawing.Point(35, 80);
                this.txtChuVi.Location = new System.Drawing.Point(135, 75);
                this.lbDienTich.Location = new System.Drawing.Point(35, 120);
                this.txtDienTich.Location = new System.Drawing.Point(135, 115);
                this.grbNhap.Size = new System.Drawing.Size(335, 175);
            }
            else if (rdbTamGiac.Checked)
            {
                this.grbNhap.Text = "Tam giac";
                this.lb1.Text = "Canh 1:";
                this.lb1.Visible = true;
                this.lb2.Text = "Canh 2:";
                this.lb2.Visible = true;
                this.lb3.Text = "Canh 3:";
                this.lb3.Visible = true;

                this.txt1.Visible = true;
                this.txt2.Visible = true;
                this.txt3.Visible = true;

                this.lbChuVi.Location = new System.Drawing.Point(35, 160);
                this.txtChuVi.Location = new System.Drawing.Point(135, 155);
                this.lbDienTich.Location = new System.Drawing.Point(35, 200);
                this.txtDienTich.Location = new System.Drawing.Point(135, 195);
                this.grbNhap.Size = new System.Drawing.Size(335, 255);
            }
            else if (rdbVuong.Checked)
            {
                this.grbNhap.Text = "Hinh vuong";
                this.lb1.Text = "Canh: ";
                this.lb1.Visible = true;
                this.txt1.Visible = true;

                this.lbChuVi.Location = new System.Drawing.Point(35, 80);
                this.txtChuVi.Location = new System.Drawing.Point(135, 75);
                this.lbDienTich.Location = new System.Drawing.Point(35, 120);
                this.txtDienTich.Location = new System.Drawing.Point(135, 115);
                this.grbNhap.Size = new System.Drawing.Size(335, 175);
            }
            else if (rdbChuNhat.Checked)
            {
                this.grbNhap.Text = "Hinh chu nhat";
                this.lb1.Text = "Chieu dai: ";
                this.lb1.Visible = true;
                this.txt1.Visible = true;
                this.lb2.Text = "Chieu rong: ";
                this.lb2.Visible = true;
                this.txt2.Visible = true;

                this.lbChuVi.Location = new System.Drawing.Point(35, 120);
                this.txtChuVi.Location = new System.Drawing.Point(135, 115);
                this.lbDienTich.Location = new System.Drawing.Point(35, 160);
                this.txtDienTich.Location = new System.Drawing.Point(135, 155);
                this.grbNhap.Size = new System.Drawing.Size(335, 215);
            }
        }

        void reset()
        {
            this.lb1.Visible = false;
            this.lb2.Visible = false;
            this.lb3.Visible = false;
            this.txt1.Visible = false;
            this.txt2.Visible = false;
            this.txt3.Visible = false;
            this.txt1.Clear();
            this.txt2.Clear();
            this.txt3.Clear();
            this.txtChuVi.Clear();
            this.txtDienTich.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.grbNhap.Visible = false;
            reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            float a = float.Parse(this.txt1.Text);
            if (rdbTron.Checked)
            {
                this.txtChuVi.Text = (2 * Math.PI * a).ToString();
                this.txtDienTich.Text = (Math.PI * a * a).ToString();
            }
            
            else if (rdbVuong.Checked)
            {
                this.txtChuVi.Text = (4*a).ToString();
                this.txtDienTich.Text = (a * a).ToString();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            float a = float.Parse(this.txt1.Text);
            if (this.txt2.Text != "")
            {
                float b = float.Parse(this.txt2.Text);
                this.txtChuVi.Text = (2 * a + 2 * b).ToString();
                this.txtDienTich.Text = (a * b).ToString();
            }
            else
                MessageBox.Show("Vui long nhap du thong tin", "Thong bao");
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (this.txt1.Text != "" || this.txt2.Text != "" || this.txt3.Text != "")
            {
                float a = float.Parse(this.txt1.Text);
                float b = float.Parse(this.txt2.Text);
                float c = float.Parse(this.txt3.Text);
                this.txtChuVi.Text = (a + b + c).ToString();
                float p = (a + b + c) / 2;
                this.txtDienTich.Text = Math.Sqrt(p * (p - a) * (p - b) * (p - c)).ToString();
            }
            else
                MessageBox.Show("Vui long nhap du thong tin", "Thong bao");
        }
    }
}
