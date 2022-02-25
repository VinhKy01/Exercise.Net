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
    public partial class fDienThongTin : Form
    {
        int tongtienHD =0;
        int khmai = 0;
        DataTable data; //danh sach san pham dc chon
        List<Tivi> listtv = new List<Tivi>();
        public fDienThongTin(int tongtien, DataTable datatable, int khuyenmai)
        {
            data = datatable;
            khmai = khuyenmai;
            tongtienHD = tongtien;

            InitializeComponent();
        }
        void UpdateSanPhamDaBan()
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Xác nhận thanh toán đon hàng!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK))
            {
                //luu thong tin khach hang va thong tin hoa don
                string ten = txtTenKH.Text;
                string gioitinh = (rdbNam.Checked) ? "Nam" : "Nữ";
                string diachi = txtDiaChiKH.Text;
                string sdt = txtSdtKH.Text;
                DateTime namsinh = dpNamSinhKH.Value;

                KhachHang kh = new KhachHang(ten, namsinh, diachi, sdt, gioitinh);

                


                if(KhachHangDAO.Instance.AddKHByPara(kh))
                {
                    if(HoaDonDAO.Instance.AdBill(KhachHangDAO.Instance.getIDLastAdd(), tongtienHD, khmai))
                    {
                        int iddonhang = DataProvider.Instance.GetIntValue("select max(madonhang) from DONHANG");
                        foreach(DataRow row in data.Rows)
                        {
                            if (row.RowState != DataRowState.Deleted)
                            {
                                Tivi tivi = new Tivi(row);
                                ThongTinHoaDonDAO.Instance.ThemTTHD(tivi.Mstivi, iddonhang, tivi.Soluong);
                                TiviDAO.Instance.UpdateSPBanById(row["mstivi"].ToString(), tivi.Soluong);
                            }
                        }
                        MessageBox.Show("Nhập đơn hàng thành công", "Thông báo");
                        UpdateSanPhamDaBan();
                        fXuatHD f = new fXuatHD(kh, iddonhang);
                        f.ShowDialog();


                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Có gì đó sai sai", "Thông báo");
            }
        }

        void gomTivi()
        {
            foreach (DataRow row in data.Rows)
            {
                Tivi tv = new Tivi(row);
                foreach (Tivi tivi in listtv)
                {
                    if (tivi.Mstivi != tv.Mstivi)
                    {
                        listtv.Add(tv);
                    }
                    else
                    {
                        tivi.Soluong += tv.Soluong;
                    }
                }
            }
        }

        private void fDienThongTin_Load(object sender, EventArgs e)
        {
           // gomTivi();
        }
    }
}
