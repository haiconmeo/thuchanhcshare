using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("nhap a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap c:");
            c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if(delta == 0)
            {
                Console.WriteLine("phuong trinh co mot nghiem {0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("phuong trinh co 2 nghiem rieng biet x1={0}  x2={1}", -b - Math.Sqrt(delta) / (2 * a), -b + Math.Sqrt(delta) / (2 * a));
            }
            Console.ReadKey();
        }
    }
}
