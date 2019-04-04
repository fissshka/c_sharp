using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    // Example 7 - Interface
    public interface IBird
    {
        string Genus { get; }
        void Voice();
    }

    // Example 3 - Inheritance

    // base class 
    public class Bird: IBird, ICloneable
    {
        public string Genus { get; private set; }
        public void Fly() { }

        public Bird()
        {
            Genus = "bird";
        }

        // Example 4 - base
        public Bird(string Genus)
        {
            this.Genus = Genus;
        }
        public void Voice()
        {
            Console.WriteLine("Bird is singing...");
        }
        
        // Example 5 - polymorphism
        public virtual void Voice2()
        {
            Console.WriteLine("Bird is singing...");
        }

        // Example 10 - IClonable
        public object Clone()
        {
            Bird bird = new Bird(this.Genus);
            return bird;
        }

        // Example 11 - override of System.Object method 
        public override bool Equals(object obj)
        {
            // If this and obj do not refer to the same type, then they are not equal. 
            if (obj.GetType() != this.GetType()) return false;

            Bird bird2 = (Bird)obj;
            return this.Genus == bird2.Genus;
        }

        // Example 12 - dynamic
        public virtual void Voice3()
        {
            Console.WriteLine("Bird is singing...");
        }

        public override string ToString()
        {
            var fromObj = base.ToString();
            Console.WriteLine("ToString from object: " + fromObj);

            Console.WriteLine("CUSTOM ToString\n");
            return $"I am {this.Genus}";
        }
    }
    // derived class
    class Duck : Bird
    {
        public Duck() { }

        // Example - base
        public Duck(string genus)
            : base(genus)
        { }
        public void Swim() { }

        public void Voice()
        {
            base.Voice();
            Console.WriteLine("Duck says kra-kra");
        }

        // Example 5 - polymorphism
        public override void Voice2()
        {
            //  base.Voice();
            Console.WriteLine("Duck says kra-kra");
        }

    }

    // derived class 2
    public class Chicken : Bird
    {
        public override void Voice2()
        {
            Console.WriteLine("Ckicken says ko-ko");
        }
    }


}
