using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Thong tin hinh chu nhat: ");
            ChuNhat cn = new ChuNhat(2, 4);
            cn.xuat();
            Console.WriteLine("-----Thong tin hinh vuong:");
            ChuNhat vu = new Vuong(4);
            vu.xuat();
            Console.ReadLine();
        }
    }
}
