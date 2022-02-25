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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (soHoanHao.kiemTraSHH(Int32.Parse(txtInput.Text)))
            {
                txtOuput.Text = txtInput.Text + " la so hoan hao";
            }
            else
            {
                txtOuput.Text = txtInput.Text + " khong phai so hoan hao";
            }

            //txtShow
            txtShow.Text = soHoanHao.showSHH(Int32.Parse(txtInput.Text));
        }

        private void btnRemake_Click(object sender, EventArgs e)
        {
            this.txtInput.Clear();
            this.txtOuput.Clear();
            this.txtShow.Clear();
            this.txtInput.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
