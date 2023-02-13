using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc5
{
    internal class QuanLyPhong
    {
        public string? HangPhong { get; set; }
        public int Gia { get; set; }
        public QuanLyPhong(string hangPhong, int gia)
        {
            HangPhong = hangPhong;
            Gia = gia;
        }
    }
}