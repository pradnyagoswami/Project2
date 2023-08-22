using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Animal
    {
        protected string color;
        protected double weight;

        public Animal(string color, double weight)
        {
            this.color = color;
            this.weight = weight;

        }
        
    }
    public class Elephant : Animal
    {
            protected int age;

        public Elephant(string color, double weight, int age) : base(color, weight)
        { 
            
            this.age = age;
            
        }
        public void Show()
        {
            Console.WriteLine("Age of Elephant is 105");
        }
           
    }
    public class BabyElephant : Elephant
        {
           protected  string home;
        public BabyElephant(string color, double weight, int age, string home) : base(color, weight, age)
            { 
            
            this.home = home;
            
            }
            public string Print()

            {
                return $"Home of Baby Babyelephant = {home} Color of BabyElephant = {color},Weight of BabyEleohant = {weight},Age of BabyElephant = {age}";
            }
        
        }


    }

