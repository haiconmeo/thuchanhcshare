using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so :");
            int so = Convert.ToInt32(Console.ReadLine());
            if (so % 2 == 0)
            {
                Console.WriteLine("la so chan");
            }
            else
            {
                Console.WriteLine("la so le");
            }
            Console.ReadKey();
        }
    }
}
