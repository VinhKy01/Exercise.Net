using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string holot = txtHolot.Text;
            string ten = txtTen.Text;

            string hoten = ho +" "+ holot+" " + ten;

            addnode(hoten);
        }

        void addnode(string ten)
        {
            if (!string.IsNullOrEmpty(ten))
            {

                foreach(TreeNode value in treeViewHoTen.Nodes)
                    if (string.Compare(value.Text.ToUpper(), txtTen.Text[0].ToString().ToUpper()) == 0)
                    {
                        value.Nodes.Add(ten);
                        value.Expand();
                        txtHo.Clear();
                        txtHolot.Clear();
                        txtTen.Clear();
                        txtHo.Focus();
                        return;
                    }
            }
            else
                MessageBox.Show("Tên không được để trống");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
