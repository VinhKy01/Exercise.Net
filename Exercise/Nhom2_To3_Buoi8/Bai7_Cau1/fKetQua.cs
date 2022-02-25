using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_Cau1
{
    public partial class fKetQua : Form
    {
        Form form;
        string name = "";
        int type = 0; // 1 = tron || 2 = vuong || 3 = chu nhat || 4 = tam giac
        public fKetQua(string Name, int Type, object X)
        {
            name = Name;
            type = Type;
            form = (Form)X;
            InitializeComponent();
        }

        private void fKetQua_Load(object sender, EventArgs e)
        {
            lbTitle.Text += name;
            switch (type)
            {
                case 1:
                    {
                        fHinhTron f = (fHinhTron)form;
                        int bk = 0;
                        try
                        {
                            bk = Convert.ToInt32(f.txtBanKinh.Text);
                        }
                        catch { MessageBox.Show("Vui long nhap gia tri hop le", "Thong bao"); this.Close(); }
                        Tinh t = new Tinh(bk);
                        this.txtCV.Text = t.Chuvi.ToString();
                        this.txtDT.Text = t.Dientich.ToString();
                        break;
                    }
                case 2:
                    {
                        fVuong f = (fVuong)form;
                        int canh = 0;
                        try
                        {
                            canh = Convert.ToInt32(f.txtCanhVuong.Text);
                        }
                        catch { MessageBox.Show("Vui long nhap gia tri hop le", "Thong bao"); this.Close(); }
                        Tinh t = new Tinh(canh, true);
                        this.txtCV.Text = t.Chuvi.ToString();
                        this.txtDT.Text = t.Dientich.ToString();
                        break;
                    }
                case 3:
                    {
                        fChuNhat f = (fChuNhat)form;
                        int dai = 0;
                        int rong = 0;
                        try
                        {
                            dai = Convert.ToInt32(f.txtDai.Text);
                            rong = Convert.ToInt32(f.txtRong.Text);
                        }
                        catch { MessageBox.Show("Vui long nhap gia tri hop le", "Thong bao"); this.Close(); }
                        Tinh t = new Tinh(dai, rong);
                        this.txtCV.Text = t.Chuvi.ToString();
                        this.txtDT.Text = t.Dientich.ToString();
                        break;
                    }
                case 4:
                    {
                        fTamGiac f = (fTamGiac)form;
                        int canh1 = 0;
                        int canh2 = 0;
                        int canh3 = 0;
                        try
                        {
                            canh1 = Convert.ToInt32(f.txtCanh1.Text);
                            canh2 = Convert.ToInt32(f.txtCanh2.Text);
                            canh3 = Convert.ToInt32(f.txtCanh3.Text);
                        }
                        catch { MessageBox.Show("Vui long nhap gia tri hop le", "Thong bao"); this.Close(); }
                        
                        float banchuvi = (canh1 + canh2 + canh3) / 2;

                        if(banchuvi - canh1 <=0 || banchuvi - canh2<=0 || banchuvi - canh3<=0)
                        {
                            MessageBox.Show("Day khong phai tam giac", "Thong bao");
                            this.Close();
                        }

                        Tinh t = new Tinh(canh1, canh2, canh3);
                        this.txtCV.Text = t.Chuvi.ToString();
                        this.txtDT.Text = t.Dientich.ToString();
                        break;
                    }
            }
        }
    }
}
