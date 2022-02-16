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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        bool login(string username, string password)
        {

            return TaiKhoanDAO.Instance.login(username, password);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK))
                e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (login(username, password))
            {
                TaiKhoan loginacc = TaiKhoanDAO.Instance.GetAccByUsername(username);
                fManager f = new fManager(loginacc);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo");
        }

    }
}
