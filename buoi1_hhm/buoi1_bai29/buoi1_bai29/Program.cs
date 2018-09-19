using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai29
{
    class Program
    {
        static double tong(double a,double b)
        {
            return a + b;
        }
        static double tru(double a, double b)
        {
            return a - b;
        }
        static double nhan(double a, double b)
        {
            return a * b;
        }
        static double chia(double a, double b)
        {
            return a / b;
        }
        static bool pt(char c)
        {
            if ((c == '+') || (c == '-') || (c == '*') || (c == '/'))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("nhap bieu thuc :");
            string a = Console.ReadLine();
            int ptt = 0;
            char cc;
            for (int i = 0; i < a.Length; i++)
            {
                if (pt(a[i]))
                {
                    ptt = i;
                    cc = a[i];

                }
            }
            string s1 = a.Substring(0,ptt);
            string s2 = a.Substring(ptt + 1);
            double a1 = Convert.ToDouble(s1);
            double a2 = Convert.ToDouble(s2);
            if (a[ptt] == '+')
            {
                Console.WriteLine(a + "="+tong(a1,a2));
            }

            if (a[ptt] == '-') Console.WriteLine(a + "=" + tru(a1, a2));
            if (a[ptt] == '*') Console.WriteLine(a + "=" + nhan(a1, a2));
            if (a[ptt] == '/') Console.WriteLine(a + "=" + chia(a1, a2));

            Console.ReadKey();

        }
    }
}
