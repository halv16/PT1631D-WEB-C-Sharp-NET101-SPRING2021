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
         */
        static void Main(string[] args)
        {
            // khai báo mảng 2 phần tử
            Student[] arr = new Student[2];

            arr[0] = new Student();
            arr[0].Ten = "Sinh vien 1";
            arr[0].MaSV = "001";
            arr[0].DiemTb = 5;

            arr[1] = new Student()
            {
                Ten = "SV 2",
                MaSV = "002",
                DiemTb = 9
            };

            // in thông tin tất cả sinh viên
            foreach (var item in arr)
            {
                item.InThongTin();
            }

            // Tim theo ma sv
            string maSv = "001";
            for (int i = 0; i < arr.Length; i++)
            {
                if (maSv == arr[i].MaSV)
                    arr[i].InThongTin();
            }

            // Tim theo tên
            string ten = "2";
            for (int i = 0; i < arr.Length; i++)
            {
                // string.Contains
                if (arr[i].Ten.Contains(ten))
                    arr[i].InThongTin();
            }

            // sắp xếp mảng
            // Thuat toan bubble sort
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].DiemTb > arr[j + 1].DiemTb) // sắp xếp mảng tăng dần
                                             // sắp xếp mảng giảm dần thì đổi thành:
                                             // if (arr[j] < arr[j + 1])
                    {
                        Student temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            
            Console.ReadLine();
        }
    }
}
