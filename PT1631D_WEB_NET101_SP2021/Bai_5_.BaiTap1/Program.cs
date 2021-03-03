using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_.BaiTap1
{
    class Program
    {
        /*
         * Khai báo class Person: Ten, Ho, Tuoi - InThongTin()
            Class Student kế thừa từ class Person: MaSV, DiemTB - InThongTin()

            Nhập vào 1 mảng n đối tượng class Student
            In mảng.

            - Tìm SV theo mã sinh viên
            - Tìm theo tên gần đúng
            - Sắp xếp sinh viên theo điểm.

            - Thêm, sửa, xóa student theo mã.
         */

        static void Main(string[] args)
        {
            //var lst = new List<Student>();

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool condition = true;
            ServiceStudent service = new ServiceStudent();

            while (condition)
            {
                Menu(service, ref condition);
            }

            Console.ReadLine();
        }

        private static void Menu(ServiceStudent service, ref bool condition)
        {
            Console.WriteLine(" ________________________________");
            Console.WriteLine("|__________MENU__________________|");
            Console.WriteLine("| 1. Thêm sửa, xóa               |");
            Console.WriteLine("| 2. Thêm sẵn 5 sv vào mảng      |");
            Console.WriteLine("| 3. In mảng                     |");
            Console.WriteLine("| 4. Tìm SV theo mã sinh viên    |");
            Console.WriteLine("| 5. Tìm theo tên gần đúng       |");
            Console.WriteLine("| 6. Sắp xếp sinh viên theo điểm.|");
            Console.WriteLine("| 7. Phân chia danh sách theo giới tính.|");
            Console.WriteLine("| 0. Thoát                       |");
            Console.WriteLine("|________________________________|");

            Console.Write("Mời bạn chọn menu: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("|_____________________________|");
                    Console.WriteLine("| Thêm sửa, xóa               |");
                    Console.WriteLine("| 1. Thêm                     |");
                    Console.WriteLine("| 2. Sửa                      |");
                    Console.WriteLine("| 3. Xóa                      |");
                    Console.WriteLine("| 4. Thoát                    |");
                    Console.WriteLine("|_____________________________|");

                    Console.Write("Mời bạn chọn menu: ");
                    int menu1 = int.Parse(Console.ReadLine());

                    switch (menu1)
                    {
                        case 1:
                            service.ThemSinhVien();

                            break;

                        case 2:
                            service.SuaSinhVien();
                            break;
                        case 3:
                            service.XoaSinhVien();
                            break;

                        default:
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("| 2. Thêm sẵn 5 sv vào mảng      |");

                    service.ThemSanSinhVien();
                    break;

                case 3:
                    Console.WriteLine("| 3. In mảng                     |");
                    service.InMang();
                    break;

                case 4:
                    Console.WriteLine("| 4. Tìm SV theo mã sinh viên    |");
                    service.TimTheoMaSV();
                    break;

                case 5:
                    Console.WriteLine("| 5. Tìm theo tên gần đúng       |");
                    service.TimTheoTen();
                    break;

                case 6:
                    Console.WriteLine("| 6. Sắp xếp sinh viên theo điểm.|");
                    service.SapXepTheoDiem();
                    break;

                case 7:
                    Console.WriteLine("| 7. Phân chia danh sách theo giới tính.|");
                    service.InTheoGioiTinh();
                    break;

                default:
                    condition = false;

                    Console.WriteLine("Thoát chương trình!!!");
                    Console.WriteLine("Tạm biệt và hẹn gặp lại!!!");
                    break;
            }

            Console.WriteLine();
        }
    }
}
