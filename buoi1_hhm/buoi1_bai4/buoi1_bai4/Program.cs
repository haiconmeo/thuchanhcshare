using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            Console.WriteLine("nhap so c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ket qua :{0}",(c*1.8)+32);
            Console.ReadKey();
        }
    }
}
