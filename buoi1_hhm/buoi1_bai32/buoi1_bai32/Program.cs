using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("nhap a[{0}]", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write("{0}   ", a[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
