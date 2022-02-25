using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau2
{
    public class soHoanHao
    {
        public static bool kiemTraSHH(int n)
        {
            if (n == 1) return true;

            int tong = 0;
            for (int i = 1;  i <= n / 2; i++)
                if (n % i == 0)
                    tong += i;
            if (tong == n)
                return true;
            return false;
        }

        public static String showSHH(int n)
        {
            String kqua = "";
            for (int i = 1; i < n; i++)
                if (kiemTraSHH(i))
                    kqua = kqua + " " + i.ToString();
            return kqua;
        }
    }
}
