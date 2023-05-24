using System;

namespace P06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFloors = int.Parse(Console.ReadLine());
            int quantityRooms = int.Parse(Console.ReadLine());
            int numberOficces = 0;

            for (int i = quantityFloors; i >= 1; i--)
            {

                for (int j = 0; j < quantityRooms; j++)
                {

                    if (i == quantityFloors)
                    {
                        Console.Write($"L{i}{j} ");

                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                        numberOficces++;
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
