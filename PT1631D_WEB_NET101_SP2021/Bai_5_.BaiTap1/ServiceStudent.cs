using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_.BaiTap1
{
    public class ServiceStudent
    {
        // tạo 1 biến mảng toàn cục để lưu danh sách sv
        private List<Student> list = new List<Student>();

        public ServiceStudent()
        {
        }

        public void ThemSinhVien()
        {
            Console.WriteLine("Nhập thông tin sinh viên: ");

            Student student = new Student();
            Console.Write("Ten: ");
            student.Ten = Console.ReadLine();

            Console.Write("Ma SV: ");
            student.MaSV = Console.ReadLine();

            Console.Write("Diem TB: ");
            student.DiemTb = Convert.ToSingle(Console.ReadLine());

            //student.NhapThongTin();

            list.Add(student);
        }

        public void SuaSinhVien()
        {
            Student student = TimTheoMaSV();

            if (student != null)
            {
                Console.WriteLine("Nhập thông tin mới: ");
                Console.Write("Ten: ");
                student.Ten = Console.ReadLine();

                Console.Write("Ma SV: ");
                student.MaSV = Console.ReadLine();

                Console.Write("Diem TB: ");
                student.DiemTb = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Thong tin sinh vien sau khi sửa: ");
                student.InThongTin();
            }
        }

        public void XoaSinhVien()
        {
            Console.Write("Nhập mã sinh viên muốn xóa: ");
            string maSinhVien = Console.ReadLine();

            //Student student = null;
            //foreach (var item in list)
            //{
            //    if (item.MaSV == maSinhVien)
            //    {
            //        student = item;
            //        break;
            //    }
            //}

            //if (student == null)
            //{
            //    Console.WriteLine("Không tìm thấy sinh viên!");
            //}
            //else
            //{
            //    Console.WriteLine("Thong tin sinh vien: ");
            //    student.InThongTin();

            //    list.Remove(student);
            //}

            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSV == maSinhVien)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Thong tin sinh vien: ");
                list[index].InThongTin();

                list.RemoveAt(index);

                Console.WriteLine("Đã xóa sinh viên!");
            }
        }

        public Student TimTheoMaSV()
        {
            Console.Write("Nhập mã sinh viên: ");
            string maSinhVien = Console.ReadLine();

            Student student = null;
            foreach (var item in list)
            {
                if (item.MaSV == maSinhVien)
                {
                    student = item;
                    break;
                }
            }

            if (student == null)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Thông tin sinh vien: ");
                student.InThongTin();
            }

            return student;
        }

        public void TimTheoTen()
        {
            Console.Write("Nhập tên sinh viên: ");
            string ten = Console.ReadLine();
            ten = ten.ToLower();

            var lst = new List<Student>(); // mảng chứa kết quả tìm kiếm
            for (int i = 0; i < list.Count; i++)
            {
                // kiểm tra sinh viên có tên chứa từ khóa tìm kiếm không?
                if (list[i].Ten.ToLower().Contains(ten))
                {
                    lst.Add(list[i]);
                }
            }

            Console.WriteLine("Kết quả tìm kiếm: ");
            if (lst.Count == 0)
            {
                Console.WriteLine("Không tìm thấy sinh viên!");
            }
            else
            {
                Console.WriteLine("Đã tìm thấy {0} sinh viên:", lst.Count);
                InMang(lst);
            }
        }

        // Thêm mặc định 5 sv
        public void ThemSanSinhVien()
        {
            Student sv1 = new Student();
            sv1.Ho = "Lê Văn";
            sv1.Ten = "Hà";
            sv1.Tuoi = 20;
            sv1.GioiTinh = "Nam";
            sv1.MaSV = "PH0001";
            sv1.DiemTb = 5.1f;
            list.Add(sv1);

            Student sv2 = new Student("Nguyễn Ngọc", "an", 23, "Nu", "PH0002", 1);
            list.Add(sv2);

            Student sv3 = new Student("Trần Trung", "Hiếu", 18, "Gioi Tinh 3", "PH0003", 7.5f);
            list.Add(sv3);

            Student sv4 = new Student("Trần Bảo", "Anh", 17, "Khong Xac Dinh", "PH0004", 10);
            list.Add(sv4);

            Student sv5 = new Student()
            {
                Ho = "Phạm Thế",
                Ten = "Duyệt",
                Tuoi = 25,
                GioiTinh = "Nam",
                MaSV = "PH0005",
                DiemTb = 5
            };
            list.Add(sv5);

            InMang(list);
        }

        public void SapXepTheoDiem()
        {
            // Thuat toan bubble sort
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j].DiemTb > list[j + 1].DiemTb) // sắp xếp mảng tăng dần
                                                             // sắp xếp mảng giảm dần thì đổi thành:
                                                             // if (arr[j] < arr[j + 1])
                    {
                        Student temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }

                }
            }

            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp: ");
            InMang(list);
        }

        public void InMang()
        {
            InMang(list);
        }

        public void InMang(List<Student> lst)
        {
            Console.WriteLine("Danh sách sinh viên: ");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write("{0}.\t", i + 1);
                lst[i].InThongTin();
            }
        }

        public void InTheoGioiTinh()
        {
            // đổi tên biên: Ctrl + R + R

            // tạo list chứa danh sách giới tính
            var lstGioiTinh = new List<string>();
            foreach (var item in list)
            {
                if (lstGioiTinh.Contains(item.GioiTinh))
                    continue;

                lstGioiTinh.Add(item.GioiTinh);
            }

            foreach (var gioiTinh in lstGioiTinh)
            {
                Console.WriteLine("Danh sach sinh vien gioi tinh {0}: ", gioiTinh);

                // list chứa sinh viên theo từng giới tính
                var lst = new List<Student>();
                foreach (var sv in list)
                {
                    if (sv.GioiTinh == gioiTinh)
                    {
                        lst.Add(sv);
                    }
                }

                InMang(lst);
            }
        }
    }
}
