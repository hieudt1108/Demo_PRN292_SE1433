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

            listPlayer.Add(new Player(1, "Doan Trung Hieu", "HN", "Striker", 22.2, 2));
            listPlayer.Add(new Player(2, "Nguyen Van    A", "HN", "Striker", 22.2, 1));


            listCoach.Add(new Coach(3, "Nguyen Van    B", "HN", "Striker", 11, 3));
            listCoach.Add(new Coach(4, "Nguyen Van    C", "HN", "Striker", 11, 2));
            listCoach.Add(new Coach(5, "Nguyen Van    D", "HN", "Striker", 12, 3));
            listCoach.Add(new Coach(6, "Nguyen Van    E", "HN", "Striker", 11, 1));
            listCoach.Add(new Coach(7, "Nguyen Van    F", "HN", "Striker", 11, 5));
            listCoach.Add(new Coach(8, "Nguyen Van    G", "HN", "Striker", 13, 3));


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
                int choice = Validate.inputIntChoice(1, 10);

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter code : ");
                        int code = Validate.inputInt();
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
                        int code1 = Validate.inputInt();
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
                        m.showCoach(listCoach);
                        break;
                    case 5:
                        Console.Write("Enter player code : ");
                        int playerCode = Validate.inputInt();
                        Console.Write("Enter option : ");
                        int option = Validate.inputIntChoice(0, 1);
                        Console.WriteLine("Enter new shirtNumber : ");
                        int newNumber = Validate.inputInt();
                        Console.WriteLine("Enter new Salary");
                        double newSalary = Validate.inputDouble();
                        m.changePlayer(listPlayer, playerCode, option, newNumber, newSalary);
                        break;
                    case 6:
                        m.countCoach(listCoach);
                        break;
                    case 7:
                        m.sumSalary(listPlayer);
                        break;
                    case 8:
                        m.showMaxSalary(listPlayer, listCoach);
                        break;
                    case 9:
                        m.sortPlayer(listPlayer);
                        break;
                    case 10:
                        m.sortCoach(listCoach);
                        break;




                }
                Console.ReadKey();
            }


        }




    }
}
