using System;

namespace P02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int i2 = 1; i2 <= 10; i2++)
                {
                    Console.WriteLine($"{i} * {i2} = {i * i2}");

                }
            }
        }
    }
}
