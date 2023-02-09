using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc4
{
    internal class Nguoi
    {
        
    public string? Ten { get; set; }
        public int Tuoi { get; set; }
        public string? CongViec { get; set; }
        public int CCCD { get; set; }

        public Nguoi(string Ten, int Tuoi, string? CongViec, int CCCD)
        {
            Ten = Ten;
            Tuoi = Tuoi;
            CongViec = CongViec;
            CCCD = CCCD;
        }
        public void OutPut() {
            Console.WriteLine($"ten: {Ten } , Tuoi: {Tuoi} , Cong Viec: {CongViec} , CCCD: {CCCD} " );
        }

   
}
}
