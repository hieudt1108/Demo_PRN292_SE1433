using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    class LAB1
    {




        static void Main(string[] args)




        {

            Console.WriteLine("update chưa ");
            Console.WriteLine("update rồi ");


            Console.WriteLine("1.  Lesson 1");
            Console.WriteLine("2.  Lesson 2");
            Console.WriteLine("3.  Lesson 3");
            Console.WriteLine("4.  Lesson 4");
            Console.WriteLine("5.  Lesson 5");
            Console.WriteLine("6.  Lesson 6");
            Console.WriteLine("7.  Lesson 7");
            Console.WriteLine("8.  Lesson 8");
            Console.WriteLine("9.  Lesson 9");
            Console.WriteLine("11. Lesson 11");
            Console.WriteLine("12. Lesson 12");
            Console.WriteLine("13. Lesson 13");
            Console.WriteLine("14. Lesson 14");
            Console.WriteLine("15. Lesson 15");
   



            while (true)
            {

                int n;
                Console.Write("Enter Choice: ");
                n = Handling.inputIntChoice(1,15);

                switch (n)
                {
                   
                    case 1:
                        Manage.Ex1();

                        break;
                   
                    case 2:
                        Manage.Ex2();
                        break;
                    case 3:
                        Manage.Ex3();
                        break;
                    case 4:
                        Manage.Ex4();
                        break;
                    case 5:
                        Manage.Ex5();
                        break;
                    case 6:
                        Manage.Ex6();
                        break;
                    case 7:
                        Manage.Ex7();
                        break;
                    case 8:
                        Manage.Ex8();
                        break;
                    case 9:
                        Manage.Ex9();
                        break;
                    case 10:
                        Manage.Ex10();
                        break;
                    case 11:
                        Manage.Ex11();
                        break;
                    case 12:
                        Manage.Ex12();
                        break;
                    case 13:
                        Manage.Ex13();
                        break;
                    case 14:
                        Manage.Ex14();
                        break;
                    case 15:
                        Manage.Ex15();
                        break;





                }




                Console.WriteLine("");
            }
        }
    }
}
