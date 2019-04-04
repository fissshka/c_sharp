using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    // Example 6 - virtual, override, new
    public class A
    {
        public virtual void Method()
        {
            Console.WriteLine("method of class A");
        }
    }

    public class B : A
    {
        public override void Method()
        {
            Console.WriteLine("method of class B");
        }
    }

    public class C : B
    {
        public new void Method()
        {
            Console.WriteLine("method of class C");
        }
    }

    public class D : C
    {
        public virtual void Method()
        {
            Console.WriteLine("method of class D");
        }
    }

    public class Z : A
    {
        public sealed override void Method()
        {
            Console.WriteLine("method of class Z");
        }
    }

    public class X : Z
    {
        public virtual void Method()
        {
            Console.WriteLine("method of class X");
        }
    }

    public class R : A
    {
        public void Method()
        {
            Console.WriteLine("method of class R");
        }
    }

}
