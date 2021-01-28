using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2_ArrayList
{
    class Program
    {
        /*
         *  ArrayList
         *  Định nghĩa: Là một Collections giúp lưu trữ và quản lý một
                        danh sách các đối tượng theo kiểu mảng (truy
                        cập các phần tử bên trong thông qua chỉ số
                        index)
            Ưu điểm:    Cho phép thêm hoặc xoá các phần tử một cách
                        linh hoạt và có thể tự điều chỉnh kích cỡ một
                        cách tự động.
            Sử dụng:    Để sử dụng các Collections trong .NET ta cần
                        thêm thư viện System.Collections
            Từ khóa: ArrayList arrLst<Tên> =  new ArrayList();
         */
        /*
           * A. CÁC PHƯƠNG THỨC TRONG ArrayList
           * 1. Add(object Value): Thêm đối tượng vào cuối.
           * 2. AddRange(ListObject): Thêm danh danh sách vào cuối.
           * 3. BinarySearch(object Value): Tìm kiếm value trong danh sách. Nếu tìm thấy sẽ trả lại index và không tìm thấy thì trả lại index âm. Để sử dụng danh sách phải sắp xếp.
           * 4. Clear(): Xóa tất cả các phần tử.
           * 5. Clone(): Tạo 1 bản sao của danh sách đó.
           * 6. Contains(object Value): Kiểm tra đối tượng value có tồn tại trong danh sách hay không? - Trả ra true hoặc false
           * 7. Getrange(int StartIndex, int EndIndex): Trả về 1 danh sách bao gồm các phần tử từ điểm được chỉ định.
           * 8. IndexOf(object Value): Trả về vị trí đầu tiên xuất hiện trong danh sách và nếu không tìm thấy trả về -1.
           */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            //// Khai báo
            //ArrayList arrayList = new ArrayList();

            //// thêm phần tử vào array list
            //arrayList.Add(1);
            ////arrayList.Add("a");
            ////arrayList.Add(true);

            //var arr = new[] { 1, 4, 3 };
            //arrayList.AddRange(arr);

            //// xóa phần từ đầu tiên có giá trị = 1
            //arrayList.Remove(1);

            //// xóa phần tử có index = 1 (phân tử thứ 2 của arrayList)
            //arrayList.RemoveAt(1);

            //// sắp xếp mảng
            //arrayList.Sort();

            //// In mảng
            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.Write(arrayList[i] + "\t");
            //}

            /*
             * BT: Dùng ArrayList để nhập vào 1 mảng số nguyên dương.
             * Nếu nhập giá trị <= 0 thì kết thúc
             * - in mảng ra theo thứ tăng dần
             * - in các số chia hết cho 3 của mảng
             */

            ArrayList arrLstTemp = new ArrayList();
            while (true)
            {
                int i = int.Parse(Console.ReadLine());
                if (i > 0)
                {
                    arrLstTemp.Add(i);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Mang tang dan:");
            arrLstTemp.Sort(); // sắp xếp mảng tăng dần.
            foreach (var item in arrLstTemp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Mang so chia het cho 3:");
            for (int i = 0; i < arrLstTemp.Count; i++)
            {
                int k = Convert.ToInt32(arrLstTemp[i]);
                if (k % 3 == 0)
                {
                    Console.WriteLine(k);
                }
            }

            // camelCase: firstName, tenSinhVien
            // snakeCase (underscore): first_name, ten_sinh_vien
            // PascalCase: FirstName, TenSinhVien

            List<int> lstNumbers = new List<int>();
            // thêm phần tử vào list
            lstNumbers.Add(8);
            lstNumbers.Add(1);

            // chèn giá trị vào phần tử thứ 0
            lstNumbers.Insert(0, 1);

            // gán giá trị cho phần tử thứ 1
            lstNumbers[1] = 0;

            lstNumbers.Sort(); // sắp xếp mảng
            lstNumbers.Reverse();
            lstNumbers.Clear(); // xóa hết phần tử trong mảng

            // In mảng
            foreach (var item in lstNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
