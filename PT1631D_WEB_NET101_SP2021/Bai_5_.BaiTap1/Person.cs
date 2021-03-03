using System;

namespace Bai_5_.BaiTap1
{
    public class Person
    {
        private string ho;
        private string ten;

        public string Ho
        {
            get
            {
                return ho;
            }
            set
            {
                ho = value;
            }
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string HoTen
        {
            get
            {
                string hoTen = $"{Ho} {Ten}";
                // Viết hoa chữ cái đầu tiên của mỗi từ
                hoTen = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(hoTen.ToLower());

                return hoTen;
            }
        }

        public int Tuoi { get; set; }

        public string GioiTinh { get; set; }

        public virtual void InThongTin()
        {
            // tạo ra 1 chuỗi string có 30 ký tự bằng cách thêm dấu cách đằng trước từ
            var hoTen = string.Format("{0,30}", HoTen);
            // tạo ra 1 chuỗi string có 30 ký tự bằng cách thêm dấu cách đằng sau từ
            hoTen = string.Format("{0,-30}", HoTen);

            Console.Write("{0} \t| {1} \t| {2,-20}", hoTen, Tuoi, GioiTinh);

            //Console.WriteLine("Ten: " + Ten);
            //Console.WriteLine("Ho: " + Ho);
            //Console.WriteLine("Tuoi: " + Tuoi);
        }
    }
}
