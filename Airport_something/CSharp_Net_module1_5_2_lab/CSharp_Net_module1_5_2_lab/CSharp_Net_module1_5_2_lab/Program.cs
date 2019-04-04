using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneLibrary;

namespace CSharp_Net_module1_5_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //implement  CheckSaveTrace in using block
            using (CheckSaveTrace checkST = new CheckSaveTrace())
            {
                //create the  CargoAirplane and UniversalAirplane objects
                CargoAirplane cargo = new CargoAirplane();
                UniversalAirplane jet = new UniversalAirplane();
                    //call CheckClassAttribute, SaveTrace and EventLogging methods
                    //for the  CargoAirplane and UniversalAirplane objects
                    checkST.CheckClassAttribute(cargo);
                    checkST.CheckClassAttribute(jet);

                    checkST.SaveTrace(cargo);
                    checkST.SaveTrace(jet);

                    checkST.EventLogging(cargo);
                    checkST.EventLogging(jet);
            }

            Console.ReadKey();
        }
    }
}
