using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public interface ICustomer
    {

        string Disply();
    
    
    }
    public interface IOrders
    {

        string Disply();
    
    }
    public class Transaction : ICustomer, IOrders
    {

        string ICustomer.Disply()
        {
            return "Customer details";
        }

        string IOrders.Disply()
        {
            return "Order details";
        }


    }



}
