using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1_CauLenhDieuKien
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Phép toán so sánh trả về kiểu dữ liệu boolean true / false
             *      ==  : so sánh bằng
             *      >   : so sánh lớn hơn
             *      >=  : so sánh lớn hơn hoặc bằng
             *      <   : so sánh nhỏ hơn
             *      <=  : so sánh nhỏ hơn hoặc bằng
             *      !=  : so sánh khác
             */

            bool b = 4 == 5;        // false
            b = 4 <= 5;             // true
            Console.WriteLine(b);

            /*=====================================================================================================*/

            /*
             * Phép toán logic: thực hiện trên các toán hạng kiểu boolean và trả về kiểu boolean
             *      &&  : phép toán AND (và) - trả về true nếu cả 2 toán hạng đều true, ngược lại trả về false
             *      ||  : phép toán OR (hoặc) - trả về true nếu 1 trong 2 toán hạng là true, ngược lại trả về false
             *      !   : phép toán NOT (phủ định) - trả về true nếu toán hạng có giá trị false và ngược lại.
             */
            b = false && true;      // false
            b = false || true;      // true
            b = !true;              // false

            /*=====================================================================================================*/

            /*
             * Câu lệnh điều kiện:
             * 1. IF - ELSE
             * Cú pháp:
             *      if <bieu thuc dieu kien>
             *      {
             *          // khối lệnh thực hiện khi điều kiện là true
             *      }
             *      else
             *      {
             *          // khối lệnh thực hiện khi điều kiện là false
             *      }
             */

            //if (5 != 5)
            //{
            //    Console.WriteLine("Xin Chao");
            //    Console.WriteLine("Xin Chao");
            //}
            //else if (false)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("5 == 5");
            //}

            // Male, Female
            // BT 1: Nhập từ bàn phím giới tính của sv (F, M, '')
            // In ra sinh vien đó là nam, nữ, không xác định.

            string gioiTinh = Console.ReadLine();
            if (gioiTinh == "f" || gioiTinh == "F")
            {
                Console.WriteLine("Nu");
            }
            else if (gioiTinh.ToLower() == "m")
            //else if (gioiTinh.ToUpper() == "M")
            {
                Console.WriteLine("Nam");
            }
            else
            {
                Console.WriteLine("Khong xac dinh");
            }

            /*=====================================================================================================*/


            /* BT 2:
             * Nhập điểm của sinh viên
             * Nếu điểm từ 5.0 trở lên thì xếp loại Đạt,
             * ngược lại, xếp loại Không đạt
             * In xếp loại ra màn hình.
             */

            double diem = 0;
            string xepLoai;

            diem = Convert.ToDouble(Console.ReadLine());
            if (diem >= 5)
            {
                xepLoai = "Dat";
            }
            else
            {
                xepLoai = "Khong Dat";
            }

            /*
             * Toán tử 3 ngôi
             * Cú pháp: <bien> = <dieu kien> ? <gia tri 1> : <gia tri 2>;
             *      <dieu kien> == true
             *          <bien> = <gia tri 1>
             *      <dieu kien> == false
             *          <bien> = <gia tri 2>
             */
            
            xepLoai = diem >= 5 ? "Dat" : "Khong Dat";

            Console.WriteLine(xepLoai);

            /*=====================================================================================================*/

            /*
             * 2. Câu lệnh Switch case
             * Cú pháp:
             *          switch (<biểu thức>)
             *          {
             *              case <giá trị 1>:
             *                  <câu lệnh 1>;
             *                  break;
             *              case <giá trị 2>:
             *                  <câu lệnh 2>;
             *                  break;
             *              .....
             *              case <giá trị n>:
             *                  <câu lệnh n>;
             *                  break;
             *              
             *              default:
             *                  <câu lệnh mặc định>;
             *                  break;
             *          }
             * 
             *  - So sánh giá trị lần lượt từ trên xuống dưới của <biểu thức> với <giá trị i>, nếu bằng thì sẽ thực hiện <câu lệnh i>
             *  - Nếu không bằng tất cả các <giá trị i>, thì thực hiện <câu lệnh mặc định>
             */

            // BT 3:
            // Nhập vào năm, và in ra con giáp của năm đó
            // Gợi ý: lấy số dư của phép năm / 12
            // Nếu: số dư = 0 - Thân
            //              1 - Dậu
            // ..... Tuất, Hợi, Ti, Suu, Dan, Mao, Thin, Ty, Ngo, Mui = 11

            int nam = 2021;
            switch (nam % 12)
            {
                case 0:
                    Console.WriteLine("Than");
                    break;
                case 1:
                    Console.WriteLine("Dau");
                    break;
                case 2:
                    Console.WriteLine("Tuat");
                    break;
                case 3:
                    Console.WriteLine("Hoi");
                    break;
                case 4:
                    Console.WriteLine("Ti");
                    break;
                case 5:
                    Console.WriteLine("Suu");
                    break;
                
                // ........
            }


            Console.ReadKey();

        }
    }
}
