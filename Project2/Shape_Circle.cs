﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
   abstract public class Shape_Circle
    {
        public Shape_Circle()
        {

        }
        public abstract string Draw(string name);
        public abstract void Area();
        public string Display()
        {
            return "This is shape class";
        }

   }
    public class Circle : Shape_Circle
    {
        private const double pi = 3.14;
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }

        public override void Area()
        {
            area = pi * r * r;
        }
        public override string Draw(string name)
        {
            return name;
        }

        public string Print()
        {
            return $"area of circle is {area}";
        }
    }


}
