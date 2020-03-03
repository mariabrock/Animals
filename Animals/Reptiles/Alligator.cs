using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    class Alligator
    {
        //private bool _isAquatic;
        //this is a property, they expose information
        public bool IsAquatic { get; set; }

        //this is a field, it will be informtion just for us, others will not be able to see it.
        private int _stepGoal;
        private int _stepCount;

        //this is a constructor, the name and type it returns are the same, soy ou will only see the access modifier and name
        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
            
        }

        //access modifier, return type (what value the method returns), name, and parameters make up a method
        public void Grunt()
        {
            //now you've written a method

            if (IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("grrrrrrr!");
            }
            
        }

        //declaring parameters within a C# method
        public void Run(int steps)
        {
            _stepCount += steps;

            //string interpolation adds a $ to the front of the string
            Console.WriteLine($"You ran {steps} steps.");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine("Congrats! You met you goal.");
            }
        }
    }
}
