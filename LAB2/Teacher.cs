using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    abstract class Teacher
    {
        private string _code;
        private string _name;

        public Teacher()
        {
        }

        public Teacher(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public string Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }


        public string show()
        {
           return Code + "\t" + Name;
        }
        public abstract double getSalary();
    }
}
