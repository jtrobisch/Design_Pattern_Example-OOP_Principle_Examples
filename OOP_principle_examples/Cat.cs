using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principle_examples
{
    class Cat: Animal //inherits animal class
    {
        private string _catBreed;
        private new string name; //creates its own name variable (As opposed to using the animal name variable)
        public String catBreed
        {
            get
            {
                return _catBreed;
            }
            set
            {
                _catBreed = value;
            }
        }
        public Cat(string n) //cat constructor
        {
            this.name = n;
            Console.WriteLine("You have created a new cat!");
        }
        public void callName()
        {
            Console.WriteLine("Name from Animal class; " + base.name);
            Console.WriteLine("Name from Cat class; " + this.name);
        }
        public override void eat() //overrides the eat method from the animal class
        {
            Console.WriteLine("I am a eating cat");
        }
        public override void sleep()
        {
            Console.WriteLine("I am a sleeping cat");
        }
    }
}
