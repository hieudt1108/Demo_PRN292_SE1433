using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class TestMainEx4
    {

        public static void MainEx4()
        {
            Manager m = new Manager();

            List<Teacher> listT = new List<Teacher>();
            
            listT.Add(new FulltimeTeacher("1", "Doan Trung Hieu1", 1));
            listT.Add(new FulltimeTeacher("2", "Doan Trung Hieu2", 1));
            listT.Add(new FulltimeTeacher("3", "Doan Trung Hieu3", 2));
            listT.Add(new FulltimeTeacher("4", "Doan Trung Hieu4", 3));
            listT.Add(new FulltimeTeacher("5", "Doan Trung Hieu5", 5));
            listT.Add(new FulltimeTeacher("6", "Doan Trung Hieu6", 5));

            listT.Add(new ParttimeTeacher("7", "Doan Trung THieu7", 2));
            listT.Add(new ParttimeTeacher("8", "Doan Trung THieu7", 4));
            listT.Add(new ParttimeTeacher("9", "Doan Trung Hieu7", 6));
            listT.Add(new ParttimeTeacher("10", "Doan Trung Hieu7",8));
            listT.Add(new ParttimeTeacher("11", "Doan Trung Hieu7", 10));
            listT.Add(new ParttimeTeacher("12", "Doan Trung Hieu7", 12));


            Console.WriteLine("1. Import and display a list of Teachers ");
            Console.WriteLine("2. Show list of teachers with the highest salary. ");
            Console.WriteLine("3. How many parttime teachers have the slot > 10");
            Console.WriteLine("4. Calculate the total number of  parttime teacher's slots");
            Console.WriteLine("5. Sort the list of teachers increased by salary");
            Console.WriteLine("6. Is there a teacher whose name starts with ‘T’? If so, show that person's name and salary.");
            Console.WriteLine("7. Displays a list of fulltime teachers with the salary coefficient < 3,\nin which the full name will separate First and Last Names into 2 columns. ");
            Console.WriteLine("8.Exit ");


            while (true)
            {
                Console.Write("Enter choice : ");
                int choice = Validate.inputIntChoice(1, 8);


                switch (choice)
                {
                    case 1:
                        Console.Write("Enter 1 for add Fulltime , 0 for add Parttime : ");
                        int option = Validate.inputIntChoice(0, 1);
                        Console.Write("Enter code : ");
                        string code = Validate.inputString();

                        if (!Validate.checkDuplicateCodeEx4(listT, code))
                        {
                            Console.WriteLine("Duplicate code !!!");
                            break;
                        }
                        Console.Write("Enter name : ");
                        string name = Validate.inputString();
                        double salaryC = 0;
                        int slot = 0;
                        if (option == 1)
                        {
                            Console.Write("Enter salary coefficient : ");
                            salaryC = Validate.inputDouble();
                        }
                        else
                        {
                            Console.Write("Enter number of slot : ");
                            slot = Validate.inputInt();
                        }


                        m.importAndDisplay(listT, code, name, salaryC, slot, option);
                        break;
                    case 2:
                        m.showHighestSalary(listT);
                        break;
                    case 3:
                        Console.WriteLine("Number of parttime teachers have slot >10 : " + m.countTeacher(listT));
                        break;
                    case 4:
                        Console.WriteLine("Total number of  parttime teacher's slots : " + m.totalParttime(listT));
                        break;
                    case 5:
                        m.sortTeacher(listT);
                        break;
                    case 6:
                        m.showTeacherStartT(listT);
                        break;
                    case 7:
                        m.displayList(listT);
                        break;
                    case 8:
                        return;
                }
            }

        }

    }
}
