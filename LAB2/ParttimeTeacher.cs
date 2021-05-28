using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class ParttimeTeacher : Teacher
    {

        private int slot;

        public int Slot { get => slot; set => slot = value; }

        public ParttimeTeacher()
        {
        }

        public ParttimeTeacher(string code , string name ,  int slot) : base(code,name)
        {
           
            Slot = slot;
        }


        public string show()
        {
            return base.show() +"\t"+ slot;
        }

        public override double getSalary()
        {
            return slot * 50000;
        }
    }
}
