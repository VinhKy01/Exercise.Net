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
    public partial class fChuNhat : Form
    {
        int dai = 0;
        int rong = 0;
        public fChuNhat(int d, int r)
        {
            dai = d; rong = r;
            InitializeComponent();
        }

        private void fChuNhat_Load(object sender, EventArgs e)
        {
            Tinh t = new Tinh(dai, rong);
            txtCV.Text = t.Chuvi.ToString();
            txtDT.Text = t.Dientich.ToString();
        }
    }
}
