using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
     public class Class1
    {
        private int a;

        public bool KiemTra_SHH(int a)
        {
            int tmp = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    tmp = tmp + i;
                }
            }
            if (tmp == a)
                return true;
            else
                return false;
        }
    }
}
