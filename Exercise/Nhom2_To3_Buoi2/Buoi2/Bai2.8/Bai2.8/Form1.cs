using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttontong_Click(object sender, EventArgs e)
        {
            int number1, number2, kq;
            number1 = Int32.Parse(text1.Text);
            number2 = Int32.Parse(text2.Text);
            kq = number1 + number2;
            textkq.Text = kq.ToString();
        }
    }
}
