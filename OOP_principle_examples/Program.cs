using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principle_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IAnimal> list = new List<IAnimal>(); //an interface list handler (contains actual list)

            //Interface animal controller that contains each animal object
            //this means that only the eat, sleep and poo methods for each animal can be called
            IAnimal x = new Cat("Zippy");
            IAnimal z = new Dog();
            IAnimal y = new Fish();
            list.Add(x);
            list.Add(z);
            list.Add(y);
            //Here is an example of polymorphism
            foreach (IAnimal item in list)
            {
                item.eat();
                item.sleep();
                item.poo();
            }

            Console.WriteLine("\n\n\n\n");
            //Use cat controller for specific cat methods/properities
            Cat X = new Cat("Bono");
            X.callName();
            Console.ReadLine();

        }
    }
}
