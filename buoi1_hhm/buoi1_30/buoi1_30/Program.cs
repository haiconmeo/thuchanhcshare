using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_30
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("nhap so luong phan tu");
            int n =  Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]", i);
                int k= Convert.ToInt32(Console.ReadLine());
                sum += k;
            }
            Console.Write("tong la :{0}", sum);
            Console.ReadKey();

            
        }
    }
}
