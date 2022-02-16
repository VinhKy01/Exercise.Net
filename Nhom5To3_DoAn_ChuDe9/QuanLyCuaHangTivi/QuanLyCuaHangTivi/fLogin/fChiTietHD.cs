using fLogin.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fChiTietHD : Form
    {
        int iddonhang = 0;
        public fChiTietHD(int id)
        {
            InitializeComponent();
            iddonhang = id;
        }
        void SetHeadertextDtgv(DataGridView data)
        {
            data.Columns["masp"].HeaderText = "Mã sản phẩm";
            data.Columns["gia"].HeaderText = "Giá";
            data.Columns["soluong"].HeaderText = "Số lượng";
            data.Columns["thanhtien"].HeaderText = "Thành tiền";
        }
        private void fChiTietHD_Load(object sender, EventArgs e)
        {
            dtgvTTDonHang.DataSource = ThongTinHoaDonDAO.Instance.GetBillInforbyID(iddonhang);
            SetHeadertextDtgv(dtgvTTDonHang);
            dtgvTTDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
