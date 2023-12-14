using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class PatternExample8
    {
        static void Main()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write(""+j);
                }
                Console.WriteLine();
                //output
                //5 4 3 2 1
                //5 4 3 2
                //5 4 3
                //5 4 
                //5
            }
        }
        static void Maink()
        {
            for(int i = 5; i >= 1; i--)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(""+j);
                }
                Console.WriteLine();
                //output
                //5
                //5 4
                //5 4 3
                //5 4 3 2
                //5 4 3 2 1
            }
        }

    }
}
