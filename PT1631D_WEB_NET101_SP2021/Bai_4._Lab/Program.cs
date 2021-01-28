using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student();

            Console.WriteLine("Nhap thong tin sinh vien 1:");
            student1.InputStudent();
            Console.WriteLine("In ra thong tin sinh vien 1:");
            student1.OutputStudent();

            Console.WriteLine("Xep loai " + student1.ValuateStudent(6));

            Console.WriteLine("Nhap thong tin sinh vien 2:");
            student2.InputStudent();
            Console.WriteLine("In ra thong tin sinh vien 2:");
            student2.OutputStudent();

            Console.WriteLine("Xep loai " + student2.ValuateStudent(6));

            Console.ReadLine();
        }
    }
}
