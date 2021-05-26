using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // day la lop giao dien xu chuong trinh quan li sinh vien 
            // tuc la o day chi chua thao tac 
            // 1 , tao giao dien console
            //2  in put du lieu
            //3 out put kqua tra ve

            // khai bao va khoi tao 1 danh sach sinh vien
            List<Student> list = new List<Student>();
            list.Add(new Student("SV01", "Nguyen Van Ty", 0.5, 0.6));
            list.Add(new Student("SV02", "Le Hoang Nam", 6.0, 4.5));
            list.Add(new Student("SV03", "Dao Thanh Hai", 7.0, 8.5));

            MyList m = new MyList(list);


            // tao menu
            Console.WriteLine("1.Hien thi danh sach sinh vien");
            Console.WriteLine("2.Them sinh vien vao danh sach");
            Console.WriteLine("3.Tim kien sinh vien");
            // trong muc 3 . se co 2 tuy chon , tim kiem theo ma , tim kiem theo ten 
            Console.WriteLine("4.Buoc thoi hoc");
            Console.WriteLine("5.Sap xep danh sach");
            // trong muc 5 , se co 2 tuy chon , sap xep theo ma ,hoac theo ten
            // kem theo tang giam 
            Console.WriteLine("6. Doc danh sach sinh vien tu file ");
            Console.WriteLine("7. Doc danh sach sinh vien tu file");
            Console.WriteLine("0. thoat chuong trinh");

            while (true)
            {
                Console.WriteLine("Chon Chuc nang : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("Danh sach sinh vien");
                            m.showList();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Add student : ");
                            m.addStudent(list);
                            break;
                        }
                    case 3:
                        {

                            break;
                        }
                    case 4:
                        {

                            break;
                        }
                    case 5:
                        {

                            break;
                        }
                    case 6:
                        {

                            break;
                        }
                    case 7:
                        {

                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("exit!");
                            Console.ReadKey();
                            return;

                        }
                    default:
                        Console.WriteLine("thang ngu nay .Chi duoc nhap tu 0-7 thoi !!");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
