using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



    class congNhan : Officer
    {
        private int level;

        public congNhan(string name, int age, string gender, string address, int level) : base(name, age, gender, address)
        {

            level = level;
        }

        public override void outPut()
        {
            base.outPut();
            Console.WriteLine(" Level: " + level);
        }


    }  


            
        



    


