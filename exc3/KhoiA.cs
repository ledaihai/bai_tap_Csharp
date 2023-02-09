using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc3
{
    internal class KhoiA : ThiSinh
    {
        public const string? TOAN = "TOAN";
        public const string? LY  = "LY";
        public const string? HOA = "HOA";

        public KhoiA(int sBD, string ten, string diaChi,string mUT) : base(sBD, ten, diaChi, mUT)
        {

        }
        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine("KhoiA : " + TOAN + "," + LY + "," + HOA);
        }
        
    }
}
