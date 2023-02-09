using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace exc
{
    public class program
    {
        public static void Main(string[] args)
        {
            quanLy staffManagement = new quanLy();
            while (true)
            {
                
                Console.WriteLine(" Enter 1: To add new staff              ");
                Console.WriteLine(" Enter 2: To search staff by name       ");
                Console.WriteLine(" Enter 3: To show infomation of staffs  ");
                Console.WriteLine(" Enter 4: To Exit                       ");
                
                int choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the number of Staffs : ");
                            int quantity = Int32.Parse(Console.ReadLine());
                            for (int i = 0; i < quantity; i++)
                            {
                                Console.Write("Add name: ");
                                string? name = Console.ReadLine();
                                Console.Write("Add age: ");
                                int age = Int32.Parse(Console.ReadLine());
                                Console.Write("Add gender: ");
                                string? gender = Console.ReadLine();
                                Console.Write("Add address: ");
                                string? address = Console.ReadLine();
                                
                                Console.WriteLine("Enter 5: To insert new Engineer ");
                                Console.WriteLine("Enter 6: To insert new Worker   ");
                                Console.WriteLine("Enter 7: To insert new Personnel");
                                
                                string? chooseAdd = Console.ReadLine();
                                switch (chooseAdd)
                                {
                                    case "5":
                                        {
                                            Console.Write("add training: ");
                                            string? training = Console.ReadLine();
                                            Officer engineer = new KySu(name, age, gender, address, training);
                                            staffManagement.AddStaff(engineer);
                                            break;
                                        }
                                    case "6":
                                        {
                                            Console.Write("add level: ");
                                            int level = Int32.Parse(Console.ReadLine());
                                            Officer worker = new congNhan(name, age, gender, address, level);
                                            staffManagement.AddStaff(worker);
                                            break;
                                        }
                                    case "7":
                                        {
                                            Console.Write("Add Role: ");
                                            string? role = Console.ReadLine();
                                            Officer personnel = new nhanVien(name, age, gender, address, role);
                                            staffManagement.AddStaff(personnel);
                                            break;
                                        }
                                }
                            }
                            staffManagement.GetAllOfficers();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter name to search: ");
                            string? name = Console.ReadLine();
                            staffManagement.SearchedStaffByName(name);
                            break;
                        }
                    case 3:
                        {
                            staffManagement.GetAllOfficers();
                            break;
                        }
                    case 4:
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
}
            
        



    


