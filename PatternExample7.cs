using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class PatternExample7
    {
        static void Main()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(""+i);
                }
                Console.WriteLine();
                //output
                //1
                //1 2
                //1 2 3
                //1 2 3 4
                //1 2 3 4 5
            }
        }
        static void Mains()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine()
                    //output
                    //1
                    //2 2
                    //3 3 3
                    //4 4 4 4
                    //5 5 5 5 5
            }
        }
        static void Maink()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    char ch = (char)(j + 64);
                    Console.Write(""+ch);
                }
                Console.WriteLine();
               //output
               //A
               //A B 
               // A B C
               // A B C D
            }
        }
    }
}
