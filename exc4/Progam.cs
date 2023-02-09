using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using exc4;



internal class program
{
    public List<HoGiaDinh>? hoGiaDinhs;
    public static void Main(string[] args)
    {
        KhuPho khuPho = new KhuPho()
        {
            hoGiaDinhs = new List<HoGiaDinh> {
                new HoGiaDinh(
                    new List<Nguoi> {
                        new Nguoi("TRAN THI CHAU A ", 30, " KE TOAN", 123),
                        new Nguoi("HOANG LE HUY", 22, "LAP TRINH VIEN", 321)
                    },
                    "NGU HANH SON",
                    2
                ),
                new HoGiaDinh(
                    new List<Nguoi> {
                        new Nguoi("DINH HOANG DAT",7,"Intern", 111),
                        new Nguoi("NGUYEN THI CHAU MY", 22, "LAP TRINH VIEN",222)
                    },
                    "THANH KHE",
                    2
                ),
                new HoGiaDinh(
                    new List<Nguoi>{
                        new Nguoi("NGUYEN THI HAI SAM", 25,"Intern",333),
                         new Nguoi("NGUYEN THI HAI YEN", 150,"Intern",333),

                    },
                    "HOA KHANH",
                    1
                )
            }
        };
        int record = khuPho.hoGiaDinhs.Count();
        while (true)
        {
            
           
            Console.WriteLine("1 + Enter : Xem Thong Tin Ho Gia Dinh  ");
            Console.WriteLine("2 + Enter : Thoat                      ");
            
            int choose = Int32.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Nhap So id Khu Vuc De Xem Ho Gia Dinh , 'VD:1,2,3 ... ' : ");
                        int n = Int32.Parse(Console.ReadLine());
                        if (n > record)
                        {
                            Console.WriteLine("Only " + record + "/" + n + " families was saved!");
                            for (int i = 0; i < record; i++)
                            {
                                Console.WriteLine("Ho Gia Dinh " + (i + 1) + " Co " + khuPho.hoGiaDinhs[i].SoThanhVien + " Nguoi");
                                foreach (var item in khuPho.hoGiaDinhs[i].Nguois)
                                {
                                    Console.Write("HoTen: " + item.Ten + "Tuoi: " + item.Tuoi + " CongViec" + item.CongViec + " Id: " + item.CCCD);
                                    Console.WriteLine(" DiaChi: " + khuPho.hoGiaDinhs[i].DiaChi);
                                }
                            }
                        }
                        else if (n < record)
                        {
                            Console.WriteLine(n + "/" + record + " Ho Gia Dinh!");
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("Ho Gia Dinh " + (i + 1) + " Co Tong  " + khuPho.hoGiaDinhs[i].SoThanhVien + " Nguoi");
                                foreach (var item in khuPho.hoGiaDinhs[i].Nguois)
                                {
                                    Console.Write("Ten: " + item.Ten + "Ten: " + item.Ten + " Cong Viec" + item.CongViec + " Id: " + item.CCCD);
                                    Console.WriteLine(" Dia Chi: " + khuPho.hoGiaDinhs[i].DiaChi);
                                }
                            }
                            
                            Console.WriteLine("3 + Enter : Hien Thong Tin  ");
                            Console.WriteLine("4 + Enter : Thoat           ");
                           
                            string? choose_step = Console.ReadLine();
                            switch (choose_step)
                            {
                                case "3":
                                    {
                                        for (int i = 0; i < record; i++)
                                        {
                                            Console.WriteLine("Ho Gia Dinh " + (i + 1) + " Co Tong " + khuPho.hoGiaDinhs[i].SoThanhVien + "Nguoi");
                                            foreach (var item in khuPho.hoGiaDinhs[i].Nguois)
                                            {
                                                Console.Write("HoTen: " + item.Ten + "Tuoi: " + item.Ten + "Cong Viec" + item.CongViec + " Id: " + item.CCCD);
                                                Console.WriteLine(" DiaChi: " + khuPho.hoGiaDinhs[i].DiaChi);
                                            }
                                        }
                                        break;
                                    }
                                case "4":
                                    {
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Thoat");
                                    break;
                            }
                        }
                        else if (record == 0)
                        {
                            Console.WriteLine("Khong Co Ho Gia Dinh ! ");
                        }
                        else
                        {
                            Console.WriteLine(" Day la " + record + " Ho Gia Dinh.");
                            for (int i = 0; i < record; i++)
                            {
                                Console.WriteLine("Ho Gia Dinh " + (i + 1) + " Co Tong " + khuPho.hoGiaDinhs[i].SoThanhVien + " Nguoi");
                                foreach (var item in khuPho.hoGiaDinhs[i].Nguois)
                                {
                                    Console.Write("Ten: " + item.Ten + "Tuoi: " + item.Tuoi + " Cong Viec" + item.CongViec + " Id: " + item.CCCD);
                                    Console.WriteLine(" Dia Chi: " + khuPho.hoGiaDinhs[i].DiaChi);
                                }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Error!");
                        break;
                    }
            }
        }
    }
}


            
        



    


