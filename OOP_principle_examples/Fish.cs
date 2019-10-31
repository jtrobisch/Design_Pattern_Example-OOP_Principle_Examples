using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principle_examples
{
    class Fish:Animal
    {
        public override void eat() //this method has to be overriden
        {
            Console.WriteLine("I am a eating fish");
        }
    }
}
