using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    // Example 2 - Nested classes
    public class Container
    {
        private int container_var;
        public Container(int nested_var)
        {
            Nested1 n1 = new Nested1();
            n1.nested_var = nested_var;
        }
        class Nested1
        {
            public int nested_var;
        }
        public class Nested2
        {
            private Container container;
            public Nested2(Container container, int container_var)
            {
                this.container = container;
                this.container.container_var = container_var;
            }
        }
    }

}
