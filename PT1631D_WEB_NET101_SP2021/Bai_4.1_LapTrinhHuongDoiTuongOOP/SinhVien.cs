using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._1_LapTrinhHuongDoiTuongOOP
{
    /*
     * Tạo ra 1 đối tượng Sinh Viên
     *
     * Tên Class khai báo theo PascalCase
     */

    /*
     * - public
     * - internal
     */
    public class SinhVien
    {
        // fields
        // Cú pháp:
        // <phạm vi truy cập> <kiểu dữ liệu> <tên biến>;

        // camel case
        private string _name;
        private readonly int _id = 0;


        // property
        // khai báo theo kiểu PascalCase
        public string Ten { get; set; }

        public double Diem { get; set; }

        public int Age { get; internal set; }

        // hàm khởi tạo
        // contructor
        // <pham vi truy cap> <ten class>()
        public SinhVien()
        {
            Diem = 5;
        }

        //public SinhVien(string name)
        //{
        //    this.name = name;
        //}

        // hàm - function
        // Cú pháp:
        // Có giá trị trả về : <pham vi> <kieu du lieu> <ten ham>(<bien 1>, <bien 2>...)
        // không có giá trị  : <pham vi> void <ten ham>(<bien 1>, <bien 2>...)

        // hàm không trả về không tham số
        internal void NhapThongTin()
        {
            Console.Write("Nhap Ten: ");
            Ten = Console.ReadLine();

            Console.Write("Nhap Diem: ");
            Diem = int.Parse(Console.ReadLine());
        }

        // hàm không trả về có tham số
        public void NhapThongTin(string ten, int diem)
        {
            Ten = ten;
            Diem = diem;
        }

        public void InThongTin()
        {
            Console.WriteLine("Ten Sinh Vien: " + Ten);
            Console.WriteLine("Diem Sinh Vien: " + Diem);
        }

        // Hàm trả về không tham số
        public int getYear()
        {
            //Hàm bắt buộc phải trả về đúng kiểu dữ liệu của hàm
            //return <giá trị đúng kiểu dữ liệu của hàm>;

            //Thực hiện dòng lệnh để xử lý công việc nhưng kết quả cuối cùng phải trả về 1 giá trị.
            int a = 2021;
            return a;
        }

        // Hàm trả về có tham số
        public int TinhDiem(int lab1, int lab2)
        {
            int diem = (lab1 + lab2) / 2;
            return diem;
        }
    }
}
