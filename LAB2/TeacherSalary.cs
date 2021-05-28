using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class TeacherSalary
    {
        private string _code;
        private string _name;
        private double _salary;

        public TeacherSalary()
        {
        }

        public TeacherSalary(string code, string name, double salary)
        {
            Code = code;
            Name = name;
            Salary = salary;
        }

        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public double Salary { get => _salary; set => _salary = value; }

        public string show()
        {
            return Code + "\t" + Name + "\t" + Salary;
        }


    }
}
