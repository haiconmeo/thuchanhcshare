using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a:");
            string a = Console.ReadLine();
            char[] x = a.ToCharArray(); 
            foreach(char i in x)
            {
                if(Convert.ToInt32(i) < 97)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
