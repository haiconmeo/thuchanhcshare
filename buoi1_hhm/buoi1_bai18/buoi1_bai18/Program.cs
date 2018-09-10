using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int ketqua = 0;
            for(int i = 1; i < n; i++)
            {
                ketqua += i * (i + 1);
            }
            Console.WriteLine("ket qua la :{0}", ketqua);
            Console.ReadKey();
        }
    }
}
