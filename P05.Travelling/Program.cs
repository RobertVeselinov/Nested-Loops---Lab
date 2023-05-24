using System;

namespace P05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = string.Empty;
            double sumPrice = 0;
            while ((destination = Console.ReadLine()) != "End")
            {
                double neededPrice = double.Parse(Console.ReadLine());

                for (int i = 0; i >= 0; i++)
                {
                    double money = double.Parse(Console.ReadLine());
                    sumPrice += money;

                    if (sumPrice >= neededPrice)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        sumPrice = 0;
                        break;
                    }
                }
            }

        }
    }
}
