using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2
{
    internal class Document
    {
        public string? Id { get; set; }
        public string? type { get; set; }
        public int Versions { get; set; }
        public Document(string id, string? type, int versions)
        {
            Id = id;
            type = type;
            Versions = versions;
        }
        public virtual void outPut()
        {
            Console.Write("Id: " + Id + " ,type: " + type + " ,Versions: " + Versions);
        }
    }
}
