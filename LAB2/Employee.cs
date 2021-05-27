using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Employee
    {
        private string _code;
        private string _name;
        private DateTime _dob;
        private string _gender;
        private int _numberChild;
        private double _salary;

        public Employee()
        {
        }

        public Employee(string code, string name, DateTime dob, string gender, int numberChild, double salary)
        {
            Code = code;
            Name = name;
            Dob = dob;
            Gender = gender;
            NumberChild = numberChild;
            Salary = salary;
        }

        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Dob { get => _dob; set => _dob = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int NumberChild { get => _numberChild; set => _numberChild = value; }
        public double Salary { get => _salary; set => _salary = value; }



        public string show()
        {
            return Code + "\t" + Name + "\t" + Dob.ToString("MM-dd-yyyy") + "\t\t" + Gender + "\t\t" + NumberChild + "\t\t\t\t" + Salary;
        }


        public double Income()
        {
            double allowance;


            if(NumberChild == 0)
            {
                allowance = 0;
            }else if( NumberChild <= 2)
            {
                allowance = 1;

            }
            else
            {
                allowance = 1.5;
            }

            return Salary + allowance;
        }


    }
}
