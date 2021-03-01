using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._Lab5_6
{
    public class DanhBa
    {
        public string HoTen { get; set; }

        public string Sdt1 { get; set; }

        public string Sdt2 { get; set; }

        public int NamSinh { get; set; }

        public string GioiTinh { get; set; }

        public DanhBa()
        {
        }

        public void InThongTin()
        {
            int year = 2000;

            string xungHo = "Em";
            if (NamSinh <= year)
            {
                if (GioiTinh.ToUpper() == "NAM")
                {
                    xungHo = "Anh";
                }
                else
                {
                    xungHo = "Chị";
                }
            }

            Console.WriteLine("{0} {1} \t| {2} \t| {3} \t| {4} \t| {5}", xungHo, HoTen, NamSinh, GioiTinh, Sdt1, Sdt2);
        }
    }
}
