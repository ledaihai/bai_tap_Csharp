using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;


    public class KySu : Officer
    {
        private string branch;
        public KySu(string name, int age, string gender, string address, string branch) : base(name, age, gender, address)
        {
            
            branch = branch;
        }
    
    }

 