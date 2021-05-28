using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Validate
    {

        public static bool checkDuplicateCodeEx4(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP, string code)
        {

            foreach (var item in listF)
            {
                if (item.Code.Equals(code))
                {
                    return false;
                }
            }
            foreach (var item in listP)
            {
                if (item.Code.Equals(code))
                {
                    return false;
                }
            }

            return true;

        }


        public static DateTime inputDob()
        {
            DateTime dt;
            while (true)
            {
                try
                {
                    string n = Console.ReadLine().Trim();
                    if (String.IsNullOrEmpty(n))
                    {
                        throw new Exception();
                    }
                   return  dt = DateTime.Parse(n);
                }
                catch (Exception)
                {
                    Console.Write("Enter again : ");
                    
                }

            }
        }


        public static bool checkDuplicateIdEx3(List<Employee> list , string code)
        {
            foreach (var item in list)
            {
                if (item.Code.Equals(code))
                {
                    return false;
                }
            }
            return true;
        }



        public static string inputString()
        {


            while (true)
            {
                try
                {

                    string n = Console.ReadLine().Trim();
                    if (String.IsNullOrEmpty(n))
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

        public static bool checkDuplicateCodeEx2(List<Player> listPlayer, List<Coach> listCoach,int code ) {

            foreach (var item in listCoach)
            {
                if(item.Code== code)
                {
                    return false;
                }
            }
            foreach (var item in listPlayer)
            {
                if (item.Code == code)
                {
                    return false;
                }
            }

            return true;

        }

        public static bool checkDuplicateShirtNumber(List<Player> listPlayer,int shirt)
        {
            foreach (var item in listPlayer)
            {
                if(item.ShirtNumber == shirt)
                {
                    return false;
                }
            }


            return true;
        }

        

    }
}
