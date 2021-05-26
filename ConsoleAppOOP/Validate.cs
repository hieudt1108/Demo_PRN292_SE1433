using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOOP
{
     class Validate 
    {

        public List<Student> listCheck;

        public Validate(List<Student> listCheck)
        {
            this.listCheck = listCheck;
        }

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
                }
                catch (Exception e )
                {

                    Console.Write("Enter again : ");
                }
            }
        }

        public static bool checkDuplicate(List<Student> listCheck,String id )
        {
            foreach (var item in listCheck)
            {
                if (item.Code.Equals(id))
                {
                    return false;
                }
            }
            return true;
        }
      

 



    }


        
}

