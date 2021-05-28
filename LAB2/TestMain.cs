using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class TestMain
    {

        public static void MainEx3()
        {
            List<Employee> listE = new List<Employee>();


            listE.Add(new Employee("1", "Doan Trung Hieu1", DateTime.Parse("08/11/2000"), "Male", 5, 3.2));
            listE.Add(new Employee("2", "Doan Trung Hieu1", DateTime.Parse("08/11/2000"), "Male", 6, 2.2));
            listE.Add(new Employee("3", "Doan Trung Hieu2", DateTime.Parse("08/11/2000"), "Male", 2, 2.2));
            listE.Add(new Employee("4", "Doan Trung Hieu3", DateTime.Parse("08/11/1988"), "Female", 0, 2.2));
            listE.Add(new Employee("5", "Doan Trung Hieu4", DateTime.Parse("08/11/1970"), "Male", 2, 1.2));





            Manger m = new Manger(listE);
            Console.WriteLine("1. TC1- Enter the employee list");
            Console.WriteLine("2. TC2- Display the employee list");
            Console.WriteLine("3. TC3- Counts the number of female employees with no allowances");
            Console.WriteLine("4. TC4- Displays employees with the number <given number.");
            Console.WriteLine("5. TC5- Arranging an increasing number of male employees' salaries.");
            Console.WriteLine("6. TC6- Removing male employees according to the number of entries entered from the keyboard. ");
            Console.WriteLine("7. TC7- Display employees by name.");
            Console.WriteLine("8. TC8- Update salary");
            Console.WriteLine("9. Exit");



            while (true)
            {
                Console.Write("Enter choice: ");
                int choice = Validate.inputIntChoice(1, 9);
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter size :");
                        int size = Validate.inputInt();
                        m.inputList(size);
                        break;
                    case 2:
                        m.showList();
                        break;
                    case 3:
                        Console.WriteLine("Number of female employees are there without allowances : "+ m.count());
                        break;
                    case 4:
                        Console.Write("Enter n : ");
                        int n = Validate.inputInt();
                        m.showSocon(n);
                        break;
                    case 5:
                        m.sortBySalary();
                        break;
                    case 6:
                        Console.Write("Enter n : ");
                        int n2 = Validate.inputInt();
                        m.delete(n2);
                        break;
                    case 7:
                        Console.Write("Enter name to find : ");
                        string name = Validate.inputString();
                        m.showByName(name);
                        break;
                    case 8:
                        m.updateSalary();
                        break;
                    case 9:
                        return;



                }
            }




        }
    }
}
