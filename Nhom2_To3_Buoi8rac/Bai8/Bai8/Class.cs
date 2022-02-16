using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    public class Class
    {
        public class HinhChuNhat
        {
            float dai, rong;

            public float Dai { get => dai; set => dai = value; }
            public float Rong { get => rong; set => rong = value; }

            public HinhChuNhat(float dai, float rong)
            {
                this.dai = dai;
                this.rong = rong;
            }

            public float Tinh(float dai, float rong)
            {
                CThucHien dtHCN = new CThucHien();
                return dtHCN.DienTichHinhChuNhat(dai, rong);
               
            }
        
        }

        public class HinhVuong
        {
            float canh;

            public float Canh { get => canh; set => canh = value; }

            public HinhVuong(float canh)
            {
                this.canh = canh;
            }

            public float Tinh(float canh)
            {
                CThucHien dtHV = new CThucHien();
                return dtHV.DienTichHinhVuong(canh);
            }
        }

        public class HinhTron
        {
            float bankinh;

            public float Bankinh { get => bankinh; set => bankinh = value; }

            public HinhTron(float bankinh)
            {
                this.bankinh = bankinh;
            }


        }
    }
}
