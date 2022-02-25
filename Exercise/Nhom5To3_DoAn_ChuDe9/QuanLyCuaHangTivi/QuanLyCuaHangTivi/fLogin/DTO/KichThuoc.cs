using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class KichThuoc
    {
        int kichthuoc;
        public KichThuoc(int kichthuoc)
        {
            this.Kichthuoc = kichthuoc;
        }
        public KichThuoc(DataRow row)
        {
            this.Kichthuoc = (int)row["kichthuoc"];
        }
        public int Kichthuoc { get => kichthuoc; set => kichthuoc = value; }
    }
}
