using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Referance
    {
        static void Swap(ref int a, ref int b)
        {

            int temp;
            temp = a;
            a = b;
            b = temp;

        
        }
        static void Main(string[] args)
        {

            int a = 10; int b = 20;
            Swap(ref a,ref b);
            Console.WriteLine($"a={a},b={b}");



        }



    }
}
