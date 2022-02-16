using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using fLogin.DTO;

namespace fLogin.DAO
{
    public class ThuongHieuDAO
    {
        private static ThuongHieuDAO instance;

        public static ThuongHieuDAO Intstance {
            get { if (instance == null) instance = new ThuongHieuDAO(); return ThuongHieuDAO.instance; }
        }
        private ThuongHieuDAO() { }
        public List<ThuongHieu> GetListThuongHieu()
        {
            List<ThuongHieu> list = new List<ThuongHieu>();

            string query = "SELECT mshang, tenhang FROM HANGTIVI , tivi WHERE mshang=hangsx and tenhang != N'UNDETECTED'  group by mshang, tenhang";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                ThuongHieu thuonghieu = new ThuongHieu(item);
                list.Add(thuonghieu);
            }

            return list;

        }
        public bool InsertThuongHieu(string name)
        {
            if (checkNameTH(name))
                return true;

            string query = "INSERT INTO HANGTIVI VALUES ( N'"+name+"')";

            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool checkNameTH(string name)
        {
            string query = "select * from HANGTIVI where tenhang = N'" + name + "'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data.Rows.Count > 0;
        }
        public int getIDThuongHieu(string name)
        {
            string query = "select mshang FROM HANGTIVI where tenhang = '" + name+"'";
            return DataProvider.Instance.GetIntValue(query);
        }
    }
}
