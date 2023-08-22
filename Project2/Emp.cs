using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Emp
    {

        protected int id;
        protected string name;

        public  Emp(int id,string name)
        {
            this.id = id;
            this.name = name;
        
        }

    }
    public class Emp_Manager : Emp
    {
        

        public  Emp_Manager(int id,string name) :base(id,name)
        { 
        this.id=id;
        this.name = name;
        
        }
        public String Show()
        {
            return $"{id},{name}";
        
        }

    
    
    }
}
