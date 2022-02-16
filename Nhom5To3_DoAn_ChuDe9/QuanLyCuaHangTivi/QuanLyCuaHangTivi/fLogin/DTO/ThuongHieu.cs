using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fLogin.DTO
{
    public class ThuongHieu
    {
        int id;
        string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public ThuongHieu(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public ThuongHieu(DataRow row)
        {
            this.Id = (int)row["mshang"];
            this.Name = row["tenhang"].ToString(); ;
        }
    }
}
