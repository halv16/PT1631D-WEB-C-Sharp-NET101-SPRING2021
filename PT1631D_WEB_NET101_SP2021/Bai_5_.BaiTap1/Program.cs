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

        private static List<Student> list = new List<Student>();

        static void Main(string[] args)
        {
            //var lst = new List<Student>();

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(" ________________________");
            Console.WriteLine("|__________MENU__________|");
            Console.WriteLine("| 1. Them, sua, xoa      |");
            Console.WriteLine("| 4. Thoat               |");
            Console.WriteLine("|________________________|");

            Console.Write("Moi ban chon menu: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine(" ________________________");
                    Console.WriteLine("|__________MENU: Thêm sửa, xóa sinh viên:__________|");
                    Console.WriteLine("| 1. Them                |");
                    Console.WriteLine("| 2. Sua                 |");
                    Console.WriteLine("| 3. Xoa                 |");
                    Console.WriteLine("| 4. Thoat               |");
                    Console.WriteLine("|________________________|");

                    Console.Write("Moi ban chon menu: ");
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

                default:
                    break;
            }

            //// khai báo mảng 2 phần tử
            //Student[] arr = new Student[2];

            //arr[0] = new Student();
            //arr[0].Ten = "Sinh vien 1";
            //arr[0].MaSV = "001";
            //arr[0].DiemTb = 5;

            //arr[1] = new Student()
            //{
            //    Ten = "SV 2",
            //    MaSV = "002",
            //    DiemTb = 9
            //};

            //// in thông tin tất cả sinh viên
            //foreach (var item in arr)
            //{
            //    item.InThongTin();
            //}

            //// Tim theo ma sv
            //string maSv = "001";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (maSv == arr[i].MaSV)
            //        arr[i].InThongTin();
            //}

            //// Tim theo tên
            //string ten = "2";
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    // string.Contains
            //    if (arr[i].Ten.Contains(ten))
            //        arr[i].InThongTin();
            //}

            //// sắp xếp mảng
            //// Thuat toan bubble sort
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - 1; j++)
            //    {
            //        if (arr[j].DiemTb > arr[j + 1].DiemTb) // sắp xếp mảng tăng dần
            //                                 // sắp xếp mảng giảm dần thì đổi thành:
            //                                 // if (arr[j] < arr[j + 1])
            //        {
            //            Student temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }

            //    }
            //}

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
            Student student = TimSinhVien();

            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Thong tin sinh vien: ");
                student.InThongTin();

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
            }
        }

        private static Student TimSinhVien()
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

            return student;
        }

    }
}
