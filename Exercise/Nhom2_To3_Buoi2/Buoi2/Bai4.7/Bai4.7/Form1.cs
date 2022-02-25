using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            int n, s = 1;
            n = Int32.Parse(textN.Text);
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            textS.Text = s.ToString();
        }
    }
}
