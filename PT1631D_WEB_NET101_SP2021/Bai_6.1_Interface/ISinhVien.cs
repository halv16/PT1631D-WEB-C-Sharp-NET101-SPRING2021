using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6._1_Interface
{
    public interface ISinhVien : IConNguoi
    {
       int Id { get; }

        void InThongTin();
    }
}
