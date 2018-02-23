using System;

namespace AirlineReservations
{
    class FlightManifest
    {
        private const int PLANE_SEATS = 10, FIRST_CLASS_SEATS = 5;
        public const int FIRST_CLASS = 1, ECONOMY = 2;
        private bool[] seatReserved;

        // constructor
        public FlightManifest()
        {
            seatReserved = new bool[PLANE_SEATS + 1];
            for (int i = 0; i < seatReserved.Length; ++i)
                seatReserved[i] = false;
        }

        // seat a passenger in first class
        private void SeatInFirst()
        {
            bool seated = false;

            for (int i = 1; i <= FIRST_CLASS_SEATS; ++i)
            {
                if (!seatReserved[i] && !seated)
                {
                    seatReserved[i] = true;
                    Console.WriteLine("Your seat number is {0}. Enjoy the flight!", i);
                    seated = true;
                }
            }
        }

        // seat a passenger in economy class
        private void SeatInEconomy()
        {
            bool seated = false;
            
            for (int i = FIRST_CLASS_SEATS + 1; i < seatReserved.Length; ++i)
            {
                if (!seatReserved[i] && !seated)
                {
                    seatReserved[i] = true;
                    Console.WriteLine("Your seat number is {0}. Enjoy the flight!", i);
                    seated = true;
                }
            }
        }

        // check the availability of first class seats
        private int FirstStatus()
        {
            int seatsAvailable = 0;

            for (int i = 1; i <= FIRST_CLASS_SEATS; ++i)
                if (seatReserved[i] == false)
                    ++seatsAvailable;

            return seatsAvailable;
        }

        // check the availability of economy class seats
        private int EconomyStatus()
        {
            int seatsAvailable = 0;

            for (int i = FIRST_CLASS_SEATS + 1; i < seatReserved.Length; ++i)
                if (seatReserved[i] == false)
                    ++seatsAvailable;

            return seatsAvailable;
        }

        // seat a passenger
        public void SeatPassenger()
        {
            int section;
            string nextFlight = "The next flight is in 3 hours.", userInput;

            if (EconomyStatus() > 0 || FirstStatus() > 0)
            {
                Console.Write("Enter 1 to reserve a First Class seat, or 2 for an Economy Class seat: ");
                section = Convert.ToInt32(Console.ReadLine());
                if (section == ECONOMY)
                {
                    if (EconomyStatus() > 0)
                        SeatInEconomy();
                    else if (FirstStatus() > 0)
                    {
                        Console.Write("Economy not available, switch to First Class? (y/n): ");
                        userInput = Console.ReadLine();
                        if (userInput.Equals("y"))
                            SeatInFirst();
                        else
                            Console.WriteLine(nextFlight);
                    }
                }
                else if (section == FIRST_CLASS)
                {
                    if (FirstStatus() > 0)
                        SeatInFirst();
                    else if (EconomyStatus() > 0)
                    {
                        Console.Write("First Class not available, switch to Economy Class? (y/n): ");
                        userInput = Console.ReadLine();
                        if (userInput.Equals("y"))
                            SeatInEconomy();
                        else
                            Console.WriteLine(nextFlight);
                    }
                }
                else
                    Console.WriteLine("Invalid entry. Try again");
            }
            else
                Console.WriteLine("Plane is full. " + nextFlight);
        }
    }
}
