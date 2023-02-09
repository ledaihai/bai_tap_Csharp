using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2
{
     class Megazine : Document
    {
        public int Chapter { get; set; }
        public int Month { get; set; }
        public Megazine(string id, string type, int versions, int chapter, int month) : base(id, type, versions)
        {
            Chapter = chapter;
            Month = month;
        }
        public override void outPut()
        {
            base.outPut();
            Console.WriteLine(" ,Chapter: " + Chapter + ", Month: " + Month);
        }
    }
}
