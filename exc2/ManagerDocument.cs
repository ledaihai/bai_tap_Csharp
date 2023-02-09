using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exc2
{
    internal class ManagerDocument
    {

        public List<Document> documents1;
        public ManagerDocument()
        {
            documents1 = new List<Document>(){
            new book("Book001","KimDong",100,"HoangDat",90),
            new NewsPaper("Newspapper001","HoangDat",100,"07-06-2022"),
            new book("Book002","NhiDong",90,"LeHuy",100),
            new Megazine("Magazine001","NhiDong",67,01,01)
        };
        }
        public void AddDocuments(Document documents)
        {
            var findDocsId = documents1.Where(doc => doc.Id.Contains(documents.Id)).FirstOrDefault();
            if (findDocsId != null)
            {
                Console.WriteLine("Documents is already exists!");
            }
            else
            {
                documents1.Add(documents);
            }
        }
        public void RemoveDocuments(string idDocument)
        {
            var docs = documents1.Where(doc => doc.Id.ToLower().Contains(idDocument.ToLower())).FirstOrDefault();
            if (docs == null)
                Console.WriteLine("Documents not exists!");
            else
                documents1.Remove(docs);
        }
        public void GetAllDocument()
        {
            foreach (var item in documents1)
            {
                item.outPut();
            }
        }
        public static void SearchDocumentsByType(IEnumerable<Document> typeDoc)
        {
            Console.WriteLine("Enter name of type to search: ");
            string? typeName = Console.ReadLine();
            var listByType = typeDoc.Where(byDoc => byDoc.type.ToLower().Contains(typeName.ToLower()));
            if (listByType == null)
            {
                Console.WriteLine("No type found");
            }
            else
                foreach (var itemBook in listByType)
                {
                    Console.WriteLine("List Books: ");
                    itemBook.outPut();
                }
        }
        public void SearchDocumentsByTypes(string type)
        {
            if (type == "Book")
            {
                var listBook = documents1.Where(doc => doc.GetType() == typeof(book));
                foreach (var item in listBook)
                {
                    Console.WriteLine("List Books: ");
                    item.outPut();
                }
                SearchDocumentsByType(listBook);
            }
            if (type == "Magazine")
            {
                var listMagazine = documents1.Where(doc => doc.GetType() == typeof(Megazine));
                foreach (var item in listMagazine)
                {
                    Console.WriteLine("List Magazine: ");
                    item.outPut();
                }
                SearchDocumentsByType(listMagazine);
            }
            if (type == "Newspaper")
            {
                var listNewspaper = documents1.Where(doc => doc.GetType() == typeof(NewsPaper));
                foreach (var item in listNewspaper)
                {
                    Console.WriteLine("List Newspaper: ");
                    item.outPut();
                }
                SearchDocumentsByType(listNewspaper);
            }
        }

    } 
}
