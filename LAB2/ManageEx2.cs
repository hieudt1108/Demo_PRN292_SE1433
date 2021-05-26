using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    class ManageEx2 : IManger
    {
        public void addCoaches(List<Coach> listCoach, string code, string name, string address, int years, string postion, double salary)
        {
            listCoach.Add(new Coach(code, name, address, postion, salary, years));
        }

        public void addPlayers(List<Player> listPlayer, string code, string name, string address, int shirtNumber, string postion, double salary)
        {
            listPlayer.Add(new Player(code, name, address, postion, salary, shirtNumber));

            
        }

        public void countCoach(List<Coach> listCoach)
        {
            throw new NotImplementedException();
        }

        public void maxSalary(List<Player> listPlayer, List<Coach> listCoach)
        {
            throw new NotImplementedException();
        }

        public void showCoach(List<Coach> listCoach)
        {
            foreach (var item in listCoach)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void showPlayer(List<Player> listPlayer)
        {
            foreach (var item in listPlayer)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void sortCoach(List<Coach> listCoach)
        {
            throw new NotImplementedException();
        }

        public void sortPlayer(List<Player> listPlayer)
        {
            throw new NotImplementedException();
        }

        public void sumSalary(List<Player> listPlayer)
        {
            throw new NotImplementedException();
        }

        public void updatePlayer(List<Player> listPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
