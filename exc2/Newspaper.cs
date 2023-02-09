using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2
{
     class NewsPaper : Document
    {
        public string? DateTime { get; set; }
        public NewsPaper(string id, string? type, int versions, string? dateTime) : base(id, type, versions)
        {
            DateTime = dateTime;
           
          
            
        }
        public override void outPut()
        {
            base.outPut();
            Console.WriteLine(" ,DateTime: " + DateTime);
        }
    }
}
