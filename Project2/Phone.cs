using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Phone
    {

        protected int code;
        protected string name;

        public Phone(int code,string name)
        { 
          this.code = code;
           this.name = name;
        
        }
        public  virtual String show()
        {

            return "In Parent show method";
        }
        
    }
    public class SimCard : Phone
    {
        protected double version;
        public SimCard(int code, String name,double version) :base(code,name)
        { 
            this.version = version;
        
        
        }
        public override string show()
        { 
             return $"In show method Child class";
        }



    }

}
