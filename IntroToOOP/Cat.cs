﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat // Class = noun; create new class for each item eg. dog
    {
        // I need STATES
        //fields - almost always private

        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true; // cat will always be hungry from the start
                                      // booleans do not to have be set from start
        private string hairLength;


        // Properties - allows to set priorities

        public string Name // Mehtod - verb
        {
            get { return this.name; } // get allows to see value of name and sets your properties
            set { this.name = value; } // set allows to assign value of name
            // "this" allows for specificity
            // get & set not always go together
            // ex: without a "set" value, you are unable to modify "get" value

        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        

        //I need BEHAVIORS
        // Constructors - allow use to create an instance of that class

        public Cat()
        {
            // default constructor (constructor creates new object of that data type)
            // takes no parameters (nothing in the parentheses)
            // public constructor allows access to private fields
            // ALWAYS HAVE A DEFAULT CONSTRUCTOR

        }

        public Cat (string name, int age, string furColor) // constructor with parameters
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public Cat (string hairLength)
        {
            this.hairLength = hairLength;
        }
        
        // Methods
        public void Eat()
        {
            if(isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

        // method 
        public void Meow()
        {
            Console.WriteLine("\a");
        }

        public string Hairball()
        {
            if (hairLength == "too long")
            {
                return (this.name + " has a hairball.");
            }
            else
            {
                return (this.name + " is nicely grommed.");
            }
        }

    }
}
