using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc3
{
    internal class KhoiB : ThiSinh
    {
        public const string? TOAN = "TOAN";
        public const string? SINH = "SINH";
        public const string? HOA = "HOA";

        public KhoiB(int sBD, string ten, string diaChi, string mUT) : base(sBD, ten, diaChi, mUT)
        {

        }
        public override void OutPut()
        {
            base.OutPut();
            Console.WriteLine("KhoiB : " + "Điểm Toán"+ TOAN + "," + "Điểm sinh" + SINH + "," + "Điểm hóa"+ HOA);
        }
    }
}
