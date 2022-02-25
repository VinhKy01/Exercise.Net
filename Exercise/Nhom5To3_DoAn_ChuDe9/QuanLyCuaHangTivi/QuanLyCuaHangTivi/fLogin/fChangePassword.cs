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
    public partial class fChangePassword : Form
    {
        private TaiKhoan account;
        public TaiKhoan Account { get => account; set => account = value; }

        public fChangePassword(TaiKhoan acc)
        {
            account = acc;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK))
                e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

            if(txtPassword.Text != account.Password)
            {
                MessageBox.Show("Sai mật khẩu!", "Thông báo");
            }
            else
            {
                if (txtNewPass.Text == "" || txtNewPass.Text != txtNewRetypePass.Text)
                    MessageBox.Show("Mật khẩu mới chưa đúng. Vui lòng nhập lại!", "Thông báo");
                else
                {
                    TaiKhoanDAO.Instance.ChangePassword(txtUsername.Text, txtNewPass.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                    this.Close();
                }
            }
        }

        private void fChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Account.Username;
        }
    }
}
