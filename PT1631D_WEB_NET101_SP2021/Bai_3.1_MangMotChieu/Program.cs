using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._1_MangMotChieu
{
    class Program
    {
        /*
         * Phần 1: Mảng 1 chiều - Array
         *
         *  1. Định nghĩa: Mảng dùng để lưu trữ nhiều phần tử có cùng kiểu dữ liệu (Biến dùng để lưu trữ 1 giá trị có cùng kiểu dữ liệu).
         *          - Để truy xuất (để lấy giá trị) các phần tử thì cần phải biết chỉ số(index). Index là số nguyên và bắt đầu từ 0 1 2 3....
         *
         *  2. Khai báo 1 mảng trong Csharp:
         *          - Cách 1:
         *              <Kiểu dữ liệu>[] arr<Tên Mảng>;
         *              arr<Tên Mảng> = new <Kiểu dữ liệu>[length];//Khởi tạo mảng có kích thước.
         *          - Cách 2:
         *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[length];
         *
         *          - Cách 3:
         *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new <Kiểu dữ liệu>[] {value1,value2..,valuen};//Khởi tạo mảng kiểu tường minh.
         *
         *              <Kiểu dữ liệu>[] arr<Tên Mảng> = new [] {value1,value2..,valuen};//Khởi tạo kiểu ngầm định
         *
         *  3. Truy xuất các phần tử trong mảng
         *      - Gán giá trị cho mảng:
         *           <tên mảng>[index] = Giá trị cần gán.
         *
         *     - Lấy giá trị trong mảng:
         *          <tên mảng>[index] = Giá trị của mảng tại vị trí.
         *      Lưu ý: Để lấy nhiều giá trị trong mảng xuất ra cần sử dụng vòng lòng.
         *
         *  4. Kích thước hoặc độ dài của mảng sử dụng thuộc tính Length.
         *      <tên mảng>.Length = kích thước mảng có kiểu số nguyên
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // khai báo mảng số nguyên có 4 phần tử
            int[] arrNumber = new int[4];
            // gán giá trị cho phần tử trong mảng
            arrNumber[0] = 1;
            arrNumber[1] = 2;
            arrNumber[2] = 3;
            arrNumber[3] = 4;

            // In 1 giá trị
            Console.Write("Giá trị khởi tạo tại vị trí 0: ");
            Console.WriteLine(arrNumber[0] + "\t"); // in phần tử ở vị trí 0 của mảng
            Console.WriteLine();

            // Nhập dữ liệu vào mảng
            // Sử dụng for:
            Console.WriteLine("Nhap mang so nguyen co 4 phan tu: ");
            for (int i = 0; i < arrNumber.GetLength(0); i++)
            {
                Console.Write("Gia tri tai vi tri {0} = ", i);
                arrNumber[i] = int.Parse(Console.ReadLine());
            }

            // In toàn bộ mảng
            // Sử dụng for:
            Console.WriteLine("In mang su dung for:");
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.Write(arrNumber[i] + "\t");
            }
            Console.WriteLine();

            //Sử dụng foreach:
            Console.WriteLine("In mang su dung foreach:");
            foreach (int k in arrNumber)
            {
                Console.Write(k + "\t");
            }
            Console.WriteLine();

            Array.Sort(arrNumber); // sắp xếp mảng tăng dần
            Array.Reverse(arrNumber); // đảo ngược thứ tự của mảng

            int n = Array.IndexOf(arrNumber, 1); // trả về vị trí đầu tiên của phần tử có giá trị = 1 trong mảng. Nếu không tìm thấy trả về -1.
            Console.WriteLine("Vị trí của phần tử có giá trị = 1 là: {0}", n);


            Console.ReadLine();
        }
    }
}
