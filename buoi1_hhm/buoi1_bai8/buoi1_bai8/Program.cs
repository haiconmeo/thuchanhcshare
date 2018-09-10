using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap diem :");
            double a = Convert.ToDouble(Console.ReadLine());
             if (a >= 8 && a <= 10){
                Console.WriteLine("A");
            }
            if (a >= 6.5 && a < 8)
            {
                Console.WriteLine("B");
            }
            if (a >= 5.5 && a < 6.5)
            {
                Console.WriteLine("C");
            }
            if (a >= 4 && a < 5.5)
            {
                Console.WriteLine("D");
            }
            if (a >= 0 && a < 4)
            {
                Console.WriteLine("F");
            }
            Console.ReadKey();

        }
    }
}
