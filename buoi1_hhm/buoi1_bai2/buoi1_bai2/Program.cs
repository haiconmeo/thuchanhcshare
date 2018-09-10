using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("nhap a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("trung binh :{0}", (a + b + c) / 3.0);
            Console.ReadKey();
        }
    }
}
