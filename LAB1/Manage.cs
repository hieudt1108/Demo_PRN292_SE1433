using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1
{
    public static class Manage
    {




        public static void Ex1()
        {
            int i = 0;
            while (i < 100)
            {
                if (Handling.isComposite(i))
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
                i++;
            }
        }

        public static void Ex2()
        {


            int count = 0;
            int n = 1;
            do
            {

                if (Handling.IsPrime(n))
                {
                    count++;
                    if (count > 1)
                    {
                        Console.Write($"{n}  ");
                    }
                }
                n++;
            } while (count < 11);
        }

        public static void Ex3()
        {
            Console.WriteLine("Divided by 2: ");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Divided by 4: ");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Divided by 6: ");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 6 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Ex4()
        {
            Console.WriteLine("First 4 perfect numbers : ");
            int count = 0;
            int n = 6;
            do
            {
                int sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {


                        sum = sum + i;



                    }

                }

                if (n == sum)
                {
                    Console.Write(n + " ");
                    count++;
                }
                n++;
            } while (count < 4);
        }

        public static void Ex5()
        {
            int n = 100;
            int sum1 = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 5 == 0)
                {
                    sum1++;
                }
            }
            Console.WriteLine($"Total numbers divided by 5 : {sum1}");
            int sum2 = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 5 == 2)
                {
                    sum2++;
                }
            }
            Console.WriteLine($"Total numbers divided by 5 with the remainder 2 : {sum2}");

            Console.Write("The end digit is “5”. :");

            for (int i = 0; i < n; i++)
            {

                String number = "5";
                String number2 = Handling.ReverseString(i.ToString());
                if (number2.StartsWith(number))
                {
                    Console.Write(Convert.ToInt32(Handling.ReverseString(number2)) + " ");
                }
            }



        }

        public static void Ex6()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.Write($"{n} = 1 ");
            }
            else
            {
                int a = n;
                List<int> arr = new List<int>();
                for (int i = 2; i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        arr.Add(i);
                        n /= i;
                    }
                }



                if (arr.Count == 1)
                {
                    Console.WriteLine($"{ a}= {arr[0]}*1 ");
                }
                else
                {
                    Console.Write($"{a} = ");
                    for (int i = 0; i < arr.Count; i++)
                    {
                        if (i == arr.Count - 1)
                        {
                            Console.Write(arr[i]);
                        }
                        else
                        {
                            Console.Write(arr[i] + "*");
                        }
                    }
                }

            }
        }

        public static void Ex7()
        {
            Console.Write("Enter size of array: ");
            int sizeArray = Handling.inputInt();
            int[] a = new int[100];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("Enter number" + "[" + i + "]" + ":");
                a[i] = Handling.inputInt();
            }

            Console.Write("Array : ");
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Sorted Array: ");

            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = i + 1; j < sizeArray; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }



            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write(a[i] + " ");
            }



        }

        public static void Ex8()
        {
            Console.Write("Enter size of array: ");
            int sizeArray = Handling.inputInt();
            int[] a = new int[100];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("Enter number" + "[" + i + "]" + ":");
                a[i] = Handling.inputInt();
            }

            Console.Write("Prime numbers : ");
            for (int i = 0; i < sizeArray; i++)
            {
                if (Handling.IsPrime(a[i]))
                {
                    Console.Write(a[i] + "  ");
                }
            }

        }

        public static void Ex9()
        {
            int countPrime = 0;
            int countComp = 0;

            Console.Write("Enter size of array: ");
            int sizeArray = Handling.inputInt();
            int[] a = new int[100];
            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("Enter number" + "[" + i + "]" + ":");
                a[i] = Handling.inputInt();
            }
            for (int i = 0; i < sizeArray; i++)
            {
                if (Handling.IsPrime(a[i]))
                {
                    countPrime++;
                }
            }
            for (int i = 0; i < sizeArray; i++)
            {
                if (Handling.isComposite(a[i]))
                {
                    countComp++;
                }
            }

            Console.Write("Prime : " + countPrime);
            Console.WriteLine();
            Console.Write("Composite : " + countComp);



        }


        public static void Ex10()
        {
            Console.Write("Enter full name : ");
            String fullname = Handling.inputString();

            string[] arrListS = fullname.Split(' ');
            String firstname = arrListS[arrListS.Length - 1];
            String lastname = arrListS[0];
            Console.WriteLine("First name : " + firstname);
            Console.WriteLine("Last name : " + lastname);
        }

        public static void Ex11()
        {
            Console.Write("Enter String : ");
            String input = Handling.inputBinary();
            String change = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '0')
                {
                    change = change + "1";
                }
                else
                {
                    change = change + "0";
                }
            }

            int result = Convert.ToInt32(change);
            Console.Write("Result : " + result);


        }

        public static void Ex12()
        {
            Console.Write("Size of Array : ");
            int n = Handling.inputInt();
            string[] arrayNew = new string[100];
            string[] arrayList = new string[n];
            for (int i = 0; i < arrayList.Length; i++)
            {
                Console.Write("Enter string " + "[" + i + "]" + ":");
                arrayList[i] = Handling.inputString();
            }

            int maxSize = 0;
            int index = 0;
            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i].Length > maxSize)
                {
                    maxSize = arrayList[i].Length;
                    index = i;
                }
            }

            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i].Length == maxSize)
                {
                    arrayNew[i] = arrayList[i];
                }
            }
            Console.Write("Longest String : " );
            for (int i = 0; i < arrayNew.Length; i++)
            {
                Console.Write(arrayNew[i]+ " ");
            }

        }

        public static void Ex13()
        {
            List<String> list = new List<string>();
            Console.Write("Enter the number of students : ");
            int numbers = Handling.inputInt();
            int count = 0;
            for (int i = 0; i < numbers; i++)
            {
                Console.Write($"Student [{i}]: ");
                list.Add(Handling.inputString());
            }


            String key = "Yen";
            foreach (string item in list)
            {
                string[] arrListS = item.Split(' ');
                String firstname = arrListS[arrListS.Length - 1];
                if (firstname.ToUpper().Equals(key.ToUpper()))
                {
                    count++;
                }
            }

            Console.WriteLine($"Students that first name’s {key}: {count}");


        }

        public static void Ex14()
        {
            List<String> list = new List<string>();
            Console.Write("Enter the number of students : ");
            int numbers = Handling.inputInt();
            int count = 0;
            for (int i = 0; i < numbers; i++)
            {
                Console.Write($"Student [{i}]: ");
                list.Add(Handling.inputString());
            }

            String key = "Van";
            foreach (string item in list)
            {
                string[] arrListS = item.Split(' ');


                for (int i = 1; i < arrListS.Length - 1; i++)
                {

                    if (arrListS[i].ToUpper().Equals(key.ToUpper()))
                    {
                        count++;
                    }
                }



            }

            Console.WriteLine($"Students that padding name’s {key}: {count}");


        }
        public static void Ex15()
        {
            List<String> list = new List<string>();
            Console.Write("Enter the number of students : ");
            int numbers = Handling.inputInt();
            int count = 0;
            for (int i = 0; i < numbers; i++)
            {
                Console.Write($"Student [{i}]: ");
                list.Add(Handling.inputString());
            }



            foreach (string item in list)
            {
                string[] arrListS = item.Split(' ');
                String lastName = arrListS[0];
                if (lastName.StartsWith("T"))
                {
                    count++;
                }



            }

            Console.WriteLine($"Students lastnames starting with the letter 'T': {count}");
        }



    }
}
