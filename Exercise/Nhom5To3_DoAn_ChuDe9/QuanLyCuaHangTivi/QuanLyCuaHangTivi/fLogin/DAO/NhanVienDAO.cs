using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
        }
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "EXEC USP_DSNV";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien thuonghieu = new NhanVien(item);
                list.Add(thuonghieu);
            }

            return list;

        }
        public bool InserNV(string msnv, string hoten, string gioitinh, string diachi, DateTime namsinh, string sdt, int luongocban, float hsl)
        {
            string query = "exec USP_THEMNV @msnv , @hoten , @gioitinh , @diachi , @namsinh , @sdt , @luongcoban , @hsl";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { msnv, hoten, gioitinh, diachi, namsinh, sdt, luongocban, hsl });
            return result > 0;
        }
        public bool DeleteNV(string msnv)
        {
            string query = "exec USP_XOANV @msnv ";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { msnv });
            return result > 0;
        }
        public bool UpdateNV(string msnv, string hoten, string gioitinh, string diachi, DateTime namsinh, string sdt, int luongocban, float hsl)
        {
            string query = "exec USP_SUANV @msnv , @hoten , @gioitinh , @diachi , @namsinh , @sdt , @luongcoban , @hsl";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { msnv, hoten, gioitinh, diachi, namsinh, sdt, luongocban, hsl });
            return result > 0;
        }
        public bool checkIdNV(string id, string name = null)
        {
            if (id == name)
                return false;

            string query = "select * from NHANVIEN where msvn = N'" + id + "'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data.Rows.Count > 0;
        }
        public bool InserNVAdmin(string username)
        {
            string query = "exec USP_THEMNVADMIN @msnv";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { username });

            return result > 0;
        }
    }
}
