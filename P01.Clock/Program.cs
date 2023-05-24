using System;

namespace P01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            while (hours <= 23)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
                hours++;
            }

            /*for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }*/
        }
    }
}
