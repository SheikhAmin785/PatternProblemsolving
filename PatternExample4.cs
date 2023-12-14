
using System;

namespace PatternProblemsolving
{
    class PatternExample4
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    // Convert numeric value to corresponding character using ASCII values
                    char ch = (char)(j + 64);
                    Console.Write(" " + ch);
                }
                Console.WriteLine();
            }
        }
    }
}

//outout
//A B C D E
//A B C D E
//A B C D E
//A B C D E
