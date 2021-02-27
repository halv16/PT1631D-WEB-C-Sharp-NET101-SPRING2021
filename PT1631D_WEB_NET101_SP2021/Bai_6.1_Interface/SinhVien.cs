using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6._1_Interface
{
    class SinhVien : ISinhVien, IConNguoi
    {
        public int Id { get; }

        public string Name { get; set; }

        public SinhVien()
        {
        }

        public SinhVien(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void InThongTin()
        {
            Console.WriteLine("In thong tin:");
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
        }
    }
}
