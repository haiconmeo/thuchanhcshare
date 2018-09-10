using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai15
{
    class Program
    {
        static bool nt(int a)
        {
            if (a < 2) return false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                        
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so :");
            int a = Convert.ToInt32(Console.ReadLine());
            if (nt(a))
            {
                Console.WriteLine("la so nguyen to");
            }
            else Console.WriteLine("khong phai");
            Console.ReadKey();
        }
    }
}
