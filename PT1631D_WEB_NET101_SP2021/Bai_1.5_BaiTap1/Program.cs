using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._5_BaiTap1
{
    class Program
    {
        /*
         * Viết chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên và in ra màn hình theo định dạng
            “Chao ban <họ và tên>, <năm sinh>, <mã sinh viên> den voi lop hoc C#1.”
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap:");

            Console.Write("Ten: ");
            string ten = Console.ReadLine();

            Console.Write("Nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            Console.Write("Ma SV: ");
            string masv = Console.ReadLine();

            Console.WriteLine("Chao ban " + ten + ", " + namSinh + ", " + masv + " den voi lop hoc C#1.");
            Console.WriteLine("Chao ban {0}, {1}, {2} den voi lop hoc C#1.", ten, namSinh, masv);
            Console.WriteLine($"Chao ban {ten}, {namSinh}, {masv} den voi lop hoc C#1.");

            Console.ReadLine();
        }
    }
}
