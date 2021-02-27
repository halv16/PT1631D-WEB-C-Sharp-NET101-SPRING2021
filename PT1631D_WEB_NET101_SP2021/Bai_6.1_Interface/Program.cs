using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6._1_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ISinhVien sv = new SinhVien(1, "Ha");
            sv.InThongTin();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
