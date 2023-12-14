using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class PatternExample5
    {
        static void Main()
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j = 5; j >= 1; j--)
                {
                    Console.Write(""+j);
                }
                Console.WriteLine();
            }
        }
    }
}
//output
//5 4 3 2 1
//5 4 3 2 1
//5 4 3 2 1
//5 4 3 2 1

//output
//console.write(""+i);
//5 5 5 5 5
//4 4 4 4 4
//3 3 3 3 3
//2 2 2 2 2
//1 1 1 1 1
