using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double tam = a;
            if (b > tam) tam = b;
            if (c > tam) tam = c;
            Console.WriteLine("so lon nhat la :{0}", tam);
            Console.ReadKey();
        }
    }
}
