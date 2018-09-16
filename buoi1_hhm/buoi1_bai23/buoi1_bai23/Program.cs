using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai23
{
    class Program
    {
        static bool nhuan(int a)
        {
            if (a % 4 == 0)
            {
                if (a % 100 == 0)
                {
                    if (a % 400 != 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (nhuan(a))
                Console.WriteLine("la nam nhuan");
            else Console.WriteLine("khong phai");
            Console.ReadKey();
        }
    }
}
