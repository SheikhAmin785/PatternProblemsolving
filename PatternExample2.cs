﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class PatternExample2
    {
        static void Main()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write(" "+i);
                }
                Console.WriteLine();
            }
        }
    }
}
//output:
 //1 1 1 1 1
 //2 2 2 2 2
 //3 3 3 3 3
 //4 4 4 4 4
 //5 5 5 5 5

