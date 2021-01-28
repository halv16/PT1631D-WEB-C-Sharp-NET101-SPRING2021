using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._3_ChuyenDoiKieuDuLieu
{
    class Program
    {
        /*
         * Bài 1.3 Chuyển đổi kiểu dữ liệu
         */
        static void Main(string[] args)
        {
            /// 1. Chuyển đổi kiểu ngầm định (implicit)
            int i = 5;
            double d = i;

            /// 2. Chuyển đổi kiểu tường minh (explicit)
            // + cast kiểu dữ liệu
            // Cú pháp:  (<kiểu dữ liệu>) <biến cần ép kiểu>
            float f = 5.9f;
            int k = (int)f; // k = 5;

            // + Sử dụng phương thức Parse()
            int a = int.Parse("10"); // a = 10;
            double b = double.Parse("10.5"); // b = 10.5;

            // + Sử dụng lớp hỗ trợ Convert
            int a1 = Convert.ToInt32(10.6); // a1 = 11;
            double b1 = Convert.ToDouble("10.5"); // b1 = 10.5;


            // Chuyển đổi kiểu dữ liệu để in ra ký tự đã nhập bằng lệnh Console.Read()
            Console.WriteLine("Nhap du lieu tu ban phim:");
            int c = Console.Read();
            Console.WriteLine(c); // Mã ASCII
            Console.WriteLine((char)c); // In ký tự đã nhập


            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
