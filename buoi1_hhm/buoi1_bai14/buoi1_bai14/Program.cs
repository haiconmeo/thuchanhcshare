using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so :");
            string a = Console.ReadLine();
            char[] x = a.ToCharArray();
            Array.Reverse(x);
            string xx = new string(x);
            Console.WriteLine("so sau khi dao:{0}",xx);
            Console.ReadKey();
        }
    }
}
