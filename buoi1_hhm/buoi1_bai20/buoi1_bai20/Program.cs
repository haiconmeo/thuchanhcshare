using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai20
{
    class Program
    {
        static int gt(int n)
        {
            int tich = 1;
            for(int i = 1; i <= n; i++)
            {
                tich *= i;
            }
            return tich;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap x:");
            double x = Convert.ToDouble(Console.ReadLine());

            double kq = 0;
            for(int i = 1; i <= n; i++)
            {
                kq += Math.Pow(x, i) / gt(i);
            }
            Console.WriteLine("ket qua:{0}", kq);
            Console.ReadLine();
        }
    }
}
