using System;

namespace MethodsParameters
{
    public class RefType
    {
        public string Prop { get; set; }

        public string Prop2 { get; set; }

        public RefType()
        {
            
        }

        public RefType(int a)
        {
            
        }

        //public void Meth(int param1, string param2)
        //{
        //    Console.WriteLine("Param1: {0}\n Param2: {1}", param1, param2);
        //}

        //public void Meth(int safasfafsafsasf, long JUBS = 10, string param3 = "hello world")
        //{
        //    Console.WriteLine("Param1: {0}\n Param2: {1}\n Param3: {2}", param1, param2, param3);
        //}

        public void Meth2(params string[] args)
        {
            foreach (var i in args)
            {
                Console.WriteLine(i);
            }
        }
    }
}
