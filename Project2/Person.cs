using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project2
{
    public  class Person
    {
       
        protected String name;
        protected String address;
        protected long adharno;

        public Person(String name,String address,long adharno) 
        {
         this.name = name;
            this.address = address;
            this.adharno=adharno;
       
        }
      
    }
    public class Patient : Person
    {
        private string bloodgrp;
        private int Bedno;
        public Patient(int Bedno,String bloodgrp,String name,String address,long adharno):base(name,address,adharno)
        {
        
        this.bloodgrp = bloodgrp;
            this.Bedno = Bedno;
        
        }
        public void show()
        {
            Console.WriteLine(name+"\t"+address+"\t"+adharno+"\t"+bloodgrp+"\t"+Bedno);


        }
    
    
    
    
    }

}
