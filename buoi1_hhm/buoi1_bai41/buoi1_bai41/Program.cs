using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace buoi1_bai41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int  j = 0;
            int k = n - 1;
            bool ff = true;
            while (j <= k)
            {
                if (arr[j] != arr[k])
                {
                    ff = false;
                    break;
                }
                j++;
                k--;
            }
            if(ff==false) Console.WriteLine("Mang Khong doi xung");
            else Console.WriteLine("Mang doi xung");
            Console.ReadKey();
        }
    }
}
