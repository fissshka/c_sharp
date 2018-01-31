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

            for (int i = 0; i < comps_per_dep.Length; i++)
            {
                //count = 0;
                //int desktop_sum = desktops;
                //int laptop_sum = laptops;
                //int server_sum = servers;
                //System.Console.Write("Dep_computers({0}): ", i);
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
                int[] all_desktops = desktops.ToArray();
                int[] all_laptops = laptops.ToArray();
                int[] all_servers = servers.ToArray();
            

                int desktops_in_company = all_desktops[0] + all_desktops[1] + all_desktops[2] + all_desktops[3];
                int laptops_in_company = all_laptops[0] + all_laptops[1] + all_laptops[2] + all_laptops[3];
                int servers_in_company = all_servers[0] + all_servers[1] + all_servers[2] + all_servers[3];
                int total_amount = desktops_in_company + laptops_in_company + servers_in_company;
                Console.WriteLine("Amount of: " +
                            "Desktops - " + desktops_in_company + "\n" +
                            "Laptops - " + laptops_in_company + "\n" +
                            "Servers - " + servers_in_company + "\n" +
                            "Total amount of computers in company  is" + total_amount + " Computers");
                Console.ReadLine();
                /*
                 {
                     int desktops = comps_per_dep[i][0];
                     int laptops = comps_per_dep[i][1];
                     int servers = comps_per_dep[i][2];
                     //count++;
                     //int desktop = (int)ComputerType.Desktop;
                     //(ComputerType)i

                     //System.Console.Write("{0}{1}", comps_per_dep[i][j], j == (comps_per_dep[i].Length - 1) ? "" : " ");
                 }*/

                //System.Console.WriteLine(desktop_sum);
                //System.Console.WriteLine(laptop_sum);
                //System.Console.WriteLine(server_sum);
                //Console.WriteLine("Number of computer type: " + ComputerType.Desktop + " is " + count);
            }
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

