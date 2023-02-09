using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using exc3;

namespace exc
{
    internal class program
    {
        public static void Main(string[] args)
        {
            QuanLyKhoiThi QuanlyKhoiThi = new QuanLyKhoiThi();
            while (true)
            {
                
                Console.WriteLine(" 1 + Enter : THÊM THÍ SINH MỚI  .            ");
                Console.WriteLine(" 2 + Enter : XEM THÔNG TIN THÍ SINH . ");
                Console.WriteLine(" 3 + Enter : TÌM THÔNG TIN THÍ SINH (SBD).     ");
                Console.WriteLine(" 4 + Enter : THOÁT.                         ");
                
                int choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("THÊM SỐ THÍ SINH MONG MUỐN : ");
                            int quantity = Int32.Parse(Console.ReadLine());
                            for (int i = 0; i < quantity; i++)
                            {
                                Console.Write("THÊM SỐ BÁO DANH THÍ SINH: ");
                                int SBD = Int32.Parse(Console.ReadLine());
                                Console.Write("THÊM TÊN THÍ SINH: ");
                                string? Ten = Console.ReadLine();
                                Console.Write("THÊM ĐỊA CHỈ THÍ SINH: ");
                                string? DiaChi = Console.ReadLine();
                                Console.Write("THÊM MỨC ƯU TIÊN : ");
                                string? MUT = Console.ReadLine();
                                
                                Console.WriteLine("A+ Enter : THÊM HỌC SINH KHỐI A  ");
                                Console.WriteLine("B+ Enter : THÊM HỌC SINH KHỐI B  ");
                                Console.WriteLine("C+ Enter : THÊM HỌC SINH KHỐI C  ");
                                
                                string? chooseAdd = Console.ReadLine();
                                switch (chooseAdd)
                                {
                                    case "5":
                                        {
                                            ThiSinh addThiSinh = new KhoiA(SBD, Ten , DiaChi, MUT);
                                            QuanlyKhoiThi.AddThiSinh(addThiSinh);
                                            break;
                                        }
                                    case "6":
                                        {
                                            ThiSinh addThiSinh = new KhoiB(SBD, Ten, DiaChi, MUT);
                                            QuanlyKhoiThi.AddThiSinh(addThiSinh);
                                            break;
                                        }
                                    case "7":
                                        {
                                            ThiSinh addThiSinh = new KhoiC(SBD, Ten, DiaChi, MUT);
                                            QuanlyKhoiThi.AddThiSinh(addThiSinh);
                                            break;
                                        }
                                }
                            }
                            QuanlyKhoiThi.GetAllKhoiThi();
                            break;
                        }
                    case 2:
                        {
                            QuanlyKhoiThi.GetAllKhoiThi();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Id of Student to search: ");
                            int SBD = Int32.Parse(Console.ReadLine());
                            QuanlyKhoiThi.SearchbyKhoiThi(SBD);
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
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
            
        



    


