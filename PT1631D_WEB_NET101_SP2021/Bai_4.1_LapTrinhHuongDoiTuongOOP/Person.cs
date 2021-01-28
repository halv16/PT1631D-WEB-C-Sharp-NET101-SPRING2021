using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._1_LapTrinhHuongDoiTuongOOP
{
    public class Person
    {
        public string Name { get; set; }

        public int YearOfBirth { get; set; }

        public string Address { get; set; }

        public void OutputPerson()
        {
            Console.WriteLine($"{Name} - {YearOfBirth} - {Address}");
        }

        public void InputPerson()
        {
            Console.WriteLine("Nhap thong tin:");
            Console.Write("Ten: ");
            Name = Console.ReadLine();
        }

        public int GetAge()
        {
            int age = 2021 - YearOfBirth;
            return age;
        }

        public int GetAge(int year)
        {
            int age = year - YearOfBirth;
            return age;
        }

        //
    }
}
