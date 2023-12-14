using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProblemsolving
{
    class PatternExample9
    {
        static void Main()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine();
                //output
                //1 2 3 4 5 
                //1 2 3 4
                //1 2 3
                //1 2
                //1
            }
        }
        static void Maink()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.WriteLine("" + j);
                }
                Console.WriteLine();
                //output
                //1 2 3 4 5
                //2 3 4 5
                //3 4 5
                //4 5
                //5
            }
        }
        static void Minakk()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write("" + j);
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
        static void Mains()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("" + j);
                }
                Console.WriteLine();
                //output
                //5 4 3 2 1
                //4 3 2 1
                //3 2 1
                //2 1
                //1
            }
        }
        static void Star()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5 || j == 1 || j == 5)
                    {
                        Console.WriteLine("*");
                    else
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
    

