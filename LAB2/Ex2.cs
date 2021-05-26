using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class Ex2
    {
        
        public static void RunEx2()
        {
            List<Player> listPlayer = new List<Player>();
            List<Coach> listCoach = new List<Coach>();
            ManageEx2 m = new ManageEx2();

            Console.WriteLine("1. Input a list of players ");
            Console.WriteLine("2. Input a list of coaches ");
            Console.WriteLine("3. Show list of players");
            Console.WriteLine("4. Show list of coaches");
            Console.WriteLine("5. Update the information of players");
            Console.WriteLine("6. Count the coaches that have years of experience >=3");
            Console.WriteLine("7. Sum of the salary of the players that are the striker. ");
            Console.WriteLine("8. Who have the max salary?");
            Console.WriteLine("9. Sort the list of players by ascending shirt number");
            Console.WriteLine("10.Sort descending salaries of experienced coaches =3 ");
            while (true)
            {
                Console.Write("Enter choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter code : ");
                        string code = Validate.inputString();
                        Console.Write("Enter name :");
                        string name = Validate.inputString();
                        Console.Write("Enter address : ");
                        string address = Validate.inputString();
                        Console.Write("Enter position : ");
                        string position = Validate.inputString();
                        Console.Write("Enter shirt number : ");
                        int number = Validate.inputInt();
                        Console.Write("Enter salary : ");
                        double salary = Validate.inputDouble();


                        m.addPlayers(listPlayer, code, name, address, number, position, salary);
                        Console.WriteLine("Add successful ! ");
                        break;
                    case 2:
                        Console.Write("Enter code : ");
                        string code1 = Validate.inputString();
                        Console.Write("Enter name :");
                        string name1 = Validate.inputString();
                        Console.Write("Enter address : ");
                        string address1 = Validate.inputString();
                        Console.Write("Enter position : ");
                        string position1 = Validate.inputString();
                        Console.Write("Enter years of experience : ");
                        int number1 = Validate.inputInt();
                        Console.Write("Enter salary : ");
                        double salary1 = Validate.inputDouble();


                        m.addCoaches(listCoach, code1, name1, address1, number1, position1, salary1);

                        break;
                    case 3:
                        m.showPlayer(listPlayer);
                        break;
                    case 4:
                        m.sortCoach(listCoach);
                        break;



                }

            }


        }




    }
}
