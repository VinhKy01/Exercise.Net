using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
        }
        public List<HoaDon> GetListBillByDate(DateTime tu, DateTime den)
        {
            List<HoaDon> list = new List<HoaDon>();

            string query = "EXEC USP_DSHOADON @date1 , @date2";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { tu, den});

            foreach (DataRow item in data.Rows)
            {
                HoaDon thuonghieu = new HoaDon(item);
                list.Add(thuonghieu);
            }

            return list;

        }
        public bool AdBill(int makh, int tongtien, int khmai)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_THEMDONHANG @makh , @khmai ,  @tongtien", new object[] { makh, khmai, tongtien });
            return result > 0;
        }
        public HoaDon getHDByID(int id)
        {
            string query = "EXEC USP_GETHDBYID " + id.ToString();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            HoaDon hd = new HoaDon(data.Rows[0]);

            return hd;

        }


    }
}
