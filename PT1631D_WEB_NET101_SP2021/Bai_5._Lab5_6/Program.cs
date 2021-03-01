using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_5._Lab5_6
{
    class Program
    {
        private static List<DanhBa> list = new List<DanhBa>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool condition = true;
            while (condition)
            {
                Console.WriteLine(" ________________________________");
                Console.WriteLine("|__________MENU__________________|");
                Console.WriteLine("| 1. Thêm danh bạ                |");
                Console.WriteLine("| 2. In mảng                     |");
                Console.WriteLine("| 3. Tìm theo số điện thoại      |");
                Console.WriteLine("| 0. Thoát                       |");
                Console.WriteLine("|________________________________|");

                Console.Write("Mời bạn chọn menu: ");
                int menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("| 1. Thêm danh bạ                |");
                        ThemDanhBa(list);
                        InMang(list);
                        break;

                    case 2:
                        Console.WriteLine("| 2. In mảng                     |");
                        InMang(list);
                        break;

                    case 3:
                        Console.WriteLine("| 3. Tìm theo số điện thoại      |");
                        TimTheoSdt();
                        break;

                    default:
                        condition = false;
                        Console.WriteLine("Tạm biệt và hẹn gặp lại!!!");
                        break;
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        private static void ThemDanhBa(List<DanhBa> list)
        {
            Console.WriteLine("Nhập thông tin: ");
            DanhBa danhBa = new DanhBa();
            Console.Write("Tên: ");
            danhBa.HoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            danhBa.NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Giới tính: ");
            danhBa.GioiTinh = Console.ReadLine();

            Console.Write("Sdt1: ");
            danhBa.Sdt1 = Console.ReadLine();

            Console.Write("Sdt2: ");
            danhBa.Sdt2 = Console.ReadLine();

            list.Add(danhBa);
        }

        private static void InMang(List<DanhBa> lst)
        {
            Console.WriteLine("Danh sách trong danh bạ: ");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write("{0}.\t", i + 1);
                lst[i].InThongTin();
            }
        }

        private static void TimTheoSdt()
        {
            Console.Write("Nhập số điện thoại: ");
            string sdt = Console.ReadLine();

            Console.WriteLine("Kết quả tìm kiếm: ");
            int k = 0;
            foreach (var item in list)
            {
                if (item.Sdt1.Contains(sdt) || item.Sdt2.Contains(sdt))
                {
                    k++;

                    item.InThongTin();
                }
            }

            if (k == 0)
                Console.WriteLine("Không tìm thấy!");
        }
    }
}
