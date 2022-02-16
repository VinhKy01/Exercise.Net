using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtOutput.Clear();
            this.txtInput.Text = Mang.chuanHoaChuoi(this.txtInput.Text);
            String[] arr = txtInput.Text.Split(' ');

            if (this.rdbXuat.Checked)
            {
                foreach (var i in arr)
                {
                    txtOutput.Text += $"{i} ";
                }       
            }
            else if (this.rdbMin.Checked)
            {
                int min = Int32.Parse(arr[0]);
                foreach (var i in arr)
                {
                    if (min > Int32.Parse(i))
                        min = Int32.Parse(i);
                }
                this.txtOutput.Text = min.ToString();
            }
            else if (this.rdbLietKeChan.Checked)
            {
                String soChan = "";
                foreach(var i in arr)
                {
                    if (Int32.Parse(i) % 2 == 0)
                        soChan = soChan + i + " ";
                }
                this.txtOutput.Text = soChan;
            }
            else if (this.rdbChanCuoi.Checked)
            {
                String soCuoi = "";
                foreach(var i in arr)
                {
                    if (Int32.Parse(i) % 2 == 0)
                        soCuoi = i;
                }
                this.txtOutput.Text = soCuoi;
            }
            else if (this.rdbTongChan.Checked)
            {
                int tong = 0;
                foreach (var i in arr)
                {
                    if (Int32.Parse(i) % 2 == 0)
                        tong += Int32.Parse(i);
                }
                this.txtOutput.Text = tong.ToString();
            }
            else if (this.rdbTongLe.Checked)
            {
                int tong = 0;
                foreach (var i in arr)
                {
                    if (Int32.Parse(i) % 2 == 1)
                        tong += Int32.Parse(i);
                }
                this.txtOutput.Text = tong.ToString();
            }
            else if (this.rdbSoGTChan.Checked)
            {
                int count = 0;
                foreach (var i in arr)
                {
                    if (Int32.Parse(i) % 2 == 0)
                        count ++;
                }
                this.txtOutput.Text = count.ToString();
            }
            else if (this.rdbSoGTLe.Checked)
            {
                int count = 0;
                foreach (var i in arr)
                {
                    if (Int32.Parse(i) % 2 == 1)
                        count++;
                }
                this.txtOutput.Text = count.ToString();
            }

            /*
                        RadioButton rdbTest = new RadioButton();
                        if (rdbTest.Enabled == true)
                            switch (rdbTest.Name)
                            {
                                case "rdbXuat":
                                    {
                                        this.txtInput.Text = Mang.chuanHoaChuoi(this.txtInput.Text);
                                        mangKyTu = Mang.ganChuoi(this.txtInput.Text);
                                        mangSoNguyen = Mang.mangSo(mangKyTu);

                                        this.txtOutput.Text = Mang.chuyenVeChuoi(mangSoNguyen);
                                        break;
                                    }
                                case "rdbMin":
                                    {
                                        break;
                                    }
                                case "rdbLietKeChan":
                                    {
                                        break;
                                    }
                                case "rdbChanCuoi":
                                    {
                                        break;
                                    }
                                case "rdbTongLe":
                                    {
                                        break;
                                    }
                                case "rdbTongChan":
                                    {
                                        break;
                                    }
                                case "rdbSoGTChan":
                                    {
                                        break;
                                    }
                                case "rdbSoGTLe":
                                    {
                                        break;
                                    }
                            }
                    } */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
