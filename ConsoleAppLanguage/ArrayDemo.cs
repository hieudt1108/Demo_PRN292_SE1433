//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace ConsoleAppLanguage
//{
//    class ArrayDemo
//    {
        
//        public static Boolean songuyento(int n)
//        {
//            bool check = true;
//            for (int i = 2; i < n; i++)
//                if (n % i == 0) check = false;
//            if (check) return true;
//            else return false;
//        }
//        public void inputArray(int[] a, int n)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("a[" + i + "]=");
//                a[i] = int.Parse(Console.ReadLine());
//            }


//            Console.Write("Hien thi mang:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write(a[i] + " ");
//            }


//            int maxValue = a[0];
//            for (int i = 1; i < n; i++)
//            {
//                if (a[i] > maxValue)
//                {
//                    maxValue = a[i];
//                }
//            }
//            Console.WriteLine("");
//            Console.Write("Hien thi so lon nhat :");
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i] == maxValue)
//                {
//                    Console.Write(i + " ");
//                }
//            }

//            Console.WriteLine("");
//            Console.Write("Cac so nguyen to trong mang ");
//            for (int i = 0; i < n; i++)
//            {
//                int number = a[i];
//                if (songuyento(number))
//                {
//                    Console.WriteLine(number);
//                }
//            }


//            for (int i = 0; i < n - 1; i++)
//                for (int j = i + 1; j < n; j++)
//                    if (a[i] > a[j] && a[i] % 2 != 0 && a[j] % 2 != 0)
                        

           

//        }




//    }
//}






