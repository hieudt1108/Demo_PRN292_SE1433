using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class LAB2
    {
        static void Main(string[] args)
        {


            int n;
            Console.Write("Enter Choice: ");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Ex1.printInfor();
                    break;
                case 2:
                    Ex2.RunEx2();
                    break;

                    

            }
        }
    }
}
