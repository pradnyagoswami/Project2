using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public interface Interface1
    {
        String Print();

    }
    public interface Interface2
    {
        String Paytax();
    
    }
    public class User : Interface1
    {
        public string Print()
        {
            return $"User Details";
        }
    }
}
