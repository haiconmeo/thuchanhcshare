using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so tien cua chuyen:");
            int dola = 0;
            dola= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("so tien sau khi doi :{0}", dola*22000);
            Console.ReadKey();
        }
    }
}
