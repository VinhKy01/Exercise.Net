using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cau3
{
    public class PhanSo
    {
        int tu, mau;

        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        public int UCLN()
        {
            PhanSo a = new PhanSo(this.Tu, this.Mau);
            while (a.Tu * a.Mau != 0)
            {
                if (a.Tu > a.Mau)
                    a.Tu %= a.Mau;
                else
                    a.Mau %= a.Tu;
            }
            return a.Tu + a.Mau;
        }
        
        public void rutGon() {
            int ucln = this.UCLN();
            this.Tu = this.Tu / ucln;
            this.Mau = this.Mau / ucln;
        }

        public static PhanSo Tong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = ps1.Tu * ps2.Mau + ps2.Tu * ps1.Mau;
            kq.Mau = ps1.Mau * ps2.Mau;
            kq.rutGon();
            return kq;
        }

        public static PhanSo Hieu(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = ps1.Tu * ps2.Mau - ps2.Tu * ps1.Mau;
            kq.Mau = ps1.Mau * ps2.Mau;
            kq.rutGon();
            return kq;
        }

        public static PhanSo Tich(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = ps1.Tu *ps2.Tu;
            kq.Mau = ps1.Mau * ps2.Mau;
            kq.rutGon();
            return kq;
        }

        public static PhanSo Thuong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo kq = new PhanSo();
            kq.Tu = ps1.Tu * ps2.Mau;
            kq.Mau = ps1.Mau * ps2.Tu;
            kq.rutGon();
            return kq;
        }
    }
}
