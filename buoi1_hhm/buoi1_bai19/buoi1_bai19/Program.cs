using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double ketqua = 0;
            for(int i = 1; i <= n; i++)
            {
                ketqua += Math.Pow(-1.0, (n - 1) / 2.0); 
            }
            Console.WriteLine("ketqua {0}", 4 * ketqua);
            Console.ReadKey();
        }
    }
}
