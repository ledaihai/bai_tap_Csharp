using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exc3
{
    internal class QuanLyKhoiThi
    {
        public List<ThiSinh> ThiSinhs { get; set; }
        public QuanLyKhoiThi()
        {
            ThiSinhs = new List<ThiSinh>(){
            new KhoiA(1,"DAT HDNA","LIEN CHILL","12"),
            new KhoiB(2,"HUY HQBI","NGU HANH SON","12"),
            new KhoiC(3,"THINH HQNA","SON TRA","12"),
        };
        }
        public void AddThiSinh(ThiSinh student)
        {
            var findStudent = ThiSinhs.Where(st => st.SBD == student.SBD).FirstOrDefault();
            if (findStudent != null)
            {
                Console.WriteLine("Student is already exist!");
            }
            else
            {
                ThiSinhs.Add(student);
            }
        }
        public void GetAllKhoiThi()
        {
            foreach (var item in ThiSinhs)
            {
                item.OutPut();
            }
        }
        public void SearchbyKhoiThi(int sBD)
        {
            var findStudent = ThiSinhs.Where(st => st.SBD == sBD).FirstOrDefault();
            if (findStudent == null)
            {
                Console.WriteLine("Student is already exist!");
            }
            else
            {
                findStudent.OutPut();
            }
        }

    }
}
