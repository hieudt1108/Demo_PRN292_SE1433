using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Coach : Person
    {
        private int _yearEx;

        public Coach()
        {
        }

        public Coach(string code, string name, string address, string position, double salary, int yearEx) : base(code, name, address,  position,  salary)
        {
            this.YearEx = yearEx;
        }

        public int YearEx { get => _yearEx; set => _yearEx = value; }

        public string ToString()
        {
            return base.ToString() + "\t" + _yearEx;
        }
    }
}
