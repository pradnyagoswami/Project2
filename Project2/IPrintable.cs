using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    //Create an interface with name IPrintable , declare method as Print(); Implement the interface with Employee, Manager , Student class
    //And display the respective details of that class.

    public interface IPrintable
    {
        String Print();
    }
    public class Employe : IPrintable
    {
        public string Print()
        {
            return $"Employee Details";
        }
    }
    public class Managerr : IPrintable
    {
        public string Print()
        {
            return $"Manager Details";
        }
    }
    public class Student : IPrintable
    {
        public string Print()
        {
            return $"Student Details";
        }
    }
}
