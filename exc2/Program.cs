using exc2;

class Program
{
    public static void Main(string[] args)
    {
        ManagerDocument documentManagement = new ManagerDocument();
        while (true)
        {
           
            Console.WriteLine("+ Enter 1: To add new Documents            ");
            Console.WriteLine("+ Enter 2: To delete Documents by Id       ");
            Console.WriteLine("+ Enter 3: To show infomation of Document  ");
            Console.WriteLine("+ Enter 4: To search for Documents by Type ");
            Console.WriteLine("+ Enter 5: To Exit                         ");
            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the number of Documents you want to add: ");
                        int quantity = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < quantity; i++)
                        {
                            Console.Write("Add Id of Document: ");
                            string? id = Console.ReadLine();
                            Console.Write("Add Name of type: ");
                            string? namePublisher = Console.ReadLine();
                            Console.Write("Add Number of Versions: ");
                            int versions = Int32.Parse(Console.ReadLine());
                            
                            Console.WriteLine("+ Enter 6: To insert new Book.       ");
                            Console.WriteLine("+ Enter 7: To insert new Megazine.   ");
                            Console.WriteLine("+ Enter 8: To insert new Newspaper.  ");
                            
                            string? chooseAdd = Console.ReadLine();
                            switch (chooseAdd)
                            {
                                case "6":
                                    {
                                        Console.Write("Enter Actor Name: ");
                                        string? actorName = Console.ReadLine();
                                        Console.Write("Enter Number of Pages: ");
                                        int pages = Int32.Parse(Console.ReadLine());
                                        Document addBook = new book(id, namePublisher, versions, actorName, pages);
                                        documentManagement.AddDocuments(addBook);
                                        break;
                                    }
                                case "7":
                                    {
                                        Console.Write("Enter Chapter: ");
                                        int chapter = Int32.Parse(Console.ReadLine());
                                        Console.Write("Enter Release Month: ");
                                        int month = Int32.Parse(Console.ReadLine());
                                        Document addMegazine = new Megazine(id, namePublisher, versions, chapter, month);
                                        documentManagement.AddDocuments(addMegazine);
                                        break;
                                    }
                                case "8":
                                    {
                                        Console.Write("Enter Release Date: ");
                                        string? releaseDate = Console.ReadLine();
                                        Document addNewspaper = new NewsPaper(id, namePublisher, versions, releaseDate);
                                        documentManagement.AddDocuments(addNewspaper);
                                        break;
                                    }
                            }
                        }
                        documentManagement.GetAllDocument();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Id for Delete: ");
                        string? idDocs = Console.ReadLine();
                        documentManagement.RemoveDocuments(idDocs);
                        Console.WriteLine("List after delete");
                        documentManagement.GetAllDocument();
                        break;
                    }
                case 3:
                    {
                        documentManagement.GetAllDocument();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter type to search: ");
                        string? type = Console.ReadLine();
                        documentManagement.SearchDocumentsByTypes(type);
                        break;
                    }
                case 5:
                    return;
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
        }
    }
}