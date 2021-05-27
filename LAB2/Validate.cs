using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Validate
    {
        public static string inputString()
        {


            while (true)
            {
                try
                {

                    string n = Console.ReadLine();
                    return n;
                }
                catch (Exception e)
                {
                    Console.Write("Enter again : ");
                }
            }
        }

        public static double inputDouble()
        {
            while (true)
            {
                try
                {
                    double n = Convert.ToDouble(Console.ReadLine());
                    return n ;
                }
                catch (Exception e)
                {

                    Console.Write("Enter again : ");
                }
            }
        }



        public static int inputInt()
        {
            while (true)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    return n;
                }
                catch (Exception e)
                {

                    Console.Write("Enter again : ");
                }
            }
        }

        public static int inputIntChoice(int min , int max)
        {
            while (true)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    if(n<min || n > max)
                    {
                        throw new Exception();
                    }
                    return n;
                }
                catch (Exception e)
                {

                    Console.Write("Enter again : ");
                }
            }
        }


    }
}
