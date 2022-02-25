using Bai10._69.DAO;
using Bai10._69.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10._69
{
    public partial class Form1 : Form
    {
        int rowIndex = 0;
        BindingSource listNV = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            
        }

        void ThemNV()
        {
            string manv = txtIdStaff.Text;
            string holot = txtLastName.Text;
            string ten = txtfirstName.Text;

            string phai = (rdbMale.Checked) ? "Nam" : "Nữ";
            DateTime ngaysinh = dtpDateOfBirth.Value;

            string tencv = cbPosition.SelectedItem.ToString();

            if (!NhanVienDAO.Instance.checkIdNV(manv) && manv != "" && holot != "" && ten != "" && phai != "" && tencv != "" && NhanVienDAO.Instance.ThemNV(manv, holot, ten, phai, ngaysinh, tencv)) 
            {
                
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadListNV();
            }
            else
                MessageBox.Show("Thông tin không chính xác. Thêm thất bại", "Thông báo");
            dtgvListStaff.ClearSelection();
        }

        void XoaNV()
        {
            string manv = txtIdStaff.Text;
            if (NhanVienDAO.Instance.XoaNV(manv))
            {
                MessageBox.Show("Xoa thanh cong", "Thong bao");
                LoadListNV();
            }
            dtgvListStaff.ClearSelection();
        }

        void SuaNV()
        {
            DataGridViewRow dr = dtgvListStaff.Rows[rowIndex];
            string id = dr.Cells[0].Value.ToString();

            string manv = txtIdStaff.Text;
            string holot = txtLastName.Text;
            string ten = txtfirstName.Text;

            string phai = (rdbMale.Checked) ? "Nam" : "Nữ";
            DateTime ngaysinh = dtpDateOfBirth.Value;
            string tencv = cbPosition.SelectedItem.ToString();


            if (!NhanVienDAO.Instance.checkIdNV(manv, id) && manv != "" && holot != "" && ten != "" && phai != "" && tencv != "" )
            {       
                NhanVienDAO.Instance.SuaNV(id, manv, holot, ten, phai, ngaysinh, tencv);
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadListNV();
            }
            else
                MessageBox.Show("Thông tin không chính xác. Sửa thất bại", "Thông báo");
            dtgvListStaff.ClearSelection();
        }

        void LoadListNV()
        {
            listNV.DataSource = NhanVienDAO.Instance.LoadNhanVien();
        }


        void BindingText()
        {
            
            txtIdStaff.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "manv", true, DataSourceUpdateMode.Never));
            txtLastName.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "holot", true, DataSourceUpdateMode.Never));
            txtfirstName.DataBindings.Add(new Binding("Text", dtgvListStaff.DataSource, "ten", true, DataSourceUpdateMode.Never));


            DataGridViewRow dr = dtgvListStaff.Rows[rowIndex];

            cbPosition.SelectedItem = dr.Cells[5].Value.ToString();

            string gt = dr.Cells[3].Value.ToString();
            if (gt == "Nam")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;

            dtpDateOfBirth.Value = Convert.ToDateTime(dr.Cells[4].Value.ToString());
        }



        //-------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dtgvListStaff.DataSource = listNV;
            LoadListNV();
            BindingText();

            cbPosition.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ThemNV();

        }


        private void btnDetele_Click(object sender, EventArgs e)
        {
            XoaNV();
        }

        private void dtgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SuaNV();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtgvListStaff.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadListNV();
            dtgvListStaff.ClearSelection();
        }
    }
}
