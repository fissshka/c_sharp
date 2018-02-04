using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        public enum ComputerType { Desktop, Laptop, Server };

        // 2) declare struct Computer
        public struct Computer
        {
            public ComputerType type;
            public int CPU, Memory, HDD;
            public float HGz;

            public Computer(ComputerType type, int CPU, float HGz, int Memory, int HDD)
            {
                this.type = type;
                this.CPU = CPU;
                this.HGz = HGz;
                this.Memory = Memory;
                this.HDD = HDD;
            } 
        } 
        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            int[][] comps_per_dep = new int[4][];
            // 4) set the size of every array in jagged array (number of computers)
            comps_per_dep[0] = new int[3];
            comps_per_dep[1] = new int[3];
            comps_per_dep[2] = new int[3];
            comps_per_dep[3] = new int[3];
            // 5) initialize array
            comps_per_dep[0] = new int[] { 2, 2, 1 };
            comps_per_dep[1] = new int[] { 0, 3, 0 };
            comps_per_dep[2] = new int[] { 3, 2, 0 };
            comps_per_dep[3] = new int[] { 1, 1, 2 };
            // Keep the console window open in debug mode.
            // Note: use loops and if-else statements
            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            List<int> desktops = new List<int>();
            List<int> laptops = new List<int>();
            List<int> servers = new List<int>();

            int[] all_desktops = new int[3];
            int[] all_laptops = new int[3];
            int[] all_servers = new int[3];

            int desktops_in_company;
            int laptops_in_company;
            int servers_in_company;

            for (int i = 0; i < comps_per_dep.Length; i++)
            {
                for (int j = 0; j < comps_per_dep[i].Length; j++)
                {
                    if (j == 0)
                    {
                        int a = comps_per_dep[i][0];
                        desktops.Add(a);
                    }
                    else if (j == 1)
                    {
                        int b = comps_per_dep[i][1];
                        laptops.Add(b);
                    }
                    else if (j == 2)
                    {
                        int c = comps_per_dep[i][2];
                        servers.Add(c);
                    }
                    else break;
                }

                all_desktops = desktops.ToArray();
                all_laptops = laptops.ToArray();
                all_servers = servers.ToArray();
            }
            desktops_in_company = all_desktops.Sum();
            laptops_in_company = all_laptops.Sum();
            servers_in_company = all_servers.Sum();
            int total_amount = desktops_in_company + laptops_in_company + servers_in_company;
            Console.WriteLine("Amount of: \n " +
                        "Desktops per department " + desktops_in_company + "\n" +
                        "Laptops per department " + laptops_in_company + "\n" +
                        "Servers  per department " + servers_in_company + "\n" +
                        "Total amount of computers in company  is " + total_amount + " Computers");
            Console.ReadLine();
            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            Computer Desktop_property;
            Desktop_property.type = ComputerType.Desktop;
            Desktop_property.CPU = 2;
            Desktop_property.HGz = 2.5f;
            Desktop_property.Memory = 6;
            Desktop_property.HDD = 500;

            Computer Laptop_property;
            Laptop_property.type = ComputerType.Laptop;
            Laptop_property.CPU = 4;
            Laptop_property.HGz = 1.7f;
            Laptop_property.Memory = 4;
            Laptop_property.HDD = 250;

            Computer Server_property;
            Server_property.type = ComputerType.Server;
            Server_property.CPU = 8;
            Server_property.HGz = 3f;
            Server_property.Memory = 16;
            Server_property.HDD = 2000;

            if (Desktop_property.HDD > Laptop_property.HDD)
            {
                if (Desktop_property.HDD > Server_property.HDD)
                {
                    Console.WriteLine("The biggest HDD is for Desktop and it is " + Desktop_property.HDD);
                }
                else
                {
                    Console.WriteLine("The biggest HDD is for Server and it is " + Desktop_property.HDD);
                }
            }
            else
            {
                if (Laptop_property.HDD > Server_property.HDD)
                {
                    Console.WriteLine("The biggest HDD is for Laptop and it is " + Laptop_property.HDD);
                }
                else
                {
                    Console.WriteLine("The biggest HDD is for Server and it is " + Server_property.HDD);
                }
            }

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            if (Desktop_property.CPU < Laptop_property.CPU)
            {
                if (Desktop_property.CPU < Server_property.CPU)
                {
                    Console.WriteLine("The lowest productivity is for Desktop and it is " + Desktop_property.CPU);
                }
                else
                {
                    Console.WriteLine("The lowest productivity is for Server and it is " + Desktop_property.CPU);
                }
            }
            else
            {
                if (Laptop_property.CPU < Server_property.CPU)
                {
                    Console.WriteLine("The lowest productivity is for Laptop and it is " + Laptop_property.CPU);
                }
                else
                {
                    Console.WriteLine("The lowest productivity is for Server and it is " + Server_property.CPU);
                }
            }


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            Desktop_property.Memory = 8;
            Console.WriteLine("Desktop memory is upgraded and it is " + 
                Desktop_property.Memory + ";" + " Laptop memory is " + Laptop_property.Memory + ";" + 
                " Server memory is " + Server_property.Memory + ";");

            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }

}