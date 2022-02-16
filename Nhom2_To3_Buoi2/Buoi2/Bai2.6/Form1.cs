using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int so1, so2, keuqua;
            so1 = Int32.Parse(txtso1.Text);
            so2 = Int32.Parse(txtso2.Text);
            keuqua = so1 + so2;
            MessageBox.Show($"Kết quả là {so1} + {so2} = {keuqua}");
        }
    }
}
