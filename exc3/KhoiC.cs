using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc3
{
    internal class KhoiC : ThiSinh
    {
        public const string? VAN    = "VAN";
        public const string? SU = "SU";
        public const string? DIA = "DIA";

        public KhoiC(int sBD, string ten, string diaChi, string mUT) : base(sBD, ten, diaChi, mUT)
        {

        }
        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine("KhoiB : " + "Điểm Toán"+ VAN + "," + "Điểm sinh" + SU + "," + "Điểm hóa"+ DIA);
        }
    }
}
