using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dooj;
            Console.WriteLine("nhap so do:");
            dooj = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}", (2 * Math.PI )*dooj / 360);

            Console.ReadLine();
        }
    }
}
