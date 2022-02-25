using Bai10._69.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10._69.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
        }

        private NhanVienDAO() { }

        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "SELECT n.manv, n.holot, n.ten, n.phai, n.ngaysinh, c.tencv FROM dbo.NhanVien AS n, dbo.ChucVu AS c WHERE n.macv=c.macv ";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }

            return list;

        }

        public DataTable LoadNhanVien()
        {
            string query = "SELECT n.manv, n.holot, n.ten, n.phai, n.ngaysinh, c.tencv FROM dbo.NhanVien AS n, dbo.ChucVu AS c WHERE n.macv=c.macv ";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool ThemNV(string manv, string holot, string ten, string phai, DateTime ngaysinh, string tencv)
        {
            string id = GetMaCV(tencv);
            string query = "exec ThemNV @manv , @holot , @ten , @phai , @ngaysinh , @id ";
            return  DataProvider.Instance.ExcuteNonQuery(query, new object[] { manv, holot, ten, phai, ngaysinh, id }) > 0;

        }
        public bool XoaNV(string manv)
        {
            string query = "delete NhanVien where manv = N'"+manv+"'";
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;

        }


        public string GetMaCV(string ten)
        {
            string query = "SELECT	macv FROM  dbo.ChucVu WHERE tencv = N'" + ten+"'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return(string)data.Rows[0][0];
        }


        public void SuaNV(string id, string manv, string holot, string ten, string phai, DateTime ngaysinh, string tencv)
        {
            string macv = GetMaCV(tencv);
            string query = "EXEC SUANV @id , @manv , @holot , @ten , @phai ,  @ngaysinh , @macv ";
            DataProvider.Instance.ExcuteNonQuery(query, new object[] { id, manv, holot, ten, phai, ngaysinh, macv});

        }


        public bool checkIdNV(string id, string name = null)
        {
            if (id == name)
                return false;

            string query = "select * from NHANVIEN where manv = N'" + id + "'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data.Rows.Count > 0;
        }
    }
}
