using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int[] a;


        private void button5_Click(object sender, EventArgs e)
        {
            a = new int[10];
            String t = "";
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);
                t = t + a[i].ToString() + " ";
            }
            this.txtInput.Text = t;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach(int x in a)
            {
                tong += x;
            }
            txtOutput.Text = tong.ToString();
        }

        private void btnSoPTLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach(int temp in a)
            {
                if (temp % 2 == 1)
                    dem++;
            }
            this.txtOutput.Text = dem.ToString();
        }

        private void btnTongLe_Click(object sender, EventArgs e)
        {
            int tongLe = 0;
            foreach (int temp in a)
            {
                if (temp % 2 == 1)
                    tongLe += temp; 
            }
            this.txtOutput.Text = tongLe.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = a[0];
            foreach (int temp in a)
            {
                if (temp < min)
                    min = temp;
            }
            this.txtOutput.Text = min.ToString();
        }

        private void btnUpTo2_Click(object sender, EventArgs e)
        {
            String t = "";
            for(int i = 0; i < a.Length; i++)
            {
                a[i] += 2;
                t = t + a[i].ToString() + " ";
            }
            this.txtInput.Text = t;
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length-1; i++)
                for (int j = i + 1; j < a.Length ; j++)
                    if (a[i] > a[j])
                    {
                        a[i] = a[i] - a[j];
                        a[j] = a[i] + a[j];
                        a[i] = a[j] - a[i];
                    }
            xuat();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length-1; i++)
                for (int j = i + 1; j < a.Length; j++)
                    if (a[i] < a[j])
                    {
                        a[i] = a[i] - a[j];
                        a[j] = a[i] + a[j];
                        a[i] = a[j] - a[i];
                    }
            xuat();
        }

        void xuat()
        {
            String t = "";
            foreach(int i in a)
            {
                t = t + i.ToString() +" ";
            }
            this.txtOutput.Text = t;
        }
    }
}
