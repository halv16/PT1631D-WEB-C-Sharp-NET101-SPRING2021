using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._4_PhepToanSoHoc
{
    class Program
    {
        /*
         * Bài 1.4 Phép toán số học
         * 1. Toán tử số học được sử dụng để thực hiện các phép toán số học
         *      Phép cộng:              +               a + b
         *      Phép trừ:               -               a - b
         *      Phép nhân:              *               a * b
         *      Phép chia:              /               a / b
         *      Phép chia lấy dư:       %               a % b
         *  Thứ tự ưu tiên
         *       + Trong ngoặc ()
         *       + Nhân và chia
         *       + Cộng và trừ
         *       + Trái sang phải
         *       
         * 2. Hàm toán học Math: cung cấp nhiều phương thức cho phép thực hiện các hàm toán học trên kiểu số
         * 
         */
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            // Phép cộng
            Console.WriteLine(a + b);  // In ra: 13

            // Phép trừ
            Console.WriteLine(a - b);  // In ra: 7

            // Phép nhân
            Console.WriteLine(a * b);  // In ra: 30
            Console.WriteLine(a * (b + 1));  // In ra: 40

            // Phép chia
            Console.WriteLine(a / b);  // In ra: 3
            // Chuyển số chia thành số thực
            Console.WriteLine(a / (double)b);   // In ra 3.33333333333333

            // Phép chia lấy dư %
            Console.WriteLine(a % b);  // In ra 1

            // Lấy số lớn
            Console.WriteLine(Math.Max(a, b)); // In ra 10

            // Lấy số nhỏ
            Console.WriteLine(Math.Min(a, b)); // In ra 3

            Console.ReadLine();
        }
    }
}
