using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Person
    {

        private int _code;
        private string _name;
        private string _address;
        private string _position;
        private double _salary;

        public Person()
        {
        }

        public Person(int code, string name, string address, string position, double salary)
        {
            Code = code;
            Name = name;
            Address = address;
            Position = position;
            Salary = salary;
        }

        public int Code { get => _code; set => _code = value; }
        public string Name { get => _name; set => _name = value; }
        public string Address { get => _address; set => _address = value; }
        public string Position { get => _position; set => _position = value; }
        public double Salary { get => _salary; set => _salary = value; }

        public string ToString()
        {
            return _code + "\t" + _name + "\t" + _address + "\t" + _position + "\t\t" + _salary;
        }
    }
}
