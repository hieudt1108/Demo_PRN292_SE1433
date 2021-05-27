using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    interface IManger
    {

        void addPlayers(List<Player>listPlayer, int code, string name, string address,int shirtNumber, string postion, double salary);
        void addCoaches(List<Coach> listCoach, int code, string name, string address, int years, string postion, double salary);
        void showPlayer(List<Player> listPlayer);
        void showCoach(List<Coach> listCoach);

        void changePlayer(List<Player> listPlayer,int playercode,int option,int shirtnumber,double salary);

        void countCoach(List<Coach> listCoach);
        void sumSalary(List<Player> listPlayer);

        void showMaxSalary(List<Player> listPlayer, List<Coach> listCoach);
        void sortPlayer(List<Player> listPlayer);
        void sortCoach(List<Coach> listCoach);


    }
}
