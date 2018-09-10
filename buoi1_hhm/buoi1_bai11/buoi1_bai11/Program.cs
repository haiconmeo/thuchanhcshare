using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai11
{
    class Program
    {
        static int  ucln(int a,int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
                
            }
            return a;
        }
        static int bcnn(int a,int b)
        {
            return (a * b) / ucln(a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("uoc chung lon nhat la :{0}", ucln(a, b));
            Console.WriteLine("boi chung nho nhat  la :{0}", bcnn(a, b));
            Console.ReadKey();
        }
    }
}
