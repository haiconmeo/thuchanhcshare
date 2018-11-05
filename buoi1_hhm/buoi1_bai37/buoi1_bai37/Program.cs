using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buoi1_bai37
{
    class Program
    {
        public static void Main()
        {

            
            int i, n, p, x;
            int[] arr1 = new int[100];
            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("mang ban dau:\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            /* di chuyen vi tri cac phan tu ben phai cua mang */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* chen gia tri vao vi tri da cho */
            arr1[p - 1] = x;


            Console.Write("\n\nSau khi chen phan tu:\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");     

            Console.ReadKey();
        } 
    }
}