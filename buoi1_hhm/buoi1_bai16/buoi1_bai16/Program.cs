using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so :");
            int a = Convert.ToInt32(Console.ReadLine());
            int tich = 1;
            for (int i = 1; i <= a; i++)
            {
                tich *= i;
            }
            Console.WriteLine("ket qua la :{0}", tich);
            Console.ReadKey();
        }
    }
}
