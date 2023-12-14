using System;

namespace PatternProblemsolving
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
//output:
//1 2 3 4 5
//1 2 3 4 5
//1 2 3 4 5
//1 2 3 4 5
