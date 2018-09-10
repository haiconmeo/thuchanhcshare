using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a=");
            int a = Convert.ToInt32(Console.ReadLine());
            string x = "";
            while (a != 0)
            {
                x += Convert.ToString(a % 2);

                a /= 2;
            }
            Char[] xx = x.ToCharArray();
            Array.Reverse(xx);
            string xxx = new string(xx);
            Console.WriteLine("so nhi phan la :{0}",xxx);
            Console.ReadKey();
        }
    }
}
