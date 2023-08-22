using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public partial class Cal
    {

        public int Square(int a)
        {
            Squareroot(a);
            return (a * a);
        
        }
        partial void Squareroot(int a)
        {
            Console.WriteLine(Math.Sqrt(a));
        }


    }
}
