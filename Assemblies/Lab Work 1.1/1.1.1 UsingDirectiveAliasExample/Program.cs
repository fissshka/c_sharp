
// Example 1 - Using directive and alias

using System;

using AliasNoGeneric = Simple.WithOutGeneric;
using AliasGeneric = Generic.WithGeneric<int>;

namespace UsingDirectiveAliasExample
{
    using Generic;
    using Simple;
    class Program
    {
        static void Main(string[] args)
        {

            WithGeneric<int> instanceGeneric = new WithGeneric<int>();
            Console.WriteLine(instanceGeneric);

            WithOutGeneric instanceNoGeneric = new WithOutGeneric();
            Console.WriteLine(instanceNoGeneric);

            AliasNoGeneric aliasInstanceNoGeneric = new AliasNoGeneric();
            Console.WriteLine(aliasInstanceNoGeneric);

            AliasGeneric aliasInstanceGeneric = new AliasGeneric();
            Console.WriteLine(aliasInstanceGeneric);

            Console.ReadKey();
        }
    }
}
