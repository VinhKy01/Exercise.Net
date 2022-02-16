using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonkiemtra_Click(object sender, EventArgs e)
        {
            int day, month, year;
            day = Int32.Parse(textday.Text);
            month = Int32.Parse(textmonth.Text);
            year = Int32.Parse(textyear.Text);
            switch (month)
            {
                case 1:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 2:
                    {
                        if (day >= 1 && day <= 28)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 3:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 4:
                    {
                        if (day >= 1 && day <= 30)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        break;
                    }
                case 5:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 6:
                    {
                        if (day >= 1 && day <= 30)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 7:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 8:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 9:
                    {
                        if (day >= 1 && day <= 30)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 10:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 11:
                    {
                        if (day >= 1 && day <= 30)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }
                case 12:
                    {
                        if (day >= 1 && day <= 31)
                            MessageBox.Show("NGÀY HỢP LỆ");
                        else
                            MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }

                default:
                    {
                        MessageBox.Show("NGÀY KHÔNG HỢP LỆ");
                        break;
                    }

            }
        }
    }
}
