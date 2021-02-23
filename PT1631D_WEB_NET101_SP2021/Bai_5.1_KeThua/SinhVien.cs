using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._1_KeThua
{
    public class SinhVien : ConNguoi
    {
        public new string Ten { get; set; }

        public SinhVien() : base()
        {
        }

        public SinhVien(string ten, string diaChi) : base(ten, diaChi)
        {
        }

        public new void InTen()
        {
            base.InTen();
            Console.WriteLine("Ten Sinh Vien: " + Ten);
        }

        public void NhapDiaChi(string diaChi)
        {
            DiaChi = diaChi;
        }

        public void InDiaChi()
        {
            Console.WriteLine("Dia Chi: " + DiaChi);
        }
    }
}
