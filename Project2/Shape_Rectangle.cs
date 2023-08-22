using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    abstract public class Shape_Rectangle
    {
        public Shape_Rectangle()
        {

        }
        public abstract String Draw(String name);
        public abstract void Area();

        public String Disply()
        {
            return $"This is a Rectangle";
        }


    }
    public class Recangle : Shape_Rectangle
    {
        private int l, b;
        private double area;

        public Recangle(int l,int b)
        { 
         this.l= l ; 
         this.b = b ;
       
        }
        public override void Area()
        {
            area = l * b;
        }
        public override string Draw(String name)
        {
            return name;
            
        }
        public String Print()
        {
            return $"Area of Rectangle {area}";
        
        }




    }
}
