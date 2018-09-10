using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so a :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap so b :");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap so c :");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a+b <=c) ||(a+c <= b)||(b+c <= a))
            {
                Console.WriteLine("khong phai tam giac dau nghe");
            }
            else
            {
                Console.WriteLine("la tam giac ");
            }
            Console.ReadKey();
        }
    }
}
