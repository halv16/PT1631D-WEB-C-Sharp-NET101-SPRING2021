using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_.BaiTap1
{
    public class Student : Person
    {
        public string MaSV { get; set; }

        public float DiemTb { get; set; }

        // Hàm khởi tạo không có tham số
        public Student()
        {
        }

        // Hàm khởi tạo có tham số
        public Student(string ho, string ten, int tuoi, string masv, float diemtb)
        {
            Ho = ho;
            Ten = ten;
            Tuoi = tuoi;
            MaSV = masv;
            DiemTb = diemtb;
        }

        public override void InThongTin()
        {
            base.InThongTin();

            // {MaSV,10}: chuỗi string có 10 ký tự bằng cách thêm dấu cách đằng trước từ
            Console.WriteLine($"\t| {MaSV,10} \t| {DiemTb}");
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");

            Console.Write("Ho: ");
            Ho = Console.ReadLine();

            Console.Write("Ten: ");
            Ten = Console.ReadLine();

            Console.Write("Tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write("Ma SV: ");
            MaSV = Console.ReadLine();

            Console.Write("Diem TB: ");
            DiemTb = Convert.ToSingle(Console.ReadLine());
        }
    }
}
