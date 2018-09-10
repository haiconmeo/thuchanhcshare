using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ket qua la :{0}",n*(n+1)/2);
            Console.ReadKey();
        }
    }
}
