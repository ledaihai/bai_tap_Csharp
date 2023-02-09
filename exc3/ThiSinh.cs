using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc3
{
    internal class ThiSinh
    {
        public int SBD { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string MUT { get; set; }
       

        public ThiSinh(int sBD, string ten, string diaChi, string mUT)
        {
            SBD = sBD;
            Ten = ten;
            DiaChi = diaChi;
            MUT = mUT;
        }
        public virtual void OutPut()
        {
            Console.WriteLine("SBD:"+ SBD +"Tên:"+Ten+"Dia chỉ :" + DiaChi + "Mức ưu tiên :"+MUT);
        }
    }
}
