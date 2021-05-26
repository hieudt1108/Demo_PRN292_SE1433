using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LAB1
{
    class Handling
    {
        public static string inputString()
        {
            while (true)
            {
                String n = "";
                try
                {
                    n = Console.ReadLine().Trim();
                    return n;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.Write("Enter again : ");

                }
            }
            return null;
        }
        public static int inputInt()
        {
            while (true)
            {
                int n = 0;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    return n;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.Write("Enter again : ");

                }
            }
            return 0;
        }

        public static int inputIntChoice(int min , int max)
        {
            while (true)
            {
                int n = 0;
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if(n < min || n > max)
                    {
                        throw new Exception();
                    }
                    return n;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.Write("Enter again : ");

                }
            }
            return 0;
        }

        public static String inputBinary()
        {
            while (true)
            {
                String n = "";
                try
                {
                    n = Console.ReadLine().Trim();

                    for (int i = 0; i < n.Length; i++)
                    {
                        if (Regex.IsMatch(n[i]+"", "[0-1]"))
                        {

                        }
                        else
                        {
                            throw new Exception();
                        }
                    }



                    return n;
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.Write("Enter again : ");

                }
            }
            return null;
        }

        public static Boolean isComposite(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }

            }
            if (count > 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Boolean IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
