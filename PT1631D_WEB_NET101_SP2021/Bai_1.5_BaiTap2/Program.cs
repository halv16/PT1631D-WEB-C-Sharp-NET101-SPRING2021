using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._5_BaiTap2
{
    class Program
    {
        /*
         * Nhập vào 2 số a, b từ bàn phím
            -	In ra số dư %
            -	In ra số lớn hơn trong 2 số (Math.Max())
         */
        static void Main(string[] args)
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            
            int c = a % b;
            int max = Math.Max(a, b);

            Console.WriteLine("So du: " + c);
            Console.WriteLine("Max: " + max);

            Console.ReadLine();
        }
    }
}
