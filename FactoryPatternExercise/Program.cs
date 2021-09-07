using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does the vehicle have?");
            string input = Console.ReadLine();

            IVehicle vehicle1 = VehicleFactory.GetVehicle(input);

            vehicle1.Drive();



        }
    }
}
