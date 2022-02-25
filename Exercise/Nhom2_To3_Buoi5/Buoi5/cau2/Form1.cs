using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không !", "Thông báo", MessageBoxButtons.OK);
            if(exit == DialogResult.OK)
                Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào tên !", "Thông báo");
            }
            else
            {
                if (this.rdblopA.Checked == true)
                {
                    this.lstA.Items.Add(this.txtTen.Text);
                }
                else
                {
                    this.lstB.Items.Add(this.txtTen.Text);
                }
            }
            this.txtTen.Clear();
            this.txtTen.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.lstA.Items.Count > 0)
            {
                this.lstB.Items.Add(this.lstA.SelectedItem);
                this.lstA.Items.Remove(this.lstA.SelectedItem);
            }
            else
            {
                MessageBox.Show("Danh sách rổng !!!", "Thông báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (this.lstB.Items.Count > 0)
            {
                this.lstA.Items.Add(this.lstB.SelectedItem);
                this.lstB.Items.Remove(this.lstB.SelectedItem);
            }
            else
            {
                MessageBox.Show("Danh sách rổng !!!", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (this.lstA.Items.Count > 0)
            {
                this.lstB.Items.Add(this.lstA.Items[0]);
                this.lstA.Items.Remove(this.lstA.Items[0]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while(this.lstB.Items.Count > 0)
            {
                this.lstA.Items.Add(this.lstB.Items[0]);
                this.lstB.Items.Remove(this.lstB.Items[0]);
            }
        }

        private void btntongSV_Click(object sender, EventArgs e)
        {
            int tong, svA, svB;
            svA = this.lstA.Items.Count;
            svB = this.lstB.Items.Count;
            tong = svA + svB;
            MessageBox.Show($"Tổng số sinh viên 2 lớp là: {tong}", "Số sinh viên");
        }
    }
}
