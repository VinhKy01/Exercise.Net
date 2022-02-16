using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class KichThuocDAO
    {
        private static KichThuocDAO instance;
        public static KichThuocDAO Intstance
        {
            get { if (instance == null) instance = new KichThuocDAO(); return KichThuocDAO.instance; }
        }
        private KichThuocDAO() { }
        public List<KichThuoc> GetListKichThuoc()
        {
            List<KichThuoc> list = new List<KichThuoc>();

            string query = "select kichthuoc from TIVI where kichthuoc != 1 group by kichthuoc";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KichThuoc kichthuoc = new KichThuoc(item);
                list.Add(kichthuoc);
            }

            return list;

        }

    }
}
