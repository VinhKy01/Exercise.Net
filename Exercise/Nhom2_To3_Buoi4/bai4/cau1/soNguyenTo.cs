using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau1
{
    public class soNguyenTo
    {
        public static bool kiemTraSNT(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static String showSNT(int n)
        {
            String kqua ="";
            for (int i = 1; i < n; i++)
                if (kiemTraSNT(i))
                    kqua = kqua + " " + i.ToString();
            return kqua;
        }
    }
}
