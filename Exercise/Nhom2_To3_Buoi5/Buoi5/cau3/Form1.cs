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

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.txtmsSV.Text == "" || this.txtTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ họ tên và mã sinh viên !", "Thông báo");
            }
            else
            {
                string gioitinh;
                ListViewItem item = new ListViewItem(this.txtmsSV.Text);
                item.SubItems.Add(this.txtTen.Text);
                item.SubItems.Add(this.txtngaySinh.Value.ToString());
                if (this.rdbNam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nữ";
                item.SubItems.Add(gioitinh);
                item.SubItems.Add(this.txtsdt.Text);
                item.SubItems.Add(this.txtqueQuan.Text);
                listViewthongTin.Items.Add(item);
            }
            this.txtmsSV.Clear();
            this.txtTen.Clear();
            this.txtsdt.Clear();
            this.txtmsSV.Focus();
        }

        private void listViewthongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.listViewthongTin.SelectedItems.Count > 0)
            {
                this.txtmsSV.Text = listViewthongTin.SelectedItems[0].SubItems[0].Text;
                this.txtTen.Text = listViewthongTin.SelectedItems[0].SubItems[1].Text;
                this.txtngaySinh.Text = listViewthongTin.SelectedItems[0].SubItems[2].Text;
                if (this.listViewthongTin.SelectedItems[0].SubItems[3].Text == "Nam")
                    this.rdbNam.Checked = true;
                else
                    this.rdbNu.Checked = true;
                this.txtsdt.Text = listViewthongTin.SelectedItems[0].SubItems[4].Text;
                this.txtqueQuan.Text = listViewthongTin.SelectedItems[0].SubItems[5].Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chọn nhiều dòng trong listview;
            listViewthongTin.FullRowSelect = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có chắc muốn xoá !", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (xoa == DialogResult.OK)
            {
                if (this.listViewthongTin.SelectedItems.Count > 0)
                    this.listViewthongTin.Items.Remove(this.listViewthongTin.SelectedItems[0]);
            }
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Bạn có chắc muốn thay đổi !", "Cảnh báo", MessageBoxButtons.OKCancel);
            if(sua == DialogResult.OK)
            {
                if (this.listViewthongTin.SelectedItems.Count > 0)
                {
                    this.listViewthongTin.SelectedItems[0].SubItems[0].Text = this.txtmsSV.Text;
                    this.listViewthongTin.SelectedItems[0].SubItems[1].Text = this.txtTen.Text;
                    this.listViewthongTin.SelectedItems[0].SubItems[2].Text = this.txtngaySinh.Text;
                    if (this.listViewthongTin.SelectedItems[0].SubItems[3].Text == "Nam")
                        this.rdbNam.Checked = true;
                    else
                        this.rdbNu.Checked = true;
                    this.listViewthongTin.SelectedItems[0].SubItems[4].Text = this.txtsdt.Text;
                    this.listViewthongTin.SelectedItems[0].SubItems[5].Text = this.txtqueQuan.Text;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }
    }
}
