
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
public class nhanVien : Officer
        {
            private string? role { get; set; }

            public nhanVien(string name, int age, string gender, string address, string role) : base(name, age, gender, address)
            {

               role = role;
            }
            public override void outPut()
            {
                base.outPut();
                Console.WriteLine(" role: " + role);
            }


        }
    

 