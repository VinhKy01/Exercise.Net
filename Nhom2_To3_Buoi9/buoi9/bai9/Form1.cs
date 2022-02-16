using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int so = Int32.Parse(txtN.Text);
            Form2 f2 = new Form2(so);
            this.Hide();
            f2.ShowDialog();
            this.Show();
            btnLamLai.Enabled = true;
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            int so = Int32.Parse(txtN.Text);
            fArray f3 = new fArray(so);
            this.Hide();
            f3.ShowDialog();
            this.Show();
            btnLamLai.Enabled = true;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thoat == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void kiểmTraSốHoànHảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int so = Int32.Parse(txtN.Text);
            Form2 f2 = new Form2(so);
            this.Hide();
            f2.ShowDialog();
            this.Show();
            btnLamLai.Enabled = true;
        }

        private void tạoMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int so = Int32.Parse(txtN.Text);
            fArray array = new fArray(so);
            this.Hide();
            array.ShowDialog();
            this.Show();
            btnLamLai.Enabled = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thoat == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
