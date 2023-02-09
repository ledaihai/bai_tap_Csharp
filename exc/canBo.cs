using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;


    public class Officer
    {
        
    public string? name { get; set; }
        public int age { get; set; }
        public string? gender { get; set; }
        public string? address { get; set; }

        public Officer(string? name, int age, string? gender, string? address)
        {
            name = name;
            age = age;
            gender = gender;
            address = address;
        }
        public virtual void outPut()
        {
            Console.Write("Name: " + name + " Age: " + age + " Gender: " + gender + " Address: " + address);
        }
    }

 