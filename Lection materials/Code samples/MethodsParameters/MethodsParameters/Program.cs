using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            var ref2 = new RefType {Prop = "1", Prop2 = "2"};
            var ref3 = new RefType() { Prop = "1", Prop2 = "2" };

            var st = new MyStaticClass();
            var st2 = new MyStaticClass();
            st.HellMeth();
            MyStaticClass.stat_x = 10;
            st.HellMeth();
            st2.HellMeth();


            var ref4 = new RefType(10) { Prop = "1", Prop2 = "2" };

            var ref5 = new RefType();
            ref5.Prop = "1";
            ref5.Prop2 = "2";

            var cl = new MyClass2(10);

            var reft = new RefType();
            reft.Meth2("sdgfdsg", "fsdfs", "sfd");
            reft.Meth2("fsfs", "gdgd");

            MyClass my_object = new MyClass();
            // method access
            my_object.MyMethod();

            
            // method access
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("arr[0] before MyMethod calling: {0}", arr[0]);
            my_object.MyMethod(arr);
            Console.WriteLine("arr[0] after MyMethod calling: {0}", arr[0]);

            // method returns value
            int arr_sum = my_object.Sum(arr, arr.Length);


           // ref parameter
            Console.WriteLine("size of arr[] after MyMethod calling: {0}", arr.Length);   
            my_object.MyMethod(ref arr);
            Console.WriteLine("size of arr[] after MyMethod calling: {0}", arr.Length);

            // assigning of val1 is necessary and val2 isn't necessary
            int val1 = 4;
            int val2;
            my_object.MyMethod(ref val1, out val2);


            var refT = new RefType { Prop = "Initial value" };
            my_object.RefTypeParamPassing(refT);
            my_object.RefTypeParamPassing(ref refT);

            // params
            my_object.MyMethod2(3, 5, 7);
            my_object.MyMethod2(7, 2, 8, 1, 5);
            my_object.MyMethod2(arr);

            // named arguments
            my_object.MyMethod(param2: "some string", param1: 5);
            // compile error
            //my_object.MyMethod3(param1: 4, "some string");

            // optionial arguments
            my_object.MyMethod3(5);

            // object initializers
            MyClass my_object1 = new MyClass { prop1 = 1, prop2 = "text" };
            MyClass my_object2 = new MyClass() { prop1 = 1, prop2 = "text" };
            MyClass my_object3 = new MyClass(10, "new text") { prop1 = 1, prop2 = "text" };

            // static
            MyClass.value = 5;

            // static method invloking
            MyStaticClass.StatMethod(5);
        }
    }
}
