
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


    public class quanLy
    {
        public List<Officer> Officers;
        public quanLy()
        {
            Officers = new List<Officer>(){
            new nhanVien("THINH HUQA", 22, "Male", "TruongChinh", "BE"),
            new KySu("HUY HUNTER", 21, "Male", "MaiDangChon","FE"),
            new KySu("DAT HUDA", 21, "Male", "DienBienPhu","BE")
        };
          
        }

        public void AddStaff(Officer staff)
        {
            Officers.Add(staff);
        }
        public void SearchedStaffByName(string name)
        {
            
            var listCB = Officers.Where(c => c.name.Contains(name)).ToList();
            foreach (var item in listCB)
            {
                item.outPut();
            }
        }
        public void GetAllOfficers()
        {
            foreach (var item in Officers)
            {
                item.outPut();
            }
        }
    } 


 