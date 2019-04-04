using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneLibrary
{
    // 1) add enum AirplaneTypes with values SportPlane, CargoPlane, TurboProp, Jet


    // 2) set attribute AttributeUsage with parameters that allow to use class AirplaneTypeAttribute
    // for classes only, disable inheritance and enable multiple using

    [Flags]
    public enum AirplaneTypes
    {
        SportPlane = 0,
        CargoPlane = 1,
        TurboProp = 2,
        Jet = 4
    }

    // 3) derive class AirplaneTypeAttribute from System.Attribute and protect against inheritance

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, Inherited = false, AllowMultiple = true)]
    public sealed class AirplaneTypeAttribute : System.Attribute
    {
        // 4) declare public property Type with type - AirplaneTypes 


        // 5) declare 2 constructors:
        // default - initialize Type with AirplaneTypes.TurboProp
        // parameter - with type AirplaneTypes 

        public AirplaneTypes Type { get; private set; }

        public AirplaneTypeAttribute()
        {
            Type = AirplaneTypes.TurboProp;
        }

        public AirplaneTypeAttribute(AirplaneTypes val)
        {
            Type = val;
        }
    }

    //add two AirplaneTypeAttribute-s to UniversalAirplane
    [AirplaneTypeAttribute(AirplaneTypes.Jet)]
    [AirplaneTypeAttribute(AirplaneTypes.CargoPlane)]
    public class UniversalAirplane
    {
        public UniversalAirplane()
        {
            //"constructor" - and it's what the constructor is called in IL
            Console.WriteLine("Universal Airplane ctor");
        }

    }

    //add AirplaneTypeAttribute to CargoAirplane
    [AirplaneTypeAttribute(AirplaneTypes.CargoPlane)]
    public class CargoAirplane
    {
        public CargoAirplane()
        {
            Console.WriteLine("Cargo Airplane ctor");
        }
    }

}
