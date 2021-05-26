using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppOOP
{
    class Person
    {
        //Thuoc tinh : code ; name 
        private string code;
        private string name;

     

        //Phuong thuc :
        // constructer khong tham so / full tham so 
        //to string method

        public Person()
        {

        }

        public Person(string code, string name)
        {
            this.Code = code;
            this.Name = name;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }

        public string toString()
        {
            return code + "\t" + name;
        }
        

    }
}
