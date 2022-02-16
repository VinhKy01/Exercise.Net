using fLogin.DAO;
using fLogin.DTO;
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
    public partial class fXuatHD : Form
    {
        KhachHang kh;
        int iddonhang;
        public fXuatHD(KhachHang k, int id)
        {
            InitializeComponent();

            kh = k;
            iddonhang = id;
        }
        void SetHeadertextDtgv(DataGridView data)
        {
            data.Columns["masp"].HeaderText = "Mã sản phẩm";
            data.Columns["gia"].HeaderText = "Giá";
            data.Columns["soluong"].HeaderText = "Số lượng";
            data.Columns["thanhtien"].HeaderText = "Thành tiền";
        }
        private void fXuatHD_Load(object sender, EventArgs e)
        {
            //xuat tt kh
            txtTenKH.Text = kh.Tenkh;
            txtGioitinh.Text = kh.Gioitinh;
            txtnamsinh.Text = kh.Namsinh.ToString();
            txtDiaChiKH.Text = kh.Diachi;
            txtSdtKH.Text = kh.Sdt;

            //xuat tt bill
            HoaDon hd = HoaDonDAO.Instance.getHDByID(iddonhang);
            txtmadon.Text = hd.Madonhang.ToString();
            txtngaymua.Text = hd.Ngayban.ToString();
            txtThanhtien.Text = hd.Tongtien.ToString();
            txtGiamgia.Text = hd.Khuyenmai.ToString() + " % (-" + (ThongTinHoaDonDAO.Instance.getSum(hd.Madonhang)-hd.Tongtien).ToString() + " )";
            txttongtien.Text = ThongTinHoaDonDAO.Instance.getSum(hd.Madonhang).ToString();

            //danh sach sp
            dtgvTTDonHang.DataSource = ThongTinHoaDonDAO.Instance.GetBillInforbyID(hd.Madonhang);
            SetHeadertextDtgv(dtgvTTDonHang);

            dtgvTTDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void TTKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK))
                e.Cancel = true;
        }


    }
}
