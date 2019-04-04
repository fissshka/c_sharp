using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - Composition
           
            JetLiner jetliner = new JetLiner();
            // initialization of jet's power for jetliner
            for (int i = 0; i < jetliner.jets.Length; i++)
            {
                jetliner.jets[i] = new Jet();
                jetliner.jets[i].power = 100;
            }

            Jet jet = new Jet();
            // reinitialization of jet by index 0
            jetliner.jets[0] = jet;


            //------------------------------
            // Example 2 - Nested classes
            
            Container cntr = new Container(5);
            // instance of class Nested2
            Container.Nested2 nested = new Container.Nested2(cntr, 5);


            //------------------------------
            // Example 3 - Inheritance

            Duck duck = new Duck();
            Console.WriteLine(duck.Genus);
            duck.Fly();
            duck.Swim();


            //------------------------------
            // Example 4 - base
            string genus = "Duck";
            Duck duck2 = new Duck(genus);
            duck2.Fly();
            duck2.Swim();
            duck2.Voice();


            //----------------------------
            // Example 5 - polymorphism
            Bird brd = new Bird();
            brd.Voice2();
            brd = new Duck();
            brd.Voice2();
            brd = new Chicken();
            brd.Voice2();

            
            //---------------------------
            // Example 6 - virtual, override, new
            A aa = new A();
            aa.Method();
            aa = new B();
            aa.Method();
            aa = new C();
            aa.Method();
            aa = new D();
            aa.Method();
            aa = new Z();
            aa.Method();
            aa = new X();
            aa.Method();
            aa = new R();
            aa.Method();

            //----------------------------------------
            // Example 8 - 2 Interfaces implementation
            int book_pages = 365;
            Book book = new Book(book_pages);
            book.Publish();


            //-----------------------------------------
            // Example 9 - explicit interface implementation
            IPrintedBook printed_book = (IPrintedBook)book;
            printed_book.Publish();
            IEBook e_book = (IEBook)book;
            e_book.Publish();


            //------------------------
            // Example 10 - IClonable
            Bird bird1 = new Bird("Duck");
            Bird bird2 = (Bird)bird1.Clone();


            //----------------------------------------------
            // Example 11 - override of System.Object method
            bird1.Equals(bird2);

            var customString = bird2.ToString();
            Console.WriteLine(customString);
            Type type = bird1.GetType();
            int hashcode = bird2.GetHashCode();


            //-----------------------------------------
            // Example 12 - dynamic
            dynamic b1 = bird2;
            b1.jgdkjslkgjds();// Voice3("Duck");
            var b2 = b1;
            Type tt = b2.GetType();


        }
    }
}
