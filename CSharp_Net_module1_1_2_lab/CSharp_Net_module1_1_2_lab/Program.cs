using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:

            // #Console.WriteLine(boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0);

            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)
            bool boo = new bool();
            boo = true;
            char ch = new char();
            ch = 'a';
            byte b = new byte();
            b = 1;
            sbyte sb = new sbyte();
            sb = 100;
            short sh = new short();
            sh = 2507;
            ushort ush = new ushort();
            ush = 150;
            int i = new int();
            i = 10000;
            uint ui = new uint();
            ui = 25u;
            long l = new long();
            l = 223L;
            ulong ul = new ulong();
            ul = 300ul;
            decimal de = new decimal();
            de = 100000.6m;
            float fl = new float();
            fl = 8f;
            double d0 = new double();
            d0 = -33.1d;
            //--------------------
            //2) declare constants of int and double. Try to change their values.
            const int iC = 30;
            //int iC = 20;
            const double d1 = 0.23d;
            //double d1 = 56.2d;
            //--------------------
            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
            var myNew = 20.GetType();
            var myNew1 = 20.5.GetType();

            //--------------------
            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?
            //imopossible
            //myNew = i;
            //myNew = d0;

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?
                int myI = new int();
                char myCh = new char();
                double myD0 = new double();

                // 6) change values of variables from 1)
                i = 40;
                int i1 = @i + 1;
                ch = 'n';
                //char b;
                d0 = -0.33d;


            }

            // 7)check values of variables from 1). Are they changed? Think, why

            Console.WriteLine(i);
            Console.WriteLine(ch);
            Console.WriteLine(d0);

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            //var myNum = 2;
            //int day = 3;
            bool boo1 = boo;
            char ch1 = ch;
            int newB = b;
            short newSb = sb;
            int newI = sh;
            uint newUi = ush;
            long newL1 = i;
            long newL = ui;
            float newF = l;
            double newd0 = ul;
            decimal newF1 = de;
            double newD = fl;
            double newDo1 = d0;

            /*
             * 
             * 
             * 
             * /

            

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char
            int NewIn = ch;
            // bool -> short
            ///short NewBoo = boo;
            // double -> long
            double NewLo = l;
            // float -> char 
            float newFLo = ch;
            // int to char
            int newINT = ch;
            // decimal -> double
                decimal newDEC = 123.56m;
                d0 = (double)newDEC;
            // byte -> uint
            byte newByt = 23;
            ui = (byte)newByt;
            // ulong -> sbyte
            //ulong NewULO = 456ul;
            //sb = (ulong)NewULO;
            // 9) and reverse conversion with fixing compilation errors.
            ///short newSH;
           //boo = (short)newsh;
            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?
            int? iN;
            iN = null;
            //int? i = null;
        }
    }
}
