using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc4
{
    internal class HoGiaDinh
    {
        
    public int SoThanhVien { get; set; }
        public string? DiaChi { get; set; }
        public List<Nguoi>? Nguois { get; set; }


        public HoGiaDinh(List<Nguoi> nguois, string diaChi, int soThanhVien)
        {
            Nguois = nguois;
            DiaChi = diaChi;
            SoThanhVien = soThanhVien;
        }
    }
}
