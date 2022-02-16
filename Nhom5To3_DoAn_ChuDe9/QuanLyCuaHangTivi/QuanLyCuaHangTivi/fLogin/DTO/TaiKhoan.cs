using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class TaiKhoan
    {
        string username, password;
        int type;
        #region properties
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
        #endregion
        public TaiKhoan(string username, int type,  string password = null)
        {
            this.Username = username;
            this.Password = password;
            this.Type = type;
        }
        public TaiKhoan(DataRow row)
        {
            this.Username = row["username"].ToString() ;
            this.Password = row["password"].ToString();
            this.Type = (int)row["loaitk"];
        }
    }
}
