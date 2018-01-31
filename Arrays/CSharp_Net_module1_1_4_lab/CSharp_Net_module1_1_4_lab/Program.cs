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
        enum ComputerType { Desktop, Laptop, Server};

        // 2) declare struct Computer
        struct Computer
        {
            ComputerType type;
            public int CPU;
            double HGz;
            public int memory;
            public int HDD;
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
            int count;
            //int desktops;
            //int laptops;
            //int servers;
            List <int> desktops = new List<int>();
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
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)



            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions


            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements


            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
 
    }

