using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n:");
            int n= Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.Write("nhap x:");
            double x = Convert.ToDouble(Console.ReadLine());
            bool kt = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    kt = true;
                }

            }
            if (kt)
            {
                Console.Write("co tim thay");
            }
            else
            {
                Console.Write("khong tim thay");
            }
            Console.ReadKey();
        }
    }
}
