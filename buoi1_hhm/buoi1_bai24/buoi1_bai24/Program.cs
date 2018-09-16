using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai24
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 30; i++)
            {
                int k;
                for(int j = 1; j < 30; j++)
                {
                    k = i * i + j * j;
                    if (Convert.ToInt32(Math.Sqrt(k)) * Convert.ToInt32(Math.Sqrt(k)) == k && (Math.Sqrt(k) <=30))
                    {
                        if (i<=j)
                        Console.WriteLine("{0}^2*{1}^2=={2}^2", i, j, Math.Sqrt(k));
                    }
                }
            }
            Console.ReadKey();
         
        }
    }
}
