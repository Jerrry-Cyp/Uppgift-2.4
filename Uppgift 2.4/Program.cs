using System;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut medellön");
            Console.WriteLine("Ange lön för anställd1:");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange lön för anställd2:");
            double l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ange lön för anställd3:");
            double l3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Medellön: {(l1 + l2 + l3) / 3}");
        }
    }
}