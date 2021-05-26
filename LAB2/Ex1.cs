using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Ex1
    {
        public static void printInfor()
        {
            Console.Write("Enter width : ");
            double width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter length : ");
            double length = Convert.ToInt32(Console.ReadLine());

            HinhChuNhat m = new HinhChuNhat(length, width);

            Console.WriteLine(m.show());
            Console.ReadLine();
        }



    }
}
