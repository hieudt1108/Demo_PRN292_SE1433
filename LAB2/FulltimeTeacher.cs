using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class FulltimeTeacher : Teacher
    {

        private double sCoefficient;

        public double SCoefficient { get => sCoefficient; set => sCoefficient = value; }

        public FulltimeTeacher()
        {
        }

        public FulltimeTeacher(string code , string name ,double sCoefficient) : base(code, name)
        {
            
            SCoefficient = sCoefficient;
        }

        public string show()
        {
          return  base.show()+ "\t" + SCoefficient;
        }

        public override double getSalary()
        {
            return sCoefficient * 2000000;
        }
    }
}
