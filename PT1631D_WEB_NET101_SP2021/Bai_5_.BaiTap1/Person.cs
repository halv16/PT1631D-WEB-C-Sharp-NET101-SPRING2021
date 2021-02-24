using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5_.BaiTap1
{
    public class Person
    {
        public string Ten { get; set; }

        public string Ho { get; set; }

        public int Tuoi { get; set; }

        public virtual void InThongTin()
        {
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Ho: " + Ho);
            Console.WriteLine("Tuoi: " + Tuoi);
        }
    }
}
