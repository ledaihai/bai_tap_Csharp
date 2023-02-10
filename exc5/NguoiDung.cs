using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc5
{
    internal class NguoiDung
    {
        public string? Ten { get; set; }
        public int Tuoi { get; set; }
        public string Id { get; set; }
        public int DuLieu { get; set; }
        public QuanLyPhong QuanLyPhong { get; }



        public NguoiDung(string ten, int tuoi, string id, int dulieu, QuanLyPhong quanLyPhong)
        {
            Ten = ten;
            Tuoi = tuoi;
            Id = id;
            DuLieu = dulieu;
            QuanLyPhong = quanLyPhong;

        }
        public void outPut()
        {
            Console.WriteLine("HoTen: " + Ten + ", Tuoi: " + Tuoi + ", Id: " + Id + ", Dulieu: " + DuLieu + "Hang phong" + QuanLyPhong.HangPhong + "Gia" + QuanLyPhong.Gia);
        }
    }
}