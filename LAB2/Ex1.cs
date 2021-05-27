using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Ex1
    {
        public static void RunEx1()
        {
            Console.Write("Enter width : ");
            double width = Validate.inputDouble();
            Console.Write("Enter length : ");
            double length = Validate.inputDouble();

            HinhChuNhat m = new HinhChuNhat(length, width);

            Console.WriteLine(m.show());
            Console.ReadLine();
        }



    }
}
