using System;

namespace P04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spaceStart = int.Parse(Console.ReadLine());
            int spaceStop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            bool stopLoop = false;
            bool condition = false;
            int c1 = 0;
            int i1 = 0;
            int j2 = 0;

            for (int i = 0; i <= spaceStop; i++)
            {
                for (int j = 0; j <= spaceStop; j++)
                {

                    if (i >= spaceStart && i <= spaceStop && j >= spaceStart && j <= spaceStop)
                    {
                        c1++;
                        if (i + j == magicNumber)
                        {
                            condition= true;
                            i1 = i;
                            j2 = j;
                            stopLoop = true;
                            break;
                        }
                    }
                }
                if (stopLoop)
                {
                    break;
                }
            }
            if (condition)
            {
                Console.WriteLine($"Combination N:{c1} ({i1} + {j2} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{c1} combinations - neither equals {magicNumber}");
            }
        }
    }
}
