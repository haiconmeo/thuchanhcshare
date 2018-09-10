using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) //vòng lặp này viết ra từng dòng của tam giác
            {
                for (int j = n - 1; j > i; j--)   //vòng này tạo các dấu cách trống  trên 1 dòng để kí tự * viết xa lề
                    Console.Write(" ");
                for (int j = 0; j < i * 2 + 1; j++)  //vòng này viết số kí tự sao trên 1 dòng
                    Console.Write("*");
                Console.WriteLine();    //xuống dòng, cái này quan trọng
            }
            Console.ReadKey();
        }
    }
}
