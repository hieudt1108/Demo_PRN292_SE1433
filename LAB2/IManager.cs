using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    interface IManager
    {

        void importAndDisplay(List<Teacher> listT, string code, string name, double salaryC, int slot,int option);
        void showHighestSalary(List<Teacher> listT);
        int countTeacher(List<Teacher> listT);
        int totalParttime(List<Teacher> listT);
        void sortTeacher(List<Teacher> listT);
        void showTeacherStartT(List<Teacher> listT);
        void displayList(List<Teacher> listT);
    }
}
