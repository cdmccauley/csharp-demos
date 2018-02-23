using System;

namespace AirlineReservations
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightManifest flight001 = new FlightManifest();
            int userInput;

            Console.WriteLine("Flights available:\nFlight #001\n");
            do
            {
                Console.Write("Enter a flight number to RESERVE a seat, or enter '0' to EXIT: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput != 0)
                    flight001.SeatPassenger();
            } while (userInput != 0);

            // hold console
            Console.WriteLine("Press any key to close console window...");
            Console.ReadKey();
        }
    }
}
