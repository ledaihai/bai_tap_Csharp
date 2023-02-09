using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using exc5;



internal class program
{
    public static void Main(string[] args)
    {
        QuanLyKhachSan quanLyKhachSan = new QuanLyKhachSan();
        QuanLyPhong quanLyPhong;
        while (true)
        {

            Console.WriteLine("1 + Enter : Them Khach Hang            ");
            Console.WriteLine("2 + Enter : Xoa Khach Hang             ");
            Console.WriteLine("3 + Enter : Xem Thông Tin Khach Hang   ");
            Console.WriteLine("4 + Enter : Thoat                      ");

            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Nhap Ten Khach Hang: ");
                        string? ten = Console.ReadLine();
                        Console.WriteLine("Nhap Tuoi: ");
                        int tuoi = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap ID: ");
                        string? id = Console.ReadLine();

                        Console.WriteLine("6 + Enter: Chon phong Hang A        ");
                        Console.WriteLine("7 + Enter: Chon phong Hang B         ");
                        Console.WriteLine("8 + Enter: Chon phong Hang C         ");

                        string chooseType = Console.ReadLine();
                        Console.WriteLine("Thêm Du Lieu : ");
                        int dateUse = Int32.Parse(Console.ReadLine());
                        if (chooseType.Equals("6"))
                        {
                            quanLyPhong = new PhongA();
                            NguoiDung nguoiDung = new NguoiDung(ten, tuoi, id, dateUse);
                            quanLyKhachSan.AddPerson(nguoiDung);
                        }
                        else if (chooseType.Equals("7"))
                        {
                            quanLyPhong = new PhongB();
                            NguoiDung nguoiDung = new NguoiDung(ten, tuoi, id, dateUse);
                            quanLyKhachSan.AddPerson(nguoiDung);
                        }
                        else if (chooseType.Equals("8"))
                        {
                            quanLyPhong = new PhongC();
                            NguoiDung nguoiDung = new NguoiDung(ten, tuoi, id, dateUse);
                            quanLyKhachSan.AddPerson(nguoiDung);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Them ID De Xoa: ");
                        string? Id = Console.ReadLine();
                        quanLyKhachSan.XoaNguoidung(Id);
                        Console.WriteLine("List after delete");
                        quanLyKhachSan.GetAllPersons();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter IdCard for Calculator: ");
                        string? id = Console.ReadLine();
                        int total = quanLyKhachSan.TongSoTien(id);
                        Console.WriteLine("Total money: " + total);
                        break;
                    }
                case 4:
                    {
                        quanLyKhachSan.GetAllPersons();
                        break;
                    }
                case 5:
                    return;
                default:
                    Console.Write("Error");
                    break;
            }
        }
    }
}


            
        



    


