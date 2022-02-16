using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
        }

        private TaiKhoanDAO() { }
        public bool login(String username, String password)
        {
            String query = "EXEC USP_LOGIN @user , @pass";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password});
            return data.Rows.Count > 0;
        }
        public bool DelAccount(string id)
        {
            string query = "DELETE TAIKHOAN WHERE masovn = N'" + id + "'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string oldId, string newID)
        {
            string query = "update TAIKHOAN set masovn = '"+newID+"' where masovn = '"+oldId+"'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool InserAccount(string username, string password, string manv)
        {
            string query = "exec USP_THEMTK @username , @password , @msnv";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, password, manv });

            return result > 0;
        }
        public bool InserAccountAdmin(string username, string password)
        {
            string query = "exec USP_THEMTKADMIN @username , @password ";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username, password });

            return result > 0;
        }
        public bool checkUsername(string username)
        {
            string query = "select * from TAIKHOAN where username = N'" + username + "'";
                    
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data.Rows.Count > 0;
        }
        public TaiKhoan GetAccByUsername(string username)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from TAIKHOAN WHERE username = N'" + username+"'");

            foreach(DataRow row in data.Rows)
            {
                return new TaiKhoan(row);
            }
            return null;
        }
        public void ChangePassword(string username, string newpass)
        {
            DataProvider.Instance.ExcuteNonQuery("update TAIKHOAN set password = '"+ newpass+"' where username = '" + username+"'");
        }
    }
}
