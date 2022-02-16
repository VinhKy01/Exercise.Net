using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class ThongTinHoaDonDAO
    {
        private static ThongTinHoaDonDAO instance;

        public static ThongTinHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ThongTinHoaDonDAO(); return instance; }
        }

        public List<ThongTinHoaDon> GetListTTHD()
        {
            List<ThongTinHoaDon> list = new List<ThongTinHoaDon>();

            string query = "SELECT * FROM HANGTIVI";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThongTinHoaDon thuonghieu = new ThongTinHoaDon(item);
                list.Add(thuonghieu);
            }

            return list;
        }
        public bool ThemTTHD(string masp, int iddonhang, int sluong)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("insert into TTDONHANG values( @masp , @iddonhang , @sluong )", new object[] { masp, iddonhang, sluong });
            return result > 0;
        }
        public DataTable GetBillInforbyID(int id)
        {
            string query = "USP_GETBILLINFOR " + id.ToString();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
        public int getSum(int id)
        {
            int sum = 0;
            DataTable data = GetBillInforbyID(id);
            foreach(DataRow row in data.Rows)
            {
                sum += (int)row.ItemArray[3];
            }
            return sum;
        }
        public bool UpdateTTHD(string modelcu, string modelmoi)
        {
            string query = "update TTDONHANG set masp = '" + modelmoi + "' where masp = '" + modelcu + "'";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateDeletedTivi(string model)
        {
            return DataProvider.Instance.ExcuteNonQuery("USP_UPDATETIVIEROR N'" + model + "'") > 0;
        }
    }
}
