using System;
using insulator.Place;

namespace insulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insulator");
            NumberOfBuildingOrApartment number = new NumberOfBuildingOrApartment(3, 'a');
            Console.WriteLine("{0} {1}", number.Number, number.Letter);
        }
    }
}