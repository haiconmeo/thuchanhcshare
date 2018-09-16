using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap xau");
            string s = Console.ReadLine();
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    Console.Write(s[i]);
                }
                else Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
