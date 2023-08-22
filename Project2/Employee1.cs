using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Employee1
    {
        protected int age;
        protected String name;
        protected double salary, hra, da, ta, pf, gross;



      public Employee1(int age,String name)
        { 
            this.age = age;
            this.name = name;
            this.salary = salary;
            
        }
        public virtual void CalculateSalary()
        {

            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + ta + da) - pf;

        }
        public virtual String Show()
        {

            return $" {age} {name} {gross}";
        
        }


    }
    public class SalesEmployee : Employee1
    {
        private double bonus;
        private double commission;

        public SalesEmployee(int age,String name,int id)   :base(age,name)
        { 
        
             this.bonus= bonus;
            this.commission = commission;   
        
        }
    public override void CalculateSalary()
        {

            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            bonus = (salary * 20) / 100;

            gross = (salary + hra + ta + da+bonus) - pf;

        }

        public override String Show()
        {

            return $" {age} {name} {gross} ";

        }

    }

}
