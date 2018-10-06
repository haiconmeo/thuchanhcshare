using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so luong phan tu :");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            for (int i =0;i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            Array.Sort(a);
            Array.Reverse(a);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            Console.ReadKey();


        }
    }
}
