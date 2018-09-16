using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao xau:");
            string a = Console.ReadLine();
            char [] s = a.ToCharArray();
            s[0] = Convert.ToChar(Convert.ToInt32(s[0]) - 32);
            for (int i = 1; i < s.Length-1; i++)
            {
                if (s[i] == ' ')
                {
                    s[i+1] = Convert.ToChar(Convert.ToInt32(s[i+1]) - 32);
                }
            }
            string xx = new string(s);
            Console.Write(s);
            Console.ReadKey();

        }
    }
}
