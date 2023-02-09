using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc4
{
    internal class KhuPho
    {
        public List<HoGiaDinh>? khuPhos { get; set; }
        public List<HoGiaDinh> hoGiaDinhs { get; internal set; }

        public KhuPho()
        {
            khuPhos = new List<HoGiaDinh>();
        }

        
        public KhuPho(List<HoGiaDinh> HoGiaDinhs)
        {
            this.khuPhos = khuPhos;
        }
        public void Print()
        {
            foreach (var HoGiaDinh in khuPhos!)
            {
                Console.WriteLine(new
                {
                   Diachi= HoGiaDinh.DiaChi,
                    SoThanhVien =HoGiaDinh.DiaChi
                });
            }
        }
    }
}

