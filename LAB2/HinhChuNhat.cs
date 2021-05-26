using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB2
{
    public class HinhChuNhat
    {
        private double _length;
        private double _width;


        public HinhChuNhat()
        {
           
        }

        public HinhChuNhat(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get => _length; set => _length = value; }
        public double Width { get => _width; set => _width = value; }

        public double area()
        {
            return _length * _width;
        }
        public double perimeter()
        {
            return (_length + _width) * 2;
        }

        public string show()
        {
            return "Length : " + _length + " Width : " + _width + " area " + area() + " perimeter " + perimeter();
        }
    }
}
