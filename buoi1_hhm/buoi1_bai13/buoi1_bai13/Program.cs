using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a:");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int max = -1;
            while (a != 0)
            {
                if (a % 10 > max) max = a % 10;
                a /= 10;
            }
            Console.WriteLine("so lon nhat la :{0}", max);
            Console.ReadKey();
        }
       
    }
}
