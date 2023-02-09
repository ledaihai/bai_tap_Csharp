using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2
{
    class book :Document
    {
        public string? ActorName { get; set; }

        public int Pages { get; set; }
        public List<Document>? ListDocuments;
        public book(string id, string? publisher, int versions, string? actorName, int pages) : base(id, publisher, versions)
        {
            ActorName = actorName;
            Pages = pages;
        }
        public virtual void outPut()
        {
            base.outPut();
            Console.WriteLine(" ,ActorName: " + ActorName + ", Pages: " + Pages);
        }
    }
}
