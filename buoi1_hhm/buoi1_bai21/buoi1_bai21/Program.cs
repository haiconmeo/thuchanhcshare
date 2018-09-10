using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int tam = a;
            a = b;
            b = tam;
            Console.WriteLine("sao khi hoan vi a= {0}  b={1} ", a, b);
            Console.ReadKey();
        }
    }
}
