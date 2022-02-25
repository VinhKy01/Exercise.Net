using fLogin.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
        }
        public bool AddKHByPara(KhachHang k)
        {
            string query = "EXEC USP_THEMKHACHHANG @tenkh , @gioitinh , @namsinh , @diachi , @sdt ";

            int data = DataProvider.Instance.ExcuteNonQuery(query, new object[] { k.Tenkh,  k.Gioitinh,k.Namsinh, k.Diachi, k.Sdt });

            return data>0;
        }
        public int getIDLastAdd()
        {
            int result = DataProvider.Instance.GetIntValue("SELECT MAX(mskh)  FROM KHACHHANG");
            
            return result;
        }
    }
}
