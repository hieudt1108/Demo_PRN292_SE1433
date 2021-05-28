using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Manager : IManager
    {
        public int countTeacher(List<Teacher> listT)
        {
            int count = 0;
            foreach (var item in listT)
            {
                if (typeof(ParttimeTeacher).IsInstanceOfType(item))
                {
                    ParttimeTeacher a = (ParttimeTeacher)item;
                    if(a.Slot> 10)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void displayList(List<Teacher> listT)
        {
            Console.WriteLine("List of fulltime teachers with the salary coefficient < 3");

            Console.WriteLine("LastName\tFirstName");
            foreach (var item in listT)
            {
                if (typeof(FulltimeTeacher).IsInstanceOfType(item))
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    if (a.SCoefficient < 3)
                    {
                        string[] arrListS = item.Name.Split(' ');
                        Console.WriteLine(arrListS[0] + "\t\t" + arrListS[arrListS.Length - 1]);
                    }
                }
                
            }
        }

        public void importAndDisplay(List<Teacher> listT, string code, string name, double salaryC, int slot, int option)
        {

         
            if (option == 1)
            {
                listT.Add(new FulltimeTeacher(code, name, salaryC));
                Console.WriteLine("Add done !!");
            }
            else
            {
                listT.Add(new ParttimeTeacher(code, name, slot));
                Console.WriteLine("Add done !!");
            }

            

            

            Console.WriteLine("Teacher part time ");

            Console.WriteLine("Code\tName\t\t\tSlot");
            foreach (var item in listT)
            {
                if (typeof(ParttimeTeacher).IsInstanceOfType(item))
                {
                    ParttimeTeacher a = (ParttimeTeacher)item;
                    Console.WriteLine(a.show());
                }
            }

            Console.WriteLine("Teacher full time ");

            Console.WriteLine("Code\tName\t\tsCoefficient");
            foreach (var item in listT)
            {
                if (typeof(FulltimeTeacher).IsInstanceOfType(item))
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    Console.WriteLine(a.show());
                }
            }


        }

        public void showHighestSalary(List<Teacher> listT)
        {

            double maxSalary = 0;
            foreach (var item in listT)
            {
                if (typeof(ParttimeTeacher).IsInstanceOfType(item))
                {
                    ParttimeTeacher a = (ParttimeTeacher)item;
                    if (a.getSalary() > maxSalary)
                    {
                        maxSalary = a.getSalary();
                    }
                } 
            }

            foreach (var item in listT)
            {
                if (typeof(FulltimeTeacher).IsInstanceOfType(item))
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    if (a.getSalary() > maxSalary)
                    {
                        maxSalary = a.getSalary();
                    }
                }
            }

            Console.WriteLine($"Highest salary : {maxSalary}  ");

            Console.WriteLine("Code\tName\t\t\tSalary ");


            foreach (var item in listT)
            {
                if (typeof(ParttimeTeacher).IsInstanceOfType(item))
                {
                    ParttimeTeacher a = (ParttimeTeacher)item;
                    if (a.getSalary() == maxSalary)
                    {
                        Console.WriteLine(item.Code + "\t" + item.Name + "\t" + maxSalary);
                    }
                }
            }

            foreach (var item in listT)
            {
                if (typeof(FulltimeTeacher).IsInstanceOfType(item))
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    if (a.getSalary() == maxSalary)
                    {
                        Console.WriteLine(item.Code + "\t" + item.Name + "\t" + maxSalary);
                    }
                }
            }
          


        }

        public void showTeacherStartT(List<Teacher> listT)
        {
            


            Console.WriteLine("Teacher start with 'T' ");
            Console.WriteLine("Name\t\t\tSalary");

            foreach (var item in listT)
            {

                if (typeof(FulltimeTeacher).IsInstanceOfType(item))
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    string[] arrListS = a.Name.Split(' ');
                    string name = arrListS[arrListS.Length - 1];

                    if (name.StartsWith("T"))
                    {
                        Console.WriteLine(a.Name + "\t" + a.getSalary());
                    }
                }
                else
                {
                    
                        ParttimeTeacher a = (ParttimeTeacher)item;
                        string[] arrListS = a.Name.Split(' ');
                        string name = arrListS[arrListS.Length - 1];

                        if (name.StartsWith("T"))
                        {
                            Console.WriteLine(a.Name + "\t" + a.getSalary());
                        }
                    }
                }


                
            }


           



        

        public void sortTeacher(List<Teacher> listT)
        {
            List<TeacherSalary> listS = new List<TeacherSalary>();


            foreach (var item in listT)
            {
                if (typeof(FulltimeTeacher).IsInstanceOfType(item))
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    listS.Add(new TeacherSalary(a.Code, a.Name, a.getSalary()));

                }
                else
                {
                    FulltimeTeacher a = (FulltimeTeacher)item;
                    listS.Add(new TeacherSalary(a.Code, a.Name, a.getSalary()));
                }
            }
          

            Console.WriteLine("List teacher increase by salary");
            List<TeacherSalary> sorted = listS.OrderBy(t => t.Salary).ToList();
            Console.WriteLine("Code\tName\t\tSalary ");
            foreach (var item in sorted)
            {
                Console.WriteLine(item.show());
            }

        }

        public int totalParttime(List<Teacher> listT)
        {
            int count = 0;
            
            foreach (var item in listT)
            {
                if (typeof(ParttimeTeacher).IsInstanceOfType(item))
                {
                    ParttimeTeacher a = (ParttimeTeacher)item;
                    count += a.Slot;
                }
            }
           
            return count;
        }
    }
}
