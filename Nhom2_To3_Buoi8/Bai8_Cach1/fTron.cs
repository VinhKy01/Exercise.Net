using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Cach1
{
    public partial class fTron : Form
    {
        int bankinh = 0;
        public fTron(int bk)
        {
            bankinh = bk;
            InitializeComponent();
        }

        private void fTron_Load(object sender, EventArgs e)
        {
            Tinh t = new Tinh(bankinh);
           
            txtCV.Text = t.Chuvi.ToString();
            txtDT.Text = t.Dientich.ToString();
        }
    }
}
