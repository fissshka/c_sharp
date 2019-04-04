
// Example 2 - #define, #undef, #if, #else, #elif, #endif

#define COMPILE1
#define COMPILE2

// Example 3 - Preprocessor directive #warning, #error
#define DEBUG
#undef DEBUG

#undef COMPILE1

using System;


namespace PreprocessorDirectives
{
    
    // Example 6 - Preprocessor directive #pragma, #pragma warning, #pragma checksum
#pragma warning disable 414, 3021
[CLSCompliant(false)]
    class Program
    {
        static void Main(string[] args)
        {
            // Example 2 - #define, #undef, #if, #else, #elif, #endif

 
#if COMPILE1
            Console.WriteLine("COMPILE1 Mode");
#elif COMPILE2
            Console.WriteLine("COMPILE2 Mode");
#else
            Console.WriteLine("non of COMPILE1 and COMPILE2 Mode");
#endif

            // Example 3 - Preprocessor directive #warning, #error
#if DEBUG
#warning DEBUG is defined
#error DEBUG is defined
#endif


            // Example 4 - Preprocessor directive #line
#line 100 "Special"
            int i;    // CS0168 on line 100
            int j;    // CS0168 on line 101
#line default
            char c;   // CS0168 on line 43
            float f;  // CS0168 on line 44
#line hidden // numbering not affected
            string s;
            double d; // CS0168 on line 47


            // Example 5 - Preprocessor directive #region, #endregion
            #region
            Console.WriteLine("Message 1 in region");
            Console.WriteLine("Message 2 in region");
            #endregion


            // Example 6 - Preprocessor directive #pragma, #pragma warning, #pragma checksum
#pragma checksum "Program.cs" "{3673e4ca-6098-4ec1-890f-8fceb2a794a2}" "012345678AB" // New checksum

            Console.ReadKey();
        }
    }

// Example 6 - Preprocessor directive #pragma, #pragma warning, #pragma checksum
#pragma warning restore 3021
[CLSCompliant(false)]  // CS3021
public class SomeClass
{
    int i = 1;
    public static void SomeMethod()
    {
    }
}
}
