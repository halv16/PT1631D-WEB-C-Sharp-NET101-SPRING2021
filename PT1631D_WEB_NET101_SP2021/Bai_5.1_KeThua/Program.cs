using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._1_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sinhVien = new SinhVien();
            sinhVien.Ten = "Sinh Vien A";
            sinhVien.InTen();
            sinhVien.InDiaChi();

            //In(sinhVien);

            //GiaoVien giaoVien = new GiaoVien();
            //giaoVien.Ten = "Giao Vien A";
            //In(giaoVien);

            //sinhVien.Ten = "Ha";


            //sinhVien.InTen();

            //sinhVien.NhapDiaChi("HN");
            //sinhVien.InDiaChi();


            Console.ReadLine();
        }

        static void In(ConNguoi conNguoi)
        {
            conNguoi.InTen();
        }

        static void InSinhVien(SinhVien sinhVien)
        {
            sinhVien.InTen();
        }
    }
}
