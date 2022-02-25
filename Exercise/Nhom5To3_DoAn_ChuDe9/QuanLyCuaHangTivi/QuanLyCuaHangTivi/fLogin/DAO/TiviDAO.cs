using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class TiviDAO
    {
        private static TiviDAO instance;

        public static TiviDAO Instance
        {
            get { if (instance == null) instance = new TiviDAO(); return instance; }
        }

        public List<Tivi> GetListTivi()
        {
            List<Tivi> list = new List<Tivi>();

            string query = "EXEC USP_KHO";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tivi tv = new Tivi(item);
                list.Add(tv);
            }

            return list;
        }
        public bool checkModelTivi(string md, string modelcu = null)
        {
            if (md == modelcu)
                return false;

            string query = "select * from TIVI where mstivi = N'" + md + "'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data.Rows.Count > 0;
        }
        public bool InsertTivi(string mstivi, int hang, int gia, int kichthuoc, int baohanh, string tinhtrang, int soluong)
        {
            string query = "EXEC USP_INSERTTIVI @mstivi , @hangsx  , @gia , @kichthuoc , @baohanh , @tinhtrang , @soluong";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mstivi, hang, gia, kichthuoc, baohanh, tinhtrang, soluong });
            return result > 0;
        }
        public bool UpdateTivi(string mstivi, int hang,  int kichthuoc, int gia, int baohanh, string tinhtrang, int soluong)
        {
            string query = "EXEC USP_UPDATETIVI @mstiti , @hangsx , @kichthuoc , @gia , @baohanh , @tinhtrang , @soluong";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mstivi, hang,  kichthuoc, gia, baohanh, tinhtrang, soluong });
            return result > 0;
        }
        public bool DeleteTivi(string mstivi)
        {
            string query = "EXEC USP_DELETETIVI @mstiti ";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mstivi });
            return result > 0;
        }
        public DataTable LoadListTivi()
        {
            string query = "SELECT mstivi,tenhang, kichthuoc, gia, tinhtrang ,baohanh, soluong FROM TIVI AS T, HANGTIVI AS H WHERE hangsx = mshang  AND mstivi != 'EROR (DELETED)'";
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable LoadTiviByHangSX(string hangsx, int kichthuoc)
        {
            string query = "EXEC USP_LISTTVBYHANG1 @hang = " + hangsx + " , @inch =" + kichthuoc.ToString();
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public DataTable LoadTiviByModel(string model)
        {
            string query = "EXEC USP_LISTTVBYMODEL @model  = N'" + model + "'";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public List<Tivi> searchTivi(string name)
        {
            List<Tivi> list = new List<Tivi>();

            string query = "select mstivi, tenhang, kichthuoc, gia, tinhtrang, baohanh, soluong from TIVI, HANGTIVI where hangsx = mshang AND mstivi != 'EROR (DELETED)' and mstivi like N'%"+name+"%'";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Tivi thuonghieu = new Tivi(item);
                list.Add(thuonghieu);
            }

            return list;
        }

        public bool UpdateSPBanById(string idtv, int soluong)
        {
            string query = "update TIVI set soluong = soluong - "+soluong.ToString()+" where mstivi = N'" + idtv + "' ";

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public int soLuongTivi(string name)
        {
            return DataProvider.Instance.GetIntValue("select soluong from tivi where mstivi = N'" + name + "'");
        }
    }
}
