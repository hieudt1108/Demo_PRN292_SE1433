using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Manager : IManager
    {
        public int countTeacher(List<ParttimeTeacher> listP)
        {
            int count = 0;
            foreach (var item in listP)
            {
                if (item.Slot > 10)
                {
                    count++;
                }
            }
            return count;
        }

        public void displayList(List<FulltimeTeacher> listF)
        {
            Console.WriteLine("List of fulltime teachers with the salary coefficient < 3");

            Console.WriteLine("LastName\tFirstName");
            foreach (var item in listF)
            {
                if (item.SCoefficient < 3)
                {
                    string[] arrListS = item.Name.Split(' ');
                    Console.WriteLine(arrListS[0] + "\t\t" + arrListS[arrListS.Length - 1]);
                }
            }
        }

        public void importAndDisplay(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP, string code, string name, double salaryC, int slot, int option)
        {
            if (option == 1)
            {
                listF.Add(new FulltimeTeacher(code, name, salaryC));
                Console.WriteLine("Add done !!");
            }
            else
            {
                listP.Add(new ParttimeTeacher(code, name, slot));
                Console.WriteLine("Add done !!");
            }

            Console.WriteLine("Teacher full time ");

            Console.WriteLine("Code\tName\t\tSalary Coefficient");
            foreach (var item in listF)
            {
                Console.WriteLine(item.show());
            }


            Console.WriteLine("Teacher part time ");

            Console.WriteLine("Code\tName\t\tSlot");
            foreach (var item in listP)
            {
                Console.WriteLine(item.show());
            }

        }

        public void showHighestSalary(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP)
        {

            double maxSalary = 0;
            foreach (var item in listF)
            {
                if (item.getSalary() > maxSalary)
                {
                    maxSalary = item.getSalary();
                }
            }

            foreach (var item in listP)
            {
                if (item.getSalary() > maxSalary)
                {
                    maxSalary = item.getSalary();
                }
            }

            Console.WriteLine($"Highest salary : {maxSalary}  ");

            Console.WriteLine("Code\tName\t\t\tSalary ");
            foreach (var item in listF)
            {
                if (item.getSalary() == maxSalary)
                {
                    Console.WriteLine(item.Code + "\t" + item.Name + "\t" + maxSalary);
                }
            }

            foreach (var item in listP)
            {
                if (item.getSalary() == maxSalary)
                {
                    Console.WriteLine(item.Code + item.Name + maxSalary);
                }
            }


        }

        public void showTeacherStartT(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP)
        {
            Console.WriteLine("Teacher start with 'T' ");
            Console.WriteLine("Name\t\t\tSalary");

            foreach (var item in listF)
            {
                string[] arrListS = item.Name.Split(' ');
                string name = arrListS[arrListS.Length - 1];

                if (name.StartsWith("T"))
                {
                    Console.WriteLine(item.Name + "\t" + item.getSalary());
                }
            }


            foreach (var item in listP)
            {
                string[] arrListS = item.Name.Split(' ');
                string name = arrListS[arrListS.Length - 1];

                if (name.StartsWith("T"))
                {
                    Console.WriteLine(item.Name + "\t" + item.getSalary());
                }
            }



        }

        public void sortTeacher(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP)
        {
            List<TeacherSalary> listS = new List<TeacherSalary>();


            foreach (var item in listF)
            {
                listS.Add(new TeacherSalary(item.Code, item.Name, item.getSalary()));
            }
            foreach (var item in listP)
            {
                listS.Add(new TeacherSalary(item.Code, item.Name, item.getSalary()));
            }

            Console.WriteLine("List teacher increase by salary");
            List<TeacherSalary> sorted = listS.OrderBy(t => t.Salary).ToList();
            Console.WriteLine("Code\tName\t\tSalary ");
            foreach (var item in sorted)
            {
                Console.WriteLine(item.show());
            }

        }

        public int totalParttime(List<ParttimeTeacher> listP)
        {
            int count = 0;
            foreach (var item in listP)
            {
                count += item.Slot;
            }
            return count;
        }
    }
}
