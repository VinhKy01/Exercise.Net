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
    public partial class fVuong : Form
    {
        int canh = 0;
        public fVuong(int c)
        {
            canh = c;
            InitializeComponent();
        }

        private void fVuong_Load(object sender, EventArgs e)
        {
            Tinh t = new Tinh(canh, true);
            txtCV.Text = t.Chuvi.ToString();
            txtDT.Text = t.Dientich.ToString();
        }
    }
}
