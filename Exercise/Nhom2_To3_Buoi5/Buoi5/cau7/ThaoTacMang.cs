using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau7
{
    public class ThaoTacMang
    {
        public static String chuanHoaChuoi(String t)
        {
            t.Trim();
            while (t.IndexOf("  ") != -1)
            {
                t = t.Replace("  ", " ");
            }
            return t;
        }

        public static int tong(String[] a)
        {
            int tong = 0;
            foreach(var i in a)
            {
                tong += Int32.Parse(i);
            }
            return tong;
        }

        public static int tongChan(String[] a)
        {
            int tong = 0;
            foreach (var i in a)
            {
                if(Int32.Parse(i)%2 == 0)
                    tong += Int32.Parse(i);
            }
            return tong;
        }

        public static int tongLe(String[] a)
        {
            int tong = 0;
            foreach (var i in a)
            {
                if (Int32.Parse(i) % 2 != 0)
                    tong += Int32.Parse(i);
            }
            return tong;
        }

        public static int timMin(String[] a)
        {
            int min = Int32.Parse(a[0]);
            foreach(var i in a)
            {
                if (min > Int32.Parse(i))
                    min = Int32.Parse(i);
            }
            return min;
        }

        public static int timMax(String[] a)
        {
            int max = Int32.Parse(a[0]);
            foreach (var i in a)
            {
                if (max < Int32.Parse(i))
                    max = Int32.Parse(i);
            }
            return max;
        }

        public static void sapXepTang(String[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    int x = Int32.Parse(a[i]);
                    int y = Int32.Parse(a[j]);
                    if( x > y)
                    {
                        x = x - y;
                        y = x + y;
                        x = y - x;
                    }
                    a[i] = x.ToString();
                    a[j] = y.ToString();
                }
        }

        public static void sapXepGiam(String[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                for (int j = i + 1; j < a.Length; j++)
                {
                    int x = Int32.Parse(a[i]);
                    int y = Int32.Parse(a[j]);
                    if (x < y)
                    {
                        x = x - y;
                        y = x + y;
                        x = y - x;
                    }
                    a[i] = x.ToString();
                    a[j] = y.ToString();
                }
        }

        public static void thayThe(String[] a, int vt, int gt)
        {
            for(int i = 0; i < a.Length; i++)
                if(vt == i)
                {
                    a[i] = gt.ToString();
                }
        }

    }
}
