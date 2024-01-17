using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class ChuNhat
    {
        private double dai;
        private double rong;
        public ChuNhat()
        {
        }
        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double Chieudai
        {
            set { dai = value; }
            get { return dai; }
        }
        public double chieurong
        {
            set { rong = value; }
            get { return rong;  }
        }
        public virtual double TinhChuvi()
        {
            return (dai + rong) * 2;
        }
        public virtual double TinhDienTich()
        {
            return dai * rong;
        }
        public virtual void xuat()
        {
            Console.WriteLine("-Chieu dai : {0}\t- Chieu rong : {1}\t- Chu vi : {2}\t- Dien tich : {3}",
                Chieudai, chieurong, TinhChuvi(), TinhDienTich());
        }
    }
}
