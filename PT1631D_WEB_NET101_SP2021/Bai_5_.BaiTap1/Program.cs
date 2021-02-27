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

        // tạo 1 biến mảng toàn cục để lưu danh sách sv
        private static List<Student> list = new List<Student>();

        static void Main(string[] args)
        {
            //var lst = new List<Student>();

            Console.OutputEncoding = Encoding.UTF8;

            bool condition = true;
            while (condition)
            {
                Console.WriteLine(" ________________________________");
                Console.WriteLine("|__________MENU__________________|");
                Console.WriteLine("| 1. Thêm sửa, xóa               |");
                Console.WriteLine("| 2. Thêm sẵn 5 sv vào mảng      |");
                Console.WriteLine("| 3. In mảng                     |");
                Console.WriteLine("| 4. Tìm SV theo mã sinh viên    |");
                Console.WriteLine("| 5. Tìm theo tên gần đúng       |");
                Console.WriteLine("| 6. Sắp xếp sinh viên theo điểm.|");
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
                                ThemSinhVien(list);

                                break;

                            case 2:
                                SuaSinhVien();
                                break;
                            case 3:
                                XoaSinhVien();
                                break;

                            default:
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("| 2. Thêm sẵn 5 sv vào mảng      |");

                        ThemSanSinhVien();
                        InMang(list);
                        break;

                    case 3:
                        Console.WriteLine("| 3. In mảng                     |");
                        InMang(list);
                        break;

                    case 4:
                        Console.WriteLine("| 4. Tìm SV theo mã sinh viên    |");
                        TimTheoMaSV();
                        break;

                    case 5:
                        Console.WriteLine("| 5. Tìm theo tên gần đúng       |");
                        TimTheoTen();
                        break;

                    case 6:
                        Console.WriteLine("| 6. Sắp xếp sinh viên theo điểm.|");
                        SapXepTheoDiem();
                        break;

                    default:
                        condition = false;

                        Console.WriteLine("Thoát chương trình!!!");
                        Console.WriteLine("Tạm biệt và hẹn gặp lại!!!");
                        break;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }



        private static void ThemSinhVien(List<Student> list)
        {
            Console.WriteLine("Nhập thông tin sinh viên: ");

            Student student = new Student();
            Console.Write("Ten: ");
            student.Ten = Console.ReadLine();

            Console.Write("Ma SV: ");
            student.MaSV = Console.ReadLine();

            Console.Write("Diem TB: ");
            student.DiemTb = Convert.ToSingle(Console.ReadLine());

            //student.NhapThongTin();

            list.Add(student);
        }

        private static void SuaSinhVien()
        {
            Student student = TimTheoMaSV();

            if (student != null)
            {
                Console.WriteLine("Nhập thông tin mới: ");
                Console.Write("Ten: ");
                student.Ten = Console.ReadLine();

                Console.Write("Ma SV: ");
                student.MaSV = Console.ReadLine();

                Console.Write("Diem TB: ");
                student.DiemTb = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Thong tin sinh vien sau khi sửa: ");
                student.InThongTin();
            }
        }

        private static void XoaSinhVien()
        {
            Console.Write("Nhập mã sinh viên muốn xóa: ");
            string maSinhVien = Console.ReadLine();

            //Student student = null;
            //foreach (var item in list)
            //{
            //    if (item.MaSV == maSinhVien)
            //    {
            //        student = item;
            //        break;
            //    }
            //}

            //if (student == null)
            //{
            //    Console.WriteLine("Không tìm thấy sinh viên!");
            //}
            //else
            //{
            //    Console.WriteLine("Thong tin sinh vien: ");
            //    student.InThongTin();

            //    list.Remove(student);
            //}

            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSV == maSinhVien)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Thong tin sinh vien: ");
                list[index].InThongTin();

                list.RemoveAt(index);

                Console.WriteLine("Đã xóa sinh viên!");
            }
        }

        private static Student TimTheoMaSV()
        {
            Console.Write("Nhập mã sinh viên: ");
            string maSinhVien = Console.ReadLine();

            Student student = null;
            foreach (var item in list)
            {
                if (item.MaSV == maSinhVien)
                {
                    student = item;
                    break;
                }
            }

            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Thông tin sinh vien: ");
                student.InThongTin();
            }

            return student;
        }

        private static void TimTheoTen()
        {
            Console.Write("Nhập tên sinh viên: ");
            string ten = Console.ReadLine();
            ten = ten.ToLower();

            var lst = new List<Student>(); // mảng chứa kết quả tìm kiếm
            for (int i = 0; i < list.Count; i++)
            {
                // kiểm tra sinh viên có tên chứa từ khóa tìm kiếm không?
                if (list[i].Ten.ToLower().Contains(ten))
                {
                    lst.Add(list[i]);
                }
            }

            Console.WriteLine("Kết quả tìm kiếm: ");
            if (lst.Count == 0)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Đã tìm thấy {0} sinh viên:", lst.Count);
                InMang(lst);
            }
        }

        // Thêm mặc định 5 sv
        private static void ThemSanSinhVien()
        {
            Student sv1 = new Student();
            sv1.Ho = "Lê Văn";
            sv1.Ten = "Hà";
            sv1.Tuoi = 20;
            sv1.MaSV = "PH0001";
            sv1.DiemTb = 5.1f;
            list.Add(sv1);

            Student sv2 = new Student("Nguyễn Ngọc", "An", 23, "PH0002", 1);
            list.Add(sv2);

            Student sv3 = new Student("Trần Trung", "Hiếu", 18, "PH0003", 7.5f);
            list.Add(sv3);

            Student sv4 = new Student("Trần Bảo", "Anh", 17, "PH0004", 10);
            list.Add(sv4);

            Student sv5 = new Student()
            {
                Ho = "Phạm Thế",
                Ten = "Duyệt",
                Tuoi = 25,
                MaSV = "PH0005",
                DiemTb = 5
            };
            list.Add(sv5);
        }

        private static void SapXepTheoDiem()
        {
            // Thuat toan bubble sort
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].DiemTb > list[j + 1].DiemTb) // sắp xếp mảng tăng dần
                                                             // sắp xếp mảng giảm dần thì đổi thành:
                                                             // if (arr[j] < arr[j + 1])
                    {
                        Student temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }

                }
            }

            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp: ");
            InMang(list);
        }

        private static void InMang(List<Student> lst)
        {
            Console.WriteLine("Danh sách sinh viên: ");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write("{0}.\t", i + 1);
                lst[i].InThongTin();
            }
        }
    }
}
