using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOOP
{
    // Lop Student se ke thua tu lop Person 

    class Student : Person
    {

        private double _toan;

        public double Toan
        {
            get { return _toan; }
            set { _toan = value; }
        }

        private double _van;

        public double Van
        {
            get { return _van; }
            set { _van = value; }
        }

        public Student()
        {
        }

        public Student(string code, string name, double toan, double van) :base(code,name)
        {
            this.Toan = toan;
            this.Van = van;

        }
        public void show()
        {
            Console.WriteLine(base.toString() + "\t"+Toan + "\t" + Van + "\t" + getAverage());
        }


        private double getAverage()
        {
            return (Toan + Van) / 2;
        }

        // Thuoc tinh : Toan , Van 
        // Phuong thuc : 
        //Constructor khong tham so , full tham so 


        // show toan bo thong tin 
    }
}
