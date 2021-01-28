using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._1_NhapXuatTuBanPhim
{
    class Program
    {
        /*
         * Bài 1.1 Nhập xuất dữ liệu từ bàn phím
         *  1. Xuất dữ liệu ra màn hình
         *      + Console.WriteLine(); Ghi xong thì xuống dòng
         *          + Phím tắt : cw + tab
         *          
         *      + Console.Write(); Ghi xong thì không xuống dòng
         *  
         *  2. Nhập dữ liệu từ bàn phím:
         *      + Console.Read();       Đọc 1 ký tự từ bàn phím
         *      + Console.ReadLine();   Đọc nhiều ký tự từ bàn phím
         *      + Console.ReadKey();    Đọc một ký tự từ bàn phím nhưng trả về kiểu ConsoleKeyInfo
         */

        static void Main(string[] args)
        {
            /*
             * 1. Xuất dữ liệu ra màn hình
             */

            Console.WriteLine("Chao cac ban den voi C#1");

            Console.Write("Chuc mung nam moi ");
            Console.Write("2021");

            Console.WriteLine();

            /********************************************************************************************************/

            /// Cộng dồn chuỗi in ra màn hình
            /// C1: cộng chuỗi
            Console.WriteLine("Truong Cao dang " + "FPT " + "Polytechnic");

            /// C2: Chỉ định vị trí in ra giá trị trong chuỗi bằng cú pháp {<số đếm>}.
            /// Console.WriteLine("{0} {1} {2} {...}", <giá trị 0>, <giá trị 1>, <giá trị 2>, <giá trị n>);
            /// <giá trị 0> sẽ được điền tương ứng vào vị trí số 0 tương tự như vậy cho các giá trị còn lại.
            Console.WriteLine("Truong Cao dang {0} {1}", "FPT", "Polytechnic");

            /// C3: Sử dụng String Interpolation
            /// Sử dụng ký tự: $
            /// Cú pháp: $"{gia tri 1} {gia tri 2} {gia tri n}";
            string s1 = "FPT";
            Console.WriteLine($"Truong Cao dang {s1} {"Polytechnic"}");

            Console.WriteLine();

            /********************************************************************************************************/

            /*
             * 2. Nhập dữ liệu từ bàn phím:
             */

            Console.WriteLine("Nhap du lieu tu ban phim:");

            /// Đọc 1 ký tự đầu tiên từ bàn phím bằng lệnh Console.Read() cho đến khi gặp ký tự xuống dòng(Enter) 
            /// và trả về 1 số nguyên là mã ASCII của ký tự đó.
            Console.WriteLine("Console.Read:" + Console.Read());

            /// Đọc dữ liệu từ bàn phím bằng lệnh Console.ReadLine() cho đến khi gặp ký tự xuống dòng(Enter) thì dừng.
            /// Sau đó in giá trị đã nhập ra màn hình.
            Console.WriteLine("Console.ReadLine: " + Console.ReadLine());

            /// Đọc một ký tự từ bàn phím, trả về kiểu ConsoleKeyInfo
            /// Sau đó in giá trị đã nhập ra màn hình.
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            Console.WriteLine("Console.ReadKey: " + consoleKeyInfo.KeyChar);

            // Dừng màn hình để xem kết quả
            Console.ReadKey();
        }
    }
}
