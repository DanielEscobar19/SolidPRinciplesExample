using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesExample.Animal
{

    interface BasicNeedsAnimal
    {
        public abstract void Eat();
    }

    interface FlyingAnimal
    {
        public abstract void Fly();
    }

    interface TerrestrialAnimal
    {
        public abstract void Run();
    }

    public class Animal : BasicNeedsAnimal
    {
        public string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }

        public void GetName() {
            Console.WriteLine($"El nombre de este animal es: {this.Name}");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"El animal {this.Name} no se sabe que esta comiendo");
        }
    }

    public class Dog : Animal, TerrestrialAnimal
    {
        public Dog(string animal) : base(animal) { }

        public void Run()
        {
            Console.WriteLine($"El animal {this.Name} esta corriendo");
        }

        public override void Eat()
        {
            Console.WriteLine($"El animal {this.Name} esta comiendo carne");
        }
    }

    public class Yiguirro : Animal, FlyingAnimal
    {
        public Yiguirro(string animal) : base(animal) { }


        public override void Eat()
        {
            Console.WriteLine($"El animal {this.Name} esta comiendo semillas");
        }

        public void Fly()
        {
            Console.WriteLine($"El animal {this.Name} esta volando por las nubes");

        }
    }

    public class Turtle : Animal
    {
        public Turtle(string animal) : base(animal) { }


        public override void Eat()
        {
            Console.WriteLine($"El animal {this.Name} esta comiendo lechuga");
        }
    }
}
