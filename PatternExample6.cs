using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class PatternExample6
    {
        static void Main()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(""+j);
                }
                Console.WriteLine();
            }
        }
    }
}
//output
//1
//1 2
//1 2 3
//1 2 3 4
//1 2 3 4 5
