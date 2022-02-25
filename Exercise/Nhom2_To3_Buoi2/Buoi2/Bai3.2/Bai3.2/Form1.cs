using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int somua;
            somua = Int32.Parse(textsomua.Text);
            if (somua >= 1 && somua <= 3)
            {
                MessageBox.Show("MÙA XUÂN");
            }
            else
            {
                if (somua > 3 && somua <= 6)
                {
                    MessageBox.Show("MÙA HẠ");
                }
                else
                {
                    if (somua > 6 && somua <= 9)
                    {
                        MessageBox.Show("MÙA THU");
                    }
                    else
                    {
                        if (somua > 9 && somua <= 12)
                        {
                            MessageBox.Show("MÙA ĐÔNG");
                        }
                        else
                        {
                            MessageBox.Show("BẠN PHẢI NHẬP VÀO 12 THÁNG TRONG NĂM");
                        }
                    }
                }
            }
        }
    }
}
