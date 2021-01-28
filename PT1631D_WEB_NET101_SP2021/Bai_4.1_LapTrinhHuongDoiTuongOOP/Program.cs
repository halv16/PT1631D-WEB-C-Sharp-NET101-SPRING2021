using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._1_LapTrinhHuongDoiTuongOOP
{
    /*
     * 1. LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG OOP
     *      Lập trình hướng đối tượng (Object Oriented Programing – OOP) là đưa các đối tượng có trong thế giới thực (Sinh Viên, ô tô, chó, mèo, người, hoa......)
     *      vào trong lập trình để thao tác với các Đối Tượng(thêm,sửa,xóa....) hoặc với các thuộc tính của đối tượng.
     * - 4 Tính chất của OOP:
     *      - Đóng gói: Tức là trạng thái của đối tượng được bảo vệ không cho các truy cập từ code bên ngoài như thay đổi trong thái hay nhìn trực tiếp. Việc cho phép môi trường bên ngoài tác động lên các dữ liệu nội tại của một đối tượng theo cách nào là hoàn toàn tùy thuộc vào người viết mã. Đây là tính chất đảm bảo sự toàn vẹn, bảo mật của đối tượng, tính đóng gói được thể hiện thông qua phạm vi truy cập (access modifier).
     *          Ngoài ra, các lớp liên quan đến nhau có thể được gom chung lại thành namespace.
     *      - Tính kế thừa: Cho phép định nghĩa một lớp đối tượng dựa trên các thuộc tính có sẵn của một lớp đã có.
     *      - Tính đa hình: Nó thể hiện rõ nhất khi gọi đến một phương thức của đối tượng giống nhau nhưng kết quả của phương thức đó có thể khác nhau.
     *          + Nạp chồng (Overloading): Nạp chồng phương thức cùng tên cùng kiểu phương thức nhưng khác tham số truyền vào. Khi đưa đúng số lượng tham số truyền vào sẽ gọi đúng phương thức cần được thực hiện.
     *          + Ghi đè (Overriding): Ghi đè phương thức có cùng tên cùng tham số giữa lớp cha và lớp con. Các phương thức của lớp con kế thừa từ lớp cha từ kiểu phương thức, tên, tham số truyền vào nhưng tại các lớp con có thể viết lại code hành động khác theo nghiệp vụ của nó với phương thức được kế thừa.
     *      - Tính trừu tượng: là tổng quát hóa một cái gì đó lên. không cần chú ý chi tiết bên trong.
     *          + Tính trừu tượng là một tiến trình ẩn các chi tiết trình triển khai và chỉ hiển thị tính năng tới người dùng. Tính trừu tượng cho phép bạn loại bỏ tính chất phức tạp của đối tượng bằng cách chỉ đưa ra các thuộc tính và phương thức cần thiết của đối tượng trong lập trình.
                + Tính trừu tượng giúp bạn tập trung vào những cốt lõi cần thiết của đối tượng thay vì quan tâm đến cách nó thực hiện.
                + Trong C#, chúng là sử dụng abstract class và interface để có tính trừu tượng.
     *
     * - Class: Chúng ta có thể xem lớp như một khuôn mẫu (template) của đối tượng (Object). Trong đó bao gồm dữ liệu của đối tượng (fields hay properties) và các phương thức(methods) tác động lên thành phần dữ liệu đó gọi là các phương thức của lớp. Class là từ khóa để khai báo lớp.
     * - Đối tượng (Object): được xem là một thực thể trong thế giới thực.
     * - Object bao gồm: Thuộc tính (Property) - Phương thức (method/function)
     * - Property: Các thuộc tính của đối tượng
     * - Phương thức:  Phương thức hay còn gọi là hàm thành viên Một phương thức là một nhóm lệnh cùng nhau thực hiện một tác vụ
     * - Từ khóa this trong C# là một biến tham chiếu được sử dụng để tham chiếu tới đối tượng của lớp hiện tại.
     */

    /*
         *  2. Hàm - Phương thức - Method
         *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
         *  LỢI ÍCH: - Giúp quản lý code tốt hơn
         *           - Tái sử dụng
         *
         *  Công thức chung:
         *  <phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *  }
         * <Phạm vi truy cập> - Access Specifier:public, private, protected, internal
         *
         * <Kiểu trả về> : có 2 kiểu trả về và không trả về
         *          - Kiểu không trả về: void
         *          - Kiểu trả về: là giá trị(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
         *
         * <Tên phương thức>: động từ, khai báo theo PascalCase.
         * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số.
         *                      Tham số truyền vào là các kiểu dữ liệu khác nhau không nhất thiết phải giống nhau như: có thể kiểu dữ liệu, mảng, đối tượng, danh sách.
         */

    class Program
    {
        static void Main(string[] args)
        {
            In();
            Console.ReadLine();

            // Khai báo 1 đối tượng
            SinhVien sinhVien = new SinhVien();
            SinhVien sv2 = new SinhVien();

            // gán giá trị cho thuộc tính của đối tượng
            // <tên biến>.<thuộc tính> =  giá trị;
            sinhVien.Age = 10;
            sinhVien.Ten = "Sinh vien a";

            // lấy giá trị
            Console.WriteLine(sinhVien.Ten);
            Console.WriteLine(sinhVien.Age);
            Console.WriteLine("Diem: " + sinhVien.Diem);

            // Sử dụng phương thức của đối tượng
            sinhVien.NhapThongTin("ha", 5);
            sinhVien.InThongTin();

            //Sử dụng hàm trả về giá trị
            int diem = sinhVien.TinhDiem(2, 3);
            Console.WriteLine("Diem " + diem);

            //Person person = new Person();
            //person.InputPerson();
            //person.OutputPerson();
            //person.YearOfBirth = 2000;

            //int age = person.GetAge();
            //Console.WriteLine(age);

            int i;
            ThamChieu1(out i);
            Console.WriteLine("Gia tri cua i = " + i);

            Console.ReadKey();
        }

        // Tham trị
        static void ThamTri(int i)
        {
            i++;

            Console.WriteLine("Gia tri cua i ben trong ham = " + i);
        }

        // Tham chiếu: ref, out
        // Khi dùng ref: biến phải được khởi tạo trước khi truyền cho phương thức
        static void ThamChieu(ref int i)
        {
            i++;

            Console.WriteLine("Gia tri cua i ben trong ham = " + i);
        }

        // Khi dùng out: biến không cần khởi tạo trước , bên trong phương thức cần gán giá trị cho biến
        static void ThamChieu1(out int i)
        {
            i = 6;
            i++;

            Console.WriteLine("Gia tri cua i ben trong ham = " + i);
        }

        static void In()
        {
            Console.WriteLine("Xin chao ca lop!");
        }

    }
}
