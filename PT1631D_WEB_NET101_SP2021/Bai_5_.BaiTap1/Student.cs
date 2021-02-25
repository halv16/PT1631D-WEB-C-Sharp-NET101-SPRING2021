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

        public override void InThongTin()
        {
            base.InThongTin();

            Console.WriteLine("Ma Sinh Vien: " + MaSV);
            Console.WriteLine("Diem Trung Binh: " + DiemTb);
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap thong tin: ");

            Console.Write("Ma SV: ");
            MaSV = Console.ReadLine();

            Console.Write("Diem TB: ");
            DiemTb = Convert.ToSingle(Console.ReadLine());
        }
    }
}
