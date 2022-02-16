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
    public partial class fArray : Form
    {
        int gtri = 0;
        public fArray()
        {
            InitializeComponent();
        }

        public fArray (int gitriForm1) : this()
        {
            gtri = gitriForm1;
            int[] mang = new int[gtri];
            int num;
            Random rand = new Random();
            for (int i = 0; i < gtri; i++)
            {
                num = rand.Next(1, 100);
                mang[i] = num;
                txtMang.Text += mang[i].ToString() + " ";
                if (mang[i] % 2 == 0)
                {
                    txtSoChan.Text += mang[i].ToString() + " ";
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có thực sự muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (thoat == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
