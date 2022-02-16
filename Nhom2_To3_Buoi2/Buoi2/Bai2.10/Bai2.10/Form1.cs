using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonchuvi_Click(object sender, EventArgs e)
        {
            int dai, rong, chuvi;
            dai = Int32.Parse(text1.Text);
            rong = Int32.Parse(text2.Text);
            chuvi = (dai + rong) * 2;
            textkq.Text = chuvi.ToString();
        }

        private void buttondientich_Click(object sender, EventArgs e)
        {
            int dai, rong, dientich;
            dai = Int32.Parse(text1.Text);
            rong = Int32.Parse(text2.Text);
            dientich = dai * rong;
            textkq.Text = dientich.ToString();
        }

        private void buttonduongcheo_Click(object sender, EventArgs e)
        {
            int dai, rong, duongcheo;
            dai = Int32.Parse(text1.Text);
            rong = Int32.Parse(text2.Text);
            duongcheo = (int)Math.Sqrt(dai * dai + rong * rong);
            textkq.Text = duongcheo.ToString();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông Báo", MessageBoxButtons.OKCancel);
            if (thoat == DialogResult.OK)
                Application.Exit();
        }
    }
}
