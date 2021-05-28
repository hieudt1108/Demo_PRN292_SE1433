using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Manger : IMangerEx3
    {
        List<Employee> listE;

        public Manger(List<Employee> listE)
        {
            this.listE = listE;
        }


        public int count()
        {
            int count = 0;
            foreach (var item in listE)
            {
                if (item.Gender.Equals("Female") && item.NumberChild == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void delete(int n)
        {

            listE.RemoveAll(x => x.Gender.Equals("Male") && x.NumberChild > n);


            Console.WriteLine("Code\tname\t\t\tdate of birth\t\tgender\t\tnumber of children\t\tsalary");
            foreach (var item in listE)
            {
                Console.WriteLine(item.show());
            }
        }

        public void inputList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter code : ");
                string code = Validate.inputString();
                if (!Validate.checkDuplicateIdEx3(listE, code))
                {
                    Console.WriteLine("Duplicate code !!");
                    break;
                }
                Console.Write("Enter name : ");
                string name = Validate.inputString();
                Console.Write("Enter date of birth follow MM-dd-yyyy  or MM/dd/yyyy: ");
                DateTime dob = Validate.inputDob();
                Console.Write("Enter 1 for male or 0 for female : ");
                int choice = Validate.inputIntChoice(0, 1);
                string gender;
                if (choice == 1)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                Console.Write("Enter number of children : ");
                int child = Validate.inputInt();
                Console.Write("Enter salary : ");
                double salary = Validate.inputDouble();
                listE.Add(new Employee(code, name, dob, gender, child, salary));
            }

        }

        public void showByName(string name)
        {
            List<Employee> newList = new List<Employee>();

            foreach (var item in listE)
            {
                if (item.Name.ToUpper().Contains(name.ToUpper()))
                {
                    newList.Add(item);
                }
            }
            Console.WriteLine("Code\tname\t\t\tdate of birth\t\tgender\t\tnumber of children\t\tsalary");
            foreach (var item in newList)
            {
                Console.WriteLine(item.show());
            }

        }

        public void showList()
        {
            Console.WriteLine("Code\tname\t\t\tdate of birth\t\tgender\t\tnumber of children\t\tsalary");
            foreach (var item in listE)
            {
                Console.WriteLine(item.show());
            }
        }

        public void showSocon(int n)
        {
            Console.WriteLine("Code\tname\t\t\tdate of birth\t\tgender\t\tnumber of children\t\tsalary");
            foreach (var item in listE)
            {
                if (item.NumberChild < n)
                {
                    Console.WriteLine(item.show());
                }
            }
        }

        public void sortBySalary()
        {
            var listSort = listE.Where(l => l.Gender.Equals("Male")).OrderBy(l => l.Salary).ToList();
            int index = 0;
            List<Employee> newSort = listE;
            for (int i = 0; i < newSort.Count; i++)
            {
                if (newSort[i].Gender.Equals("Male"))
                {
                    newSort[i] = listSort[index];
                    index++;
                }
            }
            Console.WriteLine("Code\tname\t\t\tdate of birth\t\tgender\t\tnumber of children\t\tsalary");
            foreach (var item in newSort)
            {
                Console.WriteLine(item.show());
            }


        }

        public void updateSalary()
        {
            List<Employee> listUpdate = listE;
            DateTime now = DateTime.Today;
            int age;
            foreach (var item in listUpdate)
            {
                age = (Int32.Parse(DateTime.Today.ToString("yyyyMMdd")) - Int32.Parse(item.Dob.ToString("yyyyMMdd"))) / 10000;

                if (age < 30)
                {
                    item.Salary = item.Salary + (item.Salary * (0.05));
                }
                else if (age >= 30 && age < 40)
                {
                    item.Salary = item.Salary + (item.Salary * (0.1));
                }
                else
                {
                    item.Salary = item.Salary + (item.Salary * (0.15));
                }
            }
            Console.WriteLine("Code\tname\t\t\tdate of birth\t\tgender\t\tnumber of children\t\tsalary");
            foreach (var item in listUpdate)
            {
                Console.WriteLine(item.show());
            }


        }
    }
}
