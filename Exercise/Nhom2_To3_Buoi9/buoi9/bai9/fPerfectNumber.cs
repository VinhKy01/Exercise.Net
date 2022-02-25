using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai9
{
    public partial class Form2 : Form
    {
        int gitri = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int gtriForm1) : this()
        {
            gitri = gtriForm1;
            Class1 c1 = new Class1();
            if (c1.KiemTra_SHH(gitri) == true)
            {
                lblSoHoanHao.Text = gitri.ToString() + " là số hoàn hảo";
            }
            else
            {
                lblSoHoanHao.Text = gitri.ToString() + " không phải là số hoàn hảo";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thoat == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
