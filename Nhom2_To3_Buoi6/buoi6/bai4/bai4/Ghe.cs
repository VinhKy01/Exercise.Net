using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau6._4
{
    public class Ghe
    {
        public static int w = 60;
        public static int h = 60;
        int id;
        string name, status;

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }

        public Ghe(int id, string status, string name)
        {
            this.Id = id;
            this.Status = status;
            this.Name = name;
        }


    }
}
