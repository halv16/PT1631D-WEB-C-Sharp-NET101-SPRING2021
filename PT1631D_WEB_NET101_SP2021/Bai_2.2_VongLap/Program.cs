using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._2_VongLap
{
    class Program
    {
        /*
         * Vòng lặp: là thực hiện lặp đi lặp lại 1 hoặc nhiều câu lệnh khi thỏa mãn điều kiện.
         * Các loại vòng lặp:
         * - For
         * - While
         * - Do - While
         */
        static void Main(string[] args)
        {
            /*
             * Vòng lặp For
             * Cú pháp:
             *        for (<khởi tạo>; <điều kiện lặp>; <bước nhảy>)
             *        {
             *              // khối lệnh được lặp lại khi <điều kiện lặp> là true;
             *        }
             * - <khởi tạo>: dùng để khởi tạo giá trị
             * - <điều kiện lặp>: 
             *      + nếu điều kiện là true thì sẽ thực hiện khối lệnh, sau đó đến <bước nhảy>, sau đó lại kiểm tra <điều kiện lặp>
             *      + nếu điều kiện là false thì kết thúc vòng lặp.
             * - <bước nhảy>: dùng để thay đổi giá trị vòng lặp
             */

            // In ra các số từ 0 - 9
            //int k = 0;
            //for (k = 0; k < 10; k++)
            //{
            //    Console.WriteLine(k);
            //}

            /*=====================================================================================================*/

            /*
             * Vòng lặp While
             * Cú pháp:
             *        while (<điều kiện lặp>)
             *        {
             *              // khối lệnh được lặp lại khi <điều kiện lặp> là true;
             *        }   
             */
            //while (k < 10)
            //{
            //    Console.WriteLine(k);
            //    k++; // tăng giá trị của k thêm 1:   k = k + 1;
            //}

            /*=====================================================================================================*/

            /*
             * Vòng lặp Do - While
             * Cú pháp:
             *        do
             *        {
             *              // khối lệnh được lặp lại khi <điều kiện lặp> là true;
             *        } while (<điều kiện lặp>);
             *        
             *        
             * Khác nhau giữa vòng lặp While và Do - While
             * - While: sẽ kiểm tra <điều kiện lặp> sau đó mới thực hiện khối lệnh lặp.
             * - Do - While: sẽ thực hiện khối lệnh lặp trước sau đó mới kiểm tra <điều kiện lặp>. 
             *               vì vậy khối lệnh lặp luôn được thực hiện ít nhất 1 lần
             */

            // BT: In ra bảng cửu chương của số 9
            // k = 1;


            //do
            //{
            //    Console.WriteLine($"9 x {k} = {9 * k}");
            //    continue;

            //    k++;


            //} while (k <= 10);

            // BT: Viết chương trình nhập vào điểm của sinh viên.
            // Nếu điểm là hợp lệ thì in ra màn hình, ngược lại thì yêu cầu nhập lại.
            // điểm hợp lệ (0 <= điểm <= 10)

            //double diem;
            //do
            //{
            //    Console.WriteLine("Nhap diem: ");
            //    diem = double.Parse(Console.ReadLine());

            //    //if (diem >= 0 && diem <= 10)
            //    //    break;
            //} while (diem < 0 || diem > 10);

            //Console.WriteLine("Diem: " + diem);




            // Nhập vào 3 số a, b, c. In ra số lớn nhất
            int a = 5;
            int b = 7;
            int c = 1;

            ////int max = Math.Max(Math.Max(a, b), c);
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;


            Console.ReadLine();
        }
    }
}
