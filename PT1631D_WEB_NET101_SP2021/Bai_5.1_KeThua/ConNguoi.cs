using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._1_KeThua
{
    public class ConNguoi
    {
        public string Ten { get; set; }

        protected string DiaChi { get; set; }

        public ConNguoi()
        {
            DiaChi = "Ha Noi";
        }

        public ConNguoi(string ten, string diaChi)
        {
            Ten = ten;
            DiaChi = diaChi;
        }

        public void InTen()
        {
            Console.WriteLine("Ten: " + Ten);
        }
    }
}
