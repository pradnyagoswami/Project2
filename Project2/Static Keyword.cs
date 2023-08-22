using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Engineer
    {
        private int id;
        private String feild;
        private static int count;
        

        public Engineer(int id,string feild)
        {

            count++;
            this.id = id;
            this.feild = feild;
        
        
        }
        static Engineer()
        {
            Console.WriteLine("Static constructor");

        }
        
        public static int GetCount()
        {
            return count;
        
        }
        public String Print()
        {
            return $"{id},{feild}";
        
        }


    }
}
