using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buoi1_bai40
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, x;
            int[] a = new int[100];
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (a[i] > x)
                {
                    for (int j = n; j > i; j--) a[j] = a[j - 1];
                    a[i] = x;
                    break;
                }
                else a[n] = x;
            }
            Console.Write("\n\nSau khi chen phan tu:\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", a[i]);
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
