using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    interface IManager
    {

        void importAndDisplay(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP, string code, string name, double salaryC, int slot,int option);
        void showHighestSalary(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP);
        int countTeacher(List<ParttimeTeacher> listP);
        int totalParttime(List<ParttimeTeacher> listP);
        void sortTeacher(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP);
        void showTeacherStartT(List<FulltimeTeacher> listF, List<ParttimeTeacher> listP);
        void displayList();
    }
}
