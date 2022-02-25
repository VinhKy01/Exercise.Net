using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_Cau1
{
    
    public partial class Form1 : Form
    {
        string name = "";
        int type = 0;


        public Form1()
        {
            InitializeComponent();
        }


        //load form 
        void Loadform(object formX)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form fh = formX as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(fh);
            this.mainPanel.Tag = fh;
            fh.Show();
        }
        private void drbTron_CheckedChanged(object sender, EventArgs e)
        {
            
            Loadform(new fHinhTron());
            name = "Hình Tròn";
            type = 1;
        }

        private void rdbVuong_CheckedChanged(object sender, EventArgs e)
        {
            Loadform(new fVuong());
            name = "Hình Vuông";
            type = 2;
        }

        private void rdbChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            Loadform(new fChuNhat());
            name = "Hình Chữ Nhật";
            type = 3;
        }

        private void rdbTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            Loadform(new fTamGiac());
            name = "Hình Tam Giác";
            type = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fKetQua fkq = new fKetQua(name, type, mainPanel.Tag);
            fkq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKetQua fkq = new fKetQua(name, type, mainPanel.Tag);
            fkq.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
