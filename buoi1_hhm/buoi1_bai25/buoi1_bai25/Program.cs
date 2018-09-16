using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap chuoi :");
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            Array.Reverse(a);
            string s1 = new string(a);
            Console.WriteLine("chuoi dao nguoc :"+s1);
            Console.ReadKey();

        }
    }
}
