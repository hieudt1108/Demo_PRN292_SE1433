using System;
using System.Collections.Generic;

namespace ConsoleAppOOP
{
    internal class MyList
    {
        public List<Student> list;

        public MyList(List<Student> list)
        {
            this.list = list;
        }

        internal  void showList()
        {
            foreach (var item in list)
            {
                item.show();
            }
        }

        internal void addStudent(List<Student> list)
        {
            Console.Write("Enter student id : ");
            string id = Validate.inputString();
            if (Validate.checkDuplicate(list, id))
            {

            }
            else
            {
                Console.WriteLine("Duplicate ID !!");
                return;
            }

            Console.Write("Enter student name :");
            string name = Validate.inputString();
            Console.Write("Enter math scores");
            double mathScore = Validate.inputDouble();
            Console.WriteLine("Enter literature scores");
            double litScore = Validate.inputDouble();


            list.Add(new Student(id, name, mathScore, litScore));
            Console.WriteLine("Add Successful !");
        }
    }
}