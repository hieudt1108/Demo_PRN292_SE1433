using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Player : Person
    {
        private int _shirtNumber;

        public Player()
        {
        }

        public Player(int code, string name, string address, string position, double salary, int shirtNumber) : base(code, name,  address,  position, salary)
        {
            this.ShirtNumber = shirtNumber;

        }

        public int ShirtNumber { get => _shirtNumber; set => _shirtNumber = value; }

        public  string ToString()
        {
            return base.ToString() + "\t" +_shirtNumber;
        }
    }

}
