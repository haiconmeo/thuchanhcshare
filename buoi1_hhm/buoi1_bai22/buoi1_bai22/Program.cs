using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int dem = 1;
            int a = 1;
            int b = 1;
            while (dem < n)
            {
                int tam = a + b;
                a = b;
                b = tam;
                dem++;
            }
            Console.Write("kq = {0}", b);
            Console.ReadKey();
        }
    }
}
