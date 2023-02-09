using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc5
{
    internal class QuanLyKhachSan
    {
        public List<NguoiDung> nguoiDungs { get; set; }
        public QuanLyKhachSan()
        {
            nguoiDungs  = new List<NguoiDung> {
            new NguoiDung("HAI", 300, "ZZZZ", 10 , new PhongA()),
            new NguoiDung("TIEN", 321, "SSS", 7 , new PhongB() )
        };
        }
        public void AddPerson(NguoiDung nguoiDung)
        {
            var findNguoiDung = nguoiDungs.Where(nguoi => nguoi.Id.Equals(nguoiDung.Id)).FirstOrDefault();
            if (findNguoiDung != null)
            {
                Console.WriteLine("tài khoản người dùng đã được sử dụng ");
            }
            else
            {
                nguoiDungs.Add(nguoiDung);
            }
            foreach (var item in nguoiDungs)
            {
                item.outPut();
            }
        }
        public void XoaNguoidung(string id)
        {
            var timNguoiDung = nguoiDungs.Where(nguoi => nguoi.Id.Contains(id)).FirstOrDefault();
            if (timNguoiDung == null)
            {
                Console.WriteLine("không tìm thấy người cần xóa");
            }
            else
            {
                nguoiDungs.Remove(timNguoiDung);
            }
        }
        public int TongSoTien(string id)
        {
            var TimNguoiDung = nguoiDungs.Where(nguoi => nguoi.Id.Contains(id)).FirstOrDefault();
            if (TimNguoiDung == null)
            {
                return 0;
            }
            return TimNguoiDung.DuLieu * TimNguoiDung.QuanLyPhong.Gia
                ;
        }
        public void GetAllPersons()
        {
            foreach (var item in nguoiDungs)
            {
                item.outPut();
            }
        }
    }
}
