using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class FloydTriangle
    {
        static void Main()
        {
            int k = 1;
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j < i + 1; j++)
                {
                    Console.Write(" "+k++);
                }
                Console.WriteLine( );
            }
            Console.ReadLine( );
            //floyd triangle output

            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //10 11 12 14 15
            //16 17 18 19 20 21
            //22 23 24 25 26 27 28
            //29 30 31 32 33 34 35 36
        }
    }
}
