using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class ManageEx2 : IManger
    {
        public void addCoaches(List<Coach> listCoach, int code, string name, string address, int years, string postion, double salary)
        {
            listCoach.Add(new Coach(code, name, address, postion, salary, years));
        }

        public void addPlayers(List<Player> listPlayer, int code, string name, string address, int shirtNumber, string postion, double salary)
        {
            listPlayer.Add(new Player(code, name, address, postion, salary, shirtNumber));

            
        }

        public void countCoach(List<Coach> listCoach)
        {
            int count = 0;
            foreach (Coach item in listCoach)
            {
                if(item.YearEx >= 3)
                {
                    count++;
                }
            }

            Console.WriteLine($"The coaches that have years of experience >=3: {count} " );
        }

        public void showMaxSalary(List<Player> listPlayer, List<Coach> listCoach)
        {
            double maxSalary=0;

            foreach (Player item in listPlayer)
            {
                if (item.Salary > maxSalary)
                {
                    maxSalary = item.Salary;
                }
            }
            foreach (Coach item in listCoach)
            {
                if (item.Salary > maxSalary)
                {
                    maxSalary = item.Salary;
                }
            }
            Console.WriteLine("Who have the max salary? :  ");

            foreach (Player item in listPlayer)
            {
                if (item.Salary == maxSalary)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            foreach (Coach item in listCoach)
            {
                if (item.Salary == maxSalary)
                {
                    Console.WriteLine(item.ToString());
                }
            }


        }

        public void showCoach(List<Coach> listCoach)
        {
            foreach (Coach item in listCoach)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void showPlayer(List<Player> listPlayer)
        {
            foreach (Player item in listPlayer)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void sortCoach(List<Coach> listCoach)
        {
            var sortCoach = listCoach.Where(l => l.YearEx == 3).OrderByDescending(l => l.Salary).ToList();
            int index = 0;

            List<Coach> listCoach2 = listCoach;

            for (int i = 0; i < listCoach2.Count; i++)
            {
                if(listCoach2[i].YearEx == 3)
                {
                    listCoach2[i] = sortCoach[index];
                    index++;
                }
            }


            foreach (Coach item in listCoach2 )
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void sortPlayer(List<Player> listPlayer)
        {
            var sortPlayer = listPlayer.OrderBy(l => l.ShirtNumber);

            foreach (Player item in sortPlayer)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void sumSalary(List<Player> listPlayer)
        {
            double sum = 0;
            foreach (Player item in listPlayer)
            {
                if (item.Position.ToUpper().Equals("STRIKER"))
                {
                    sum += item.Salary;
                }
            }
            Console.WriteLine($"Sum of the salary of the players that are the striker :{sum} ");
        }

        public void changePlayer(List<Player> listPlayer, int playercode, int option, int shirtnumber, double salary)
        {
            foreach (Player item in listPlayer)
            {
                if(item.Code== playercode)
                {
                    if(option == 0)
                    {
                        if (item.ShirtNumber == shirtnumber)
                        {
                            Console.WriteLine("No change !!!");
                        }
                        else
                        {
                            item.ShirtNumber = shirtnumber;
                            Console.WriteLine("Update Done !");
                        }
                    }
                    else
                    {
                        if (item.Salary == salary)
                        {
                            Console.WriteLine("No change !!!");
                        }
                        else
                        {
                            item.Salary = salary;
                            Console.WriteLine("Update Done !");
                        }
                    }
                }
            }
        }
    }
}
