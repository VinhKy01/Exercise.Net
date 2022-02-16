using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontinh_Click(object sender, EventArgs e)
        {
            decimal x, f;
            x = decimal.Parse(textso1.Text);

            if (x >= 2)
            {
                f = -8 * x * x * x - 12 * x - 1;
                textso2.Text = f.ToString();
            }
            else
            {
                if(x>1 && x < 2)
                {
                    f = x * x - 6 * x - 19;
                    textso2.Text = f.ToString();
                }
                else
                {
                    f = 7 * x;
                    textso2.Text = f.ToString();
                }
            }
        }
    }
}
