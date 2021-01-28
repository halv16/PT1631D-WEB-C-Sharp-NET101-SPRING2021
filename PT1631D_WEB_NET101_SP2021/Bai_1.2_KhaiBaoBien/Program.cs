using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._2_KhaiBaoBien
{
    class Program
    {
        /*
         * Bài 1.2 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến
         * được khởi tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         * 1. <Kiểu dữ liệu>
         *  + Số nguyên:sbyte, byte, long, int
         *  + Sô thực: float, double, decimal
         *  + Chuỗi hoặc ký tự: string, char
         *  + Logic: bool
         *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         * 2. <Tên Biến>
         *  + Quy tắc:
         *      - Tên biến phải có nghĩa
         *      - Có phân biệt chữ hoa chữ thường
         *      - Không bắt đầu bởi số, không dùng từ khóa
         *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
         *      
         *  + Khai báo tên biến với 2 từ trở lên:
         *      - Cách 1: normal = firstname, lastname
         *      - Cách 2: CamelCase = firstName, lastName
         *      - Cách 3: SnakeCase (underscore) = first_name, last_name
         *      - Cách 4: PascalCase = FirstName, LastName
         *      
         *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
         *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
         * 3.<Giá trị>
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
         *
         */

        static void Main(string[] args)
        {
            // Khai báo biến không khởi tạo giá trị
            string id;
            id = "HaLV16";

            //Khai báo chuỗi:
            string name = "HaLV16";

            // Khai báo số:
            int year = 2021;
            double scores = 10.0;
            float point = 5f;

            //Khai báo kiểu var;
            var name1 = "HaLV16";
            var year1 = 2021;
            var scores1 = 8.6;
        }
    }
}
