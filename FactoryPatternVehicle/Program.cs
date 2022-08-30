using System;

namespace FactoryPatternVehicle
{
    class Program
    {
        private static bool input;

        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create:");

                input = int.TryParse(Console.ReadLine(), out wheelCount);

            } while (!input == false);


           var vehicle = Vehiclefactory.GetVehicle(wheelCount);
           vehicle.Drive();
          
            
        }
    }
}
