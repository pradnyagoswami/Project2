using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public interface IFruit
    {
        string Disply();

    }
    public interface Ipeel
    {
        string Disply();
    
    }

    public class Mango : IFruit, Ipeel
    {
        string IFruit.Disply()
        {
            return $"fruit";
        
        }
        string Ipeel.Disply()
        {

            return $"Peel";
        
        }
        
    
    
    }







}
