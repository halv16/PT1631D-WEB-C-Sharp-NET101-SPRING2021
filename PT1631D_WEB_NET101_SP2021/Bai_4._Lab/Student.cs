using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._Lab
{
    public class Student
    {
        private string name;
        private string yearofBirth;
        private string studentId;
        private double gpa;

        public void OutputStudent()
        {
            Console.WriteLine($"{name} - {yearofBirth} - {studentId} - {gpa}");
        }

        public void InputStudent()
        {
            Console.Write("Nhap Ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap Nam Sinh: ");
            yearofBirth = Console.ReadLine();

            Console.Write("Nhap Id: ");
            studentId = Console.ReadLine();

            Console.Write("Nhap GPA: ");
            gpa = double.Parse(Console.ReadLine());
        }

        public string ValuateStudent(double gpa)
        {
            string valuate;

            if (gpa >= 8)
            {
                valuate = "Xuat Sac";
            }
            else if (gpa > 6)
            {
                valuate = "Gioi";
            }
            else if (gpa >= 5)
            {
                valuate = "Kha";
            }
            else
            {
                valuate = "Hoc lai";
            }

            return valuate;
        }
    }
}
