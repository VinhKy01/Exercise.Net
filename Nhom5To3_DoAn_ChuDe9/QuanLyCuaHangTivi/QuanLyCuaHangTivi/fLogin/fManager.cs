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
    public partial class fManager : Form
    {
        #region var
        int numItem = 0; //rowcount in dtgvBillMng
        int numitemTVList = 0;
        int rowIndexBill = 0;
        int rowIndexTV = 0;
        BindingSource tvList = new BindingSource();
        TaiKhoan account;
        #endregion

        public fManager(TaiKhoan acc)
        {
            InitializeComponent();

            this.Account = acc;
            LoadAll();
        }

        #region method
        public TaiKhoan Account
        {
            get { return account; }
            set { account = value; StatusLoginAccount(account.Type); }
        }
        void LoadAll()
        {
            dtgvListTiviMng.DataSource = tvList;

            LoadListTivi();
            LoadThuongHieu();
            LoadKichThuoc();
            AddTiviBinding();
        }
        void StatusLoginAccount(int type)
        {
            quảnTrịViênToolStripMenuItem.Enabled = account.Type==1;

        }
        void LoadListTivi()
        {
            tvList.DataSource = TiviDAO.Instance.LoadListTivi();
            SetHeadertextDtgv(dtgvListTiviMng);
            numitemTVList = tvList.Count;
            dtgvListTiviMng.ClearSelection();
        }
        void LoadTiviByHangSX(string hangsx, int inch)
        {
            tvList.DataSource = TiviDAO.Instance.LoadTiviByHangSX(hangsx, inch);
        }
        void LoadThuongHieu()
        {
            List<ThuongHieu> listTH = ThuongHieuDAO.Intstance.GetListThuongHieu();
            cbbHangTV.DataSource = listTH;
            cbbHangTV.DisplayMember = "Name";
        }
        void LoadKichThuoc()
        {
            List<KichThuoc> listKT = KichThuocDAO.Intstance.GetListKichThuoc();
            cbbKichThuoc.DataSource = listKT;
            cbbKichThuoc.DisplayMember = "Kichthuoc";
        }
        void AddFirstTivi(int soluong, int tongsoluong)
        {
            DataGridViewRow dr = dtgvListTiviMng.Rows[rowIndexTV];
            DataTable data = new DataTable();
            data.Columns.Add("mstivi");
            data.Columns.Add("tenhang");
            data.Columns.Add("kichthuoc");
            data.Columns.Add("gia");
            data.Columns.Add("baohanh");
            data.Columns.Add("tinhtrang");
            data.Columns.Add("soluong");


            DataRow row = data.NewRow();

            //add values to new row
            row["mstivi"] = dr.Cells["mstivi"].Value.ToString();
            row["tenhang"] = dr.Cells["mstivi"].Value.ToString();
            row["kichthuoc"] = dr.Cells["kichthuoc"].Value.ToString();
            row["gia"] = dr.Cells["gia"].Value.ToString();
            row["baohanh"] = dr.Cells["baohanh"].Value.ToString();
            row["tinhtrang"] = dr.Cells["tinhtrang"].Value.ToString();
            row["soluong"] = (soluong).ToString();

            //update values ds tivi
            dtgvListTiviMng.Rows[rowIndexTV].Cells["soluong"].Value = tongsoluong - soluong;

            data.Rows.Add(row);

            dtgvListBillMng.DataSource = data;


            SetHeadertextDtgv(dtgvListBillMng);
        }

        void AddTiviBinding()
        {
            txtModelTV.DataBindings.Add(new Binding("Text", dtgvListTiviMng.DataSource, "mstivi", true, DataSourceUpdateMode.Never));
            txtPriceTV.DataBindings.Add(new Binding("Text", dtgvListTiviMng.DataSource, "gia", true, DataSourceUpdateMode.Never));
            txtInsurance.DataBindings.Add(new Binding("Text", dtgvListTiviMng.DataSource, "baohanh", true, DataSourceUpdateMode.Never));
        }

        void AddTiviToListBill(int soluong, int tongsoluong)
        {
            DataGridViewRow dr = dtgvListTiviMng.Rows[rowIndexTV];
            DataTable data = (DataTable)dtgvListBillMng.DataSource;
            DataRow row = data.NewRow();

            row["mstivi"] = dr.Cells["mstivi"].Value.ToString();
            row["tenhang"] = dr.Cells["mstivi"].Value.ToString();
            row["kichthuoc"] = dr.Cells["kichthuoc"].Value.ToString();
            row["gia"] = dr.Cells["gia"].Value.ToString();
            row["baohanh"] = dr.Cells["baohanh"].Value.ToString();
            row["tinhtrang"] = dr.Cells["tinhtrang"].Value.ToString();
            row["soluong"] = (soluong).ToString();

            //update values ds tivi
            dtgvListTiviMng.Rows[rowIndexTV].Cells["soluong"].Value = tongsoluong - soluong;

            data.Rows.Add(row);

            dtgvListBillMng.DataSource = data;
        }
        void setTotalPrice()
        {
            int totalPrice = 0;

            for (int i = 0; i < dtgvListBillMng.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtgvListBillMng.Rows[i];
                totalPrice += Convert.ToInt32(row.Cells[3].Value.ToString())* Convert.ToInt32(row.Cells[6].Value.ToString());
            }
            totalPrice = totalPrice - Int32.Parse(numSale.Value.ToString()) * totalPrice / 100;
            txtTotalPrice.Text = totalPrice.ToString();
        }

        void SetHeadertextDtgv(DataGridView data)
        {
            data.Columns["mstivi"].HeaderText = "Model tivi";
            data.Columns["tenhang"].HeaderText = "Thương hiệu";
            data.Columns["kichthuoc"].HeaderText = "Kích thước";
            data.Columns["gia"].HeaderText = "Giá";
            data.Columns["tinhtrang"].HeaderText = "Tình trạng";
            data.Columns["baohanh"].HeaderText = "Bảo hành";
            data.Columns["soluong"].HeaderText = "Số lượng";
        }

        List<Tivi> SearchTiviByName(string name)
        {
            List < Tivi > listTivi = new List<Tivi>();

            listTivi = TiviDAO.Instance.searchTivi(name);

            return listTivi;
        }
        private void fManager_Load(object sender, EventArgs e)
        {
            dtgvListTiviMng.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvListBillMng.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        #region event
        private void quảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fChangePassword f = new fChangePassword(Account);
            f.ShowDialog();
            this.Show();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnExitMng_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearchMng_Click(object sender, EventArgs e)
        {
            try
            {
                string hangsx = (cbbHangTV.SelectedItem as ThuongHieu).Name;
                int inch = (cbbKichThuoc.SelectedItem as KichThuoc).Kichthuoc;
                LoadTiviByHangSX(hangsx, inch);
                numitemTVList = tvList.Count;
            }
            catch { }
        }
        private void btnAddMng_Click(object sender, EventArgs e)
        {
            try
            {
                string model = txtModelTV.Text;
                int soluong = (int)numTv.Value;
                DataGridViewRow row = dtgvListTiviMng.Rows[rowIndexTV];
                string x = row.Cells["soluong"].Value.ToString();
                int tongsoluong = Convert.ToInt32(x);
                int count = dtgvListBillMng.Rows.Count;

                if (numitemTVList > 0 && soluong <= tongsoluong)
                {
                    if (soluong < tongsoluong)
                    {
                        if (count == 0)
                        {
                            AddFirstTivi(soluong, tongsoluong);
                            numItem++;
                        }
                        else
                        {
                            AddTiviToListBill(soluong, tongsoluong);
                            numItem++;
                        }
                    }
                    else
                    {
                        if (count == 0)
                        {
                            AddFirstTivi(soluong, tongsoluong);
                            numItem++;
                        }
                        else
                        {
                            AddTiviToListBill(soluong, tongsoluong);
                            numItem++;
                        }
                        dtgvListTiviMng.Rows.RemoveAt(rowIndexTV);
                        numitemTVList--;
                    }

                }
                else
                    MessageBox.Show("Hết tivi hoặc không đủ số lượng", "Thông báo");
                dtgvListTiviMng.ClearSelection();
            }
            catch { }
        }
        private void dtgvListBillMng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexBill = e.RowIndex;
        }
        private void btnDelBill_Click(object sender, EventArgs e)
        {
            if (numItem > 0)
            {
                try
                {
                    dtgvListBillMng.Rows.RemoveAt(rowIndexBill);
                    numItem--;
                }
                catch { MessageBox.Show("Vui lòng chọn trước khi xóa", "Thông báo"); return; }
            }
            else
                MessageBox.Show("Danh sách hóa đơn rỗng", "thông báo", MessageBoxButtons.OK);
            dtgvListBillMng.ClearSelection();
        }

        private void dtgvListBillMng_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            setTotalPrice();
        }
        private void dtgvListBillMng_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            setTotalPrice();
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            setTotalPrice();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadListTivi();
            LoadThuongHieu();
            LoadKichThuoc();
            dtgvListBillMng.DataSource = null;
        }
        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK))
                e.Cancel = true;
        }
        private void btnPayMng_Click(object sender, EventArgs e)
        {
            if (numItem == 0)
            {
                MessageBox.Show("Vui lòng chọn mua hàng trước khi thanh toán", "Thông báo");
                return;
            }

            int tongtien = Convert.ToInt32(txtTotalPrice.Text);

            DataTable data = (DataTable)dtgvListBillMng.DataSource;
            fDienThongTin f = new fDienThongTin(tongtien, data, (int)numSale.Value);
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadListTivi();
            dtgvListBillMng.DataSource = false;

        }
        private void dtgvListTiviMng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexTV = e.RowIndex;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtSearchName.Text;
                tvList.DataSource = SearchTiviByName(name);
                numitemTVList = tvList.Count;
            }
            catch { }
        }

        #endregion



    }
}
