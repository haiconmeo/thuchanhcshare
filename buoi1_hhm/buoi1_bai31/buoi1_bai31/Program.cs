using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai31
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = -9999999;
            Console.Write("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("nhap a[{0}]:",i);
                int k = Convert.ToInt32(Console.ReadLine());
                if (k > max) max = k;
            }
            Console.Write("so lon nhat la :{0}", max);
            Console.ReadKey();

        }
    }
}
