using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Vuong : ChuNhat 
    {
        private double canh;
        public Vuong()
        {
        }
        public Vuong(double canh)
        {
            this.canh = canh;
        }
        public double Canh
        {
            set { canh = value; }
            get { return canh; }
        }
        public override double TinhChuvi()
        {
            return canh * 4;
        }
        public override double TinhDienTich()
        {
            return canh * canh;
        }
    }
}
