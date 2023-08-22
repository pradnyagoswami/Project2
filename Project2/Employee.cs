using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project2
{
    public class Employee
    {
        protected double hra, da, ta, pf, gross, salary;
        protected int id;
        protected String name;
        



        public Employee(int id, String name, double salary)
        {
            this.id = id;
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
        public virtual String Disply()
        {
            return $"Employee: id of employee = {id}\n name of Employee = {name}\n  Employee salary = {salary}\n Gross salary = {gross}";

        }

    }

    public class Manager : Employee
    {

        private Double FoodAllownce;

        public Manager(double foodAllownce,int id,String name,double salary):base(id,name,salary) 
        {
            this.FoodAllownce = foodAllownce;
        }
        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + ta + da+FoodAllownce) - pf;


        }

        public override String Disply()
        {
            return $"Manager: id of employee = {id}\n name of Employee = {name}\n  Employee salary = {salary}\n{gross}";

        }

    }
}
