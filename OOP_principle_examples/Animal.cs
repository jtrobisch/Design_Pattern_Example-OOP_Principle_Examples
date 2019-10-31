using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_principle_examples
{
    abstract class Animal:IAnimal //implements interface (all animals must have the three public methods)
    {
        private String _name = "default name";
        private String _animalType;

        //get and set code for name variable
        public String name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public String animalType
        {
            get
            {
                return _animalType;
            }
            set
            {
                _animalType = value;
            }
        }

        //constructors (these cannot be overidden)
        public Animal()
        {
            Console.WriteLine("You have created an Animal!");
        }
        //Constuctor Overloads
        public Animal(String p_name)
        {
            this._name = p_name;
            Console.WriteLine("You have created an Animal!");
        }
        public Animal(String p_name, String p_animalType)
        {
            this._name = p_name;
            this._animalType = p_animalType;
            Console.WriteLine("You have created an Animal!");
        }
        //end of constructors

        abstract public void eat(); //this method has to be overidden 
        
        public virtual void sleep() //this method can be overidden
        {
            Console.WriteLine("I am a sleeping animal!");
        }
        public void poo()//this method cannot be overidden
        {
            Console.WriteLine("I am a pooing animal!");
        }
    }

    interface IAnimal //interface - all animals have to have these methods now
    {
        void eat();
        void sleep();
        void poo();
    }
}
