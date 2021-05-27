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
            while (true)
            {
                Console.Write("Enter Excercise : ");
                n = Validate.inputIntChoice(1, 4);

                switch (n)
                {
                    case 1:
                        Ex1.RunEx1();
                        break;
                    case 2:
                        Ex2.RunEx2();
                        break;
                    case 3:
                        TestMain.MainEx3();
                        break;
                }
            }
        }
    }
}
