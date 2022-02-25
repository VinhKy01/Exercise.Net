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
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;
            string passretype = txtretype.Text;

            if(username == "" || TaiKhoanDAO.Instance.checkUsername(username))
            {
                MessageBox.Show("Tên đăng nhập đã được sử dụng hoặc không hợp lệ. Vui lòng nhập tên khác!", "Thông báo");
            }
            else 
            {
                if(password!="" &&  password == passretype)
                {
                    TaiKhoanDAO.Instance.InserAccount(username, passretype, fAdmin.masonhanvien);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không hợp lệ hoặc nhập sai. Vui lòng nhập lại!");
                }
            }
        }
    }
}
