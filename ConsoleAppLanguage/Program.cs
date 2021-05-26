using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;




namespace ConsoleAppLanguage
{
    class Program
    {


        //static void Main1(string[] args)
        //{
        //    // hien thi du lieu
        //    //Console.WriteLine("Hello world");

        //    //// khai bao bien 
        //    //// if 
        //    //// for 
        //    //// while
        //    //// ham 



        //    //while (true)
        //    //{
        //    //    try
        //    //    {
        //    //        Console.WriteLine("Enter n:");
        //    //        int n = Convert.ToInt32(Console.ReadLine());
        //    //        if (n <= 0)
        //    //        {
        //    //            Console.WriteLine("N phai > 0");
        //    //        }
        //    //        else
        //    //        {
        //    //            Console.WriteLine("Nhap dung roi!");
        //    //            break;
        //    //        }
        //    //    }
        //    //    catch (Exception)
        //    //    {
        //    //        Console.WriteLine("Pls enter a number!");
        //    //    }
        //    //}
        //    //Console.ReadLine();


        //    //Console.WriteLine("n =" + n);
        //    //if (n < 0)
        //    //{
        //    //    Console.WriteLine("n<0");
        //    //}
        //    //else
        //    //{
        //    //    if (n == 0)
        //    //    {
        //    //        Console.WriteLine("n=0");
        //    //    }
        //    //    else
        //    //    {
        //    //        Console.WriteLine("n>0");
        //    //    }
        //    //}
        //    //Console.WriteLine("check");

        //    //if (n < 2)
        //    //{
        //    //    Console.WriteLine(" N is not prime number");
        //    //}
        //    //else
        //    //{
        //    //    Boolean check = false;
        //    //    for (int i = 2; i <= n; i++)
        //    //    {
        //    //        if (n % i == 0)
        //    //        {
        //    //            Console.WriteLine("N is  not prime number");
        //    //            check = true;
        //    //            break;
        //    //        }
        //    //    }
        //    //    if (check = false)
        //    //    {
        //    //        Console.WriteLine("N is prime number");
        //    //    }
        //    //}



        //    //if (n <= 0)
        //    //{
        //    //    Console.WriteLine("Khong co so chinh phuong nao ");

        //    //}
        //    //else
        //    //{
        //    //    int count = 1;
        //    //    int total = 0;
        //    //    for (int i = 1; i < n; i++)
        //    //    {
        //    //        if (i * i < n)
        //    //        {
        //    //            count++;
        //    //            total = total + n;
        //    //        }
        //    //    }

        //    //    Console.WriteLine("Co " + count + "so chinh phuong le");
        //    //    Console.WriteLine(" Total " + total);
        //    //}








        //    int n;
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.WriteLine("Enter n:");
        //            n = Convert.ToInt32(Console.ReadLine());
        //            if (n <= 0)
        //            {
        //                Console.WriteLine("N phai > 0");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Nhap dung roi!");
        //                break;
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("Pls enter a number!");
        //        }

        //    }


        //    // practise:
        //    // 1 kiem tra xem n co phai la so nguyen to ?
        //    // 2 co bao nhieu so chinh phuong le < n
        //    // 3  tong cac so khong phai la chinh phuong chan < n
        //    // Console.Read;Line()

        //    int[] a = new int[100];
        //    ArrayDemo m = new ArrayDemo();

        //    m.inputArray(a, n);


        //    Console.ReadKey();



        //    // 1. hien thi mang vua nhap 
        //    // 2. hien thi nhung phan tu lon nhat trong mang 
        //    // 3. co bao nhieu phan tu la so nguyen to trong mang 
        //    // 4. sap xep mang tang dan nhung phan tu le 

        //}

        //static void Main(string[] args)
        //{
        //    String str = "FPT University";


        //    //1 nhap lai chuoi str tu ban phim 
        //    //1 kiem tra xem chuoi co bao nhieu tu 
        //    //3 check chuoi co phai la chuoi dao nguoc khong 
        //    //4 chuan hoa chuoi (coi Str la chuoi ho ten cua minh)
        //    //5 


        //    int n;
        //    Console.WriteLine("Enter String : ");
        //    str = Ex1();


        //    string[] arrListS1 = str.Split(' ');
        //    Console.WriteLine("So luong tu : "+ arrListS1.Length );
        //    String re = ReverseString(str);
        //    if (str.Equals(re))
        //    {
        //        Console.WriteLine("Palindrome");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Palindrome");
        //    }


        //    string[] arrListS = str.Split(' ');
        //    String name = "";
        //    foreach (string a in arrListS)
        //    {
        //        int count = 0;


        //        for (int i = 0; i < a.Length; i++)
        //        {

        //            if (i == 0)
        //            {
        //                String b = a[i] + "";
        //                name += b.ToUpper();
        //            }
        //            else
        //            {
        //                String c = a[i] + "";
        //                name = name + c.ToLower();
        //            }
        //        }
        //        name += " ";


        //    }
        //    Regex trimmer = new Regex(@"[^a-zA-Z]\s\s+");
        //    string removableChars = Regex.Escape(@"@&'()<>#");
        //    String namefix = trimmer.Replace(name, " ");




        //    Console.WriteLine( " Name : " + namefix);


        //    Console.ReadKey();

        //}







        //public static string ReverseString(string s)
        //{
        //    char[] arr = s.ToCharArray();
        //    Array.Reverse(arr);
        //    return new string(arr);
        //}

        //public static String Ex1()
        //{
        //    String n = Console.ReadLine().Trim();
        //    return n;
        //}


        //    static void Main(string[] args)
        //    {
        //        //thuc hien 2 thao tac doc/ ghi file 
        //        Console.WriteLine( "Noi dung :");


        //        List<String> StringInFile = FileDemo.readFile("../../OutputBt1.txt");

        //        List<String> List = new List<String>();


        //        foreach (String item in StringInFile)
        //        {
        //            string[] arrListS = item.Split(',');
        //            for (int i = 0; i < arrListS.Length; i++)
        //            {
        //                int c = Convert.ToInt32(arrListS[i]);
        //                if (IsPrime(c))
        //                {
        //                    List.Add(arrListS[i]);
        //                }
        //            }
        //        }

        //        FileDemo.writeFile("../../inputBt1.txt", List);


        //        //FileDemo.writeFile("../../inputBt1.txt");
        //        Console.WriteLine("Noi dung file vua ghi  : ");
        //        FileDemo.readFile2("../../inputBt1.txt");
        //        Console.ReadKey();
        //    }

        //    public static Boolean IsPrime(int n)
        //    {
        //        if (n < 2)
        //            return false;
        //        for (int i = 2; i <= Math.Sqrt(n); i++)
        //        {
        //            if (n % i == 0)
        //            {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }

    }
}
