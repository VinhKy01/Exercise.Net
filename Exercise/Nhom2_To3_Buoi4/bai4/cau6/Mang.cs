using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau6
{
    public class Mang
    {
        int[] mang;

        public Mang()
        {
            mang = new int[100];
        }

        public static String chuanHoaChuoi(String t)
        {
            t.Trim();
            while (t.IndexOf("  ") != -1)
            {
                t = t.Replace("  ", " ");
            }
            return t;
        }
    }
}
