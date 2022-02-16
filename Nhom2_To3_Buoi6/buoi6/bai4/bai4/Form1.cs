using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau6._4
{
    public partial class Form1 : Form
    {
        int num = 30;
        Ghe[] listGhe= new Ghe[30];
        Button[] listBtn = new Button[30];


        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGhe();
        }

        

        void LoadGhe()
        {
            
            for (int i = 0; i < 30; i++)
            {
                listGhe[i] = new Ghe(i, "Trống", "Ghế " + (i+1).ToString());

                listBtn[i] = new Button() { Width = 60, Height = 60 };

                listBtn[i].Click += new EventHandler(btn_Click);
                listBtn[i].Text = listGhe[i].Name + "\n" + listGhe[i].Status;
                listBtn[i].BackColor = Color.White;
                listBtn[i].Tag = listGhe[i];
                flpGhe.Controls.Add(listBtn[i]);
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Blue;
            Ghe ghe = (Ghe)btn.Tag;
            ghe.Status = "Chọn";
            btn.Text = ghe.Status;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            for (int i = 0; i< num; i++)
            {
                if(listGhe[i].Status == "Chọn")
                {
                    tongtien += 100000;
                    listGhe[i].Status = "Đã đặt";
                    listBtn[i].BackColor = Color.Yellow;
                    listBtn[i].Text = listGhe[i].Name + "\n" + listGhe[i].Status;
                }
            }
            txtTotal.Text = tongtien.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < num; i++)
            {
                if (listGhe[i].Status == "Chọn")
                {
                    listGhe[i].Status = "Trống";
                    listBtn[i].BackColor = Color.White;
                    listBtn[i].Text = listGhe[i].Name + "\n" + listGhe[i].Status;
                }
            }
        }
    }
}
