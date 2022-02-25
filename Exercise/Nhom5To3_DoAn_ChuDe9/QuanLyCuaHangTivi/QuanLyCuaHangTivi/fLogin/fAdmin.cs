using fLogin.DAO;
using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLogin
{
    public partial class fAdmin : Form
    {
        #region var
        BindingSource tiviList = new BindingSource();
        BindingSource nvList = new BindingSource();

        int rowIndexTV = 0; //vi tri click chuot
        int rowIndexNV = 0;
        int rowIndexBill = 0;

        public static string masonhanvien = "";
        #endregion

        public fAdmin()
        {
            InitializeComponent();
            LoadAll();
        }

        #region method

        void LoadAll()
        {
            dtgvStorage.DataSource = tiviList;
            dtgvStaff.DataSource = nvList;

            LoadListTivi();
            SetHeadertextDtgvTivi(dtgvStorage);
            LoadListNhanVien();
            SetHeadertextDtgvNV(dtgvStaff);
            LoadDtpCbbRdb();

            AddNVBinding();
            AddTiviBinding();
        }
        void LoadDtpCbbRdb()
        {
            DateTime today = DateTime.Now;
            dtpTu.Value = new DateTime(today.Year, today.Month, 1);
            dtpDen.Value = dtpTu.Value.AddMonths(1).AddDays(-1);

            cbbHangTV.SelectedIndex = 0;
            cbbBaoHanh.SelectedIndex = 0;
            cbbSize.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;

            rdbNam.Checked = true;
        }
        void LoadListTivi()
        {
            tiviList.DataSource = TiviDAO.Instance.GetListTivi();

        }
        void AddTiviBinding()
        {
            txtModel.DataBindings.Add(new Binding("Text", dtgvStorage.DataSource, "mstivi", true, DataSourceUpdateMode.Never));
            txtGia.DataBindings.Add(new Binding("Text", dtgvStorage.DataSource, "gia", true, DataSourceUpdateMode.Never));

        }
        void AllComboboxBindingTivi()
        {
            DataGridViewRow dr = dtgvStorage.Rows[rowIndexTV];
            cbbHangTV.SelectedItem = dr.Cells[1].Value.ToString();
            cbbSize.SelectedItem = dr.Cells[5].Value.ToString();
            cbbStatus.SelectedItem = dr.Cells[2].Value.ToString();
            cbbBaoHanh.SelectedItem = dr.Cells[4].Value.ToString();
        }
        void LoadListNhanVien()
        {
            nvList.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }
        void AddNVBinding()
        {
            txtMs.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "msnv", true, DataSourceUpdateMode.Never));
            txtSdt.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "hoten", true, DataSourceUpdateMode.Never));
            txtDiachi.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            txtLuongcb.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "luongcoban", true, DataSourceUpdateMode.Never));
            txtHsLuong.DataBindings.Add(new Binding("Text", dtgvStaff.DataSource, "hesoluong", true, DataSourceUpdateMode.Never));
        }
        void AllComboboxBindingNV()
        {
            DataGridViewRow dr = dtgvStaff.Rows[rowIndexNV];
            string gt = dr.Cells[2].Value.ToString();
            if (gt == "Nam")
                rdbNam.Checked = true;
            else
                rdbNu.Checked = true;

            dtpNamSinhNV.Value = Convert.ToDateTime(dr.Cells[4].Value.ToString());
        }
        bool DelAccountByID(string id)
        {
            return TaiKhoanDAO.Instance.DelAccount(id);
        }
        void SetHeadertextDtgvRevenue(DataGridView data)
        {
            data.Columns["Madonhang"].HeaderText = "Mã đơn hàng";
            data.Columns["Tongtien"].HeaderText = "Tổng tiền";
            data.Columns["Khuyenmai"].HeaderText = "Khuyến mãi";
            data.Columns["Ngayban"].HeaderText = "Ngày bán";
            data.Columns["Tenkh"].HeaderText = "Tên khách hàng";
        }
        void SetHeadertextDtgvTivi(DataGridView data)
        {
            data.Columns["mstivi"].HeaderText = "Model tivi";
            data.Columns["tenhang"].HeaderText = "Thương hiệu";
            data.Columns["kichthuoc"].HeaderText = "Kích thước";
            data.Columns["gia"].HeaderText = "Giá";
            data.Columns["tinhtrang"].HeaderText = "Tình trạng";
            data.Columns["baohanh"].HeaderText = "Bảo hành";
            data.Columns["soluong"].HeaderText = "Số lượng";
        }
        void SetHeadertextDtgvNV(DataGridView data)
        {
            data.Columns["Msnv"].HeaderText = "Mã số nhân viên";
            data.Columns["Hoten"].HeaderText = "Họ và tên";
            data.Columns["Gioitinh"].HeaderText = "Giới tính";
            data.Columns["Diachi"].HeaderText = "Địa chỉ";
            data.Columns["Namsinh"].HeaderText = "Năm sinh";
            data.Columns["Sdt"].HeaderText = "Số điện thoại";
            data.Columns["Luongcoban"].HeaderText = "Lương cơ bản";
            data.Columns["Hesoluong"].HeaderText = "Hệ số lương";
            data.Columns["Luong"].HeaderText = "Lương";
        }

        string getString(string str)
        {
            return Regex.Replace(str, @"[^a-zA-Z0-9]", string.Empty);
        }
        
        #endregion

        #region event
        private void FAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK))
                e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tu = dtpTu.Value;
            DateTime den = dtpDen.Value;
            List<HoaDon> listHD = HoaDonDAO.Instance.GetListBillByDate(tu, den);
            dtgvRevenue.DataSource = listHD;
            SetHeadertextDtgvRevenue(dtgvRevenue);

            int sodonhang = dtgvRevenue.Rows.Count;
            int tongdoanhthu = 0;
            int sosp = 0;
            foreach (HoaDon item in listHD)
            {
                tongdoanhthu +=  item.Tongtien;
                sosp += DataProvider.Instance.GetIntValue("select sum(sluong) from TTDONHANG, TIVI , DONHANG where masp = mstivi and madonhang = iddonhang and iddonhang = " + item.Madonhang);
            }
            

            txtTongDoanhThu.Text = tongdoanhthu.ToString();
            txtSodonhang.Text = sodonhang.ToString();
            txtSosanpham.Text = sosp.ToString();



        }
        private void dtgvStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexTV = e.RowIndex;
            AllComboboxBindingTivi();
        }
        private void dtgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexNV = e.RowIndex;
            AllComboboxBindingNV();
        }
        private void button2_Click(object sender, EventArgs e) 
        {
            string model = getString(txtModel.Text); //ten tivi
            int gia = 0;
            if(!int.TryParse(txtGia.Text, out gia))//gia
                MessageBox.Show("Bạn đã nhập sai giá", "thông báo");
            gia = Math.Abs(gia);
            string tenhang = cbbHangTV.SelectedItem.ToString();
            ThuongHieuDAO.Intstance.InsertThuongHieu(tenhang);
            int hang = ThuongHieuDAO.Intstance.getIDThuongHieu(tenhang);

            int kichthuoc = Convert.ToInt32(cbbSize.SelectedItem.ToString()); //size
            int baohanh = Convert.ToInt32(cbbBaoHanh.SelectedItem.ToString()); //bao hanh
            string tinhtrang = cbbStatus.SelectedItem.ToString();  //tinh trang
            int soluong = (int)numTivi.Value;

            if (model != "" && gia!=0 && !TiviDAO.Instance.checkModelTivi(model) && TiviDAO.Instance.InsertTivi(model, hang, gia, kichthuoc, baohanh, tinhtrang, soluong))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadListTivi();
            }
            else
                MessageBox.Show("Sai thông tin. thêm thất bại", "Thông báo");
            dtgvStorage.ClearSelection();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            dtgvStorage.ClearSelection();
            LoadListTivi();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                DataGridViewRow dr = dtgvStorage.Rows[rowIndexTV];
                name = dr.Cells[0].Value.ToString();
            }
            catch { MessageBox.Show("Vui lòng chọn trước khi sửa", "Thông báo"); return; }

            string model = getString(txtModel.Text);//ten moi
            int gia = 0;
            if (!int.TryParse(txtGia.Text, out gia))//gia
                MessageBox.Show("Bạn đã nhập sai giá", "thông báo");
            gia = Math.Abs(gia);
            string tenhang = cbbHangTV.SelectedItem.ToString();
            ThuongHieuDAO.Intstance.InsertThuongHieu(tenhang);
            int hang = ThuongHieuDAO.Intstance.getIDThuongHieu(tenhang);

            int kichthuoc = Convert.ToInt32(cbbSize.SelectedItem.ToString());//size moi
            int baohanh = Convert.ToInt32(cbbBaoHanh.SelectedItem.ToString());//bao hanh moi
            string tinhtrang = cbbStatus.SelectedItem.ToString();//tỉnh trang moi
            int soluong = (int)numTivi.Value;

            if (!TiviDAO.Instance.checkModelTivi(model, name) && gia != 0 && kichthuoc != 0 && baohanh != 0 && tinhtrang != "")
            {
                if (name == model)
                {
                    //update tivi voi bo thong tin moi (id cu)
                    TiviDAO.Instance.UpdateTivi(model, hang, kichthuoc, gia, baohanh, tinhtrang, soluong);
                }

                else
                {
                    //them tv voi bo thong tin moi (id moi)
                    TiviDAO.Instance.InsertTivi(model, hang, gia, kichthuoc, baohanh, tinhtrang, soluong);

                    //UPdate TTDH khoa phu theo id moi
                    ThongTinHoaDonDAO.Instance.UpdateTTHD(name, model);

                    //xoa tv voi bo thong tin cu
                    TiviDAO.Instance.DeleteTivi(name);
                }
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadListTivi();
            }
            else
                MessageBox.Show("Thông tin không chính xác. Sửa thất bại", "Thông báo");
            dtgvStorage.ClearSelection();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string model = "";
            try
            {
                DataGridViewRow dr = dtgvStorage.Rows[rowIndexTV];
                model = dr.Cells[0].Value.ToString();
            }
            catch { MessageBox.Show("Vui lòng chọn trước khi xóa", "Thông báo"); return; }
            if (model != "" &&  TiviDAO.Instance.checkModelTivi(model))
            {
                if (ThongTinHoaDonDAO.Instance.UpdateDeletedTivi(model))
                {
                    if (TiviDAO.Instance.DeleteTivi(model))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        LoadListTivi();
                    }
                }
                else
                {
                    TiviDAO.Instance.DeleteTivi(model);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    LoadListTivi();
                }
            }
            else
                MessageBox.Show("Sai thông tin. xóa thất bại", "Thông báo");
            dtgvStorage.ClearSelection();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            dtgvStorage.ClearSelection();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExitnv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelNv_Click(object sender, EventArgs e)
        {
            dtgvStaff.ClearSelection();
        }
        private void btnReloadNv_Click(object sender, EventArgs e)
        {
            dtgvStaff.ClearSelection();
            LoadListTivi();
        }
        private void btnThemNv_Click(object sender, EventArgs e)
        {
            masonhanvien = getString(txtMs.Text);

            string msnv = getString(txtMs.Text);
            string hoten = txtName.Text;
            string giotinh = (rdbNam.Checked) ? "Nam" : "Nữ";
            string diachi = txtDiachi.Text;
            DateTime namsinh = dtpNamSinhNV.Value;
            string sdt = getString(txtSdt.Text);

            int luongcb = 0;
            if (!int.TryParse(txtLuongcb.Text, out luongcb))
                MessageBox.Show("Bạn đã nhập sai lương cơ bản", "Thông báo");
            luongcb = Math.Abs(luongcb);

            float hsluong = 0;
            if (!float.TryParse(txtHsLuong.Text, out hsluong))
                MessageBox.Show("Bạn đã nhập sai hệ số lương", "Thông báo");
            hsluong = Math.Abs(hsluong);

            if (!NhanVienDAO.Instance.checkIdNV(msnv) && msnv != "" && hoten != "" && diachi != "" && sdt != "" && luongcb != 0 && hsluong != 0 && NhanVienDAO.Instance.InserNV(msnv, hoten, giotinh, diachi, namsinh, sdt, luongcb, hsluong))
            {
                fSignup f = new fSignup();
                f.ShowDialog();
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Thông tin không chính xác. Thêm thất bại", "Thông báo");
            dtgvStaff.ClearSelection();
        }
        private void btnDelNV_Click(object sender, EventArgs e)
        {
            String msnv = "";
            try
            {
                DataGridViewRow dr = dtgvStaff.Rows[rowIndexNV];
                msnv = dr.Cells[0].Value.ToString();
            }
            catch { MessageBox.Show("Vui lòng chọn trước khi xóa", "Thông báo"); return; }
            if (DelAccountByID(msnv) && NhanVienDAO.Instance.checkIdNV(msnv) && NhanVienDAO.Instance.DeleteNV(msnv))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Thông tin không chính xác. Xóa thất bại", "Thông báo");
            dtgvStaff.ClearSelection();
        }
        private void btnUpdNv_Click(object sender, EventArgs e)
        {
            string msnv = getString(txtMs.Text);
            string hoten = txtName.Text;
            string giotinh = (rdbNam.Checked) ? "Nam" : "Nữ";
            string diachi = (txtDiachi.Text);
            DateTime namsinh = dtpNamSinhNV.Value;
            string sdt = getString(txtSdt.Text);
            int luongcb = 0;
            if (!int.TryParse(txtLuongcb.Text, out luongcb))
                MessageBox.Show("Bạn đã nhập sai lương cơ bản", "Thông báo");
            luongcb = Math.Abs(luongcb);

            float hsluong = 0;
            if (!float.TryParse(txtHsLuong.Text, out hsluong))
                MessageBox.Show("Bạn đã nhập sai hệ số lương", "Thông báo");
            hsluong = Math.Abs(hsluong);
            string name = "";
            try
            {
                DataGridViewRow dr = dtgvStaff.Rows[rowIndexNV];
                name = dr.Cells[0].Value.ToString();
            }
            catch { MessageBox.Show("Vui lòng chọn trước khi sửa", "Thông báo"); return; }

            if (!NhanVienDAO.Instance.checkIdNV(msnv, name) && msnv != "" && hoten != "" && diachi != "" && sdt != "" && luongcb != 0 && hsluong != 0)
            {
                if (name == msnv)
                {
                    //update nv voi bo thong tin moi (id cu)
                    NhanVienDAO.Instance.UpdateNV(msnv, hoten, giotinh, diachi, namsinh, sdt, luongcb, hsluong);
                }

                else
                {
                    //them nv voi bo thong tin moi (id moi)
                    NhanVienDAO.Instance.InserNV(msnv, hoten, giotinh, diachi, namsinh, sdt, luongcb, hsluong);

                    //date account khoa phu theo id moi
                    TaiKhoanDAO.Instance.UpdateAccount(name, msnv);

                    //xoa nv voi bo thong tin cu
                    NhanVienDAO.Instance.DeleteNV(name);
                }
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadListNhanVien();
            }
            else
                MessageBox.Show("Thông tin không chính xác. Sửa thất bại", "Thông báo");
            dtgvStaff.ClearSelection();
        }
        private void dtgvRevenue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexBill = e.RowIndex;
        }
        private void btnXemBill_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvRevenue.Rows[rowIndexBill];
            string id = row.Cells[0].Value.ToString();
            fChiTietHD f = new fChiTietHD(Convert.ToInt32(id));
            f.ShowDialog();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            dtgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStorage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
    #endregion


}
