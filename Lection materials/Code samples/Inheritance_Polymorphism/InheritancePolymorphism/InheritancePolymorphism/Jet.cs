using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    // Example 1 - Composition
    public class Jet
    {
        public double power;
        // Other code
    }

    // composed class
    public class JetLiner
    {
        public Jet[] jets = new Jet[4];
        // Other code
    }

}
