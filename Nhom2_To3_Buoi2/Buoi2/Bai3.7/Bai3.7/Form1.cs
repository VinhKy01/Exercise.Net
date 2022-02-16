using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, denta, nghiemkep, x1, x2;
            a = Int32.Parse(textA.Text);
            b = Int32.Parse(textB.Text);
            c = Int32.Parse(textC.Text);
            denta = b * b - 4 * a * c;
            if (denta < 0)
            {
                MessageBox.Show("PHƯƠNG TRÌNH VÔ NGHIỆM !!!");
            }
            else
            {
                if (denta == 0)
                {
                    MessageBox.Show("PHƯƠNG TRÌNH CÓ NGHIỆM KÉP");
                    nghiemkep = -b / (2 * a);
                    textX1.Text = $"X1 = {nghiemkep}";
                    textX2.Text = $"X2 = {nghiemkep}";
                }
                else
                {
                    if (denta > 0)
                    {
                        MessageBox.Show("PHƯƠNG TRÌNH CÓ 2 NGHIỆM PHÂN BIỆT");
                        x1 = (float)((-b + Math.Sqrt(denta)) / (2 * a));
                        x2 = (float)((-b - Math.Sqrt(denta)) / (2 * a));
                        textX1.Text = $"X1 = {x1}";
                        textX2.Text = $"X2 = {x2}";
                    }
                }
            }
        }
    }
}
