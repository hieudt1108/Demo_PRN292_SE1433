using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppLanguage
{
    class FileDemo
    {
        public static List<String> readFile(String filename)
        {

            List<String> list = new List<string>();
            try
            {
                //C1
                using (StreamReader sr = new StreamReader(filename))
                {
                    String str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        list.Add(str);
                    }



                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Loi khi doc file!");
                Console.WriteLine(e.Message);
            }
            return list;
        }

        public static void writeFile(String filename, List<String> List)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (String item in List)
                    {
                        sw.WriteLine(item+",");
                    }
                   
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Loi khi ghi file ");
                Console.WriteLine(e.Message);
            }
        }

        public static void readFile2(String filename)
        {

       
            try
            {
                //C1
                using (StreamReader sr = new StreamReader(filename))
                {
                    String str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }



                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Loi khi doc file!");
                Console.WriteLine(e.Message);
            }
           
        }


    }
}
