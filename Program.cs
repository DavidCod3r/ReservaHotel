using Hotel.Entities;
using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation.");
            }
            else
            {
                Reservation res = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(res);
                Console.WriteLine();
                Console.WriteLine("Enter data to udate teh reservation: ");

                Console.Write("Check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if(checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates.");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation.");
                }
                else
                {
                    res.UpdateDates(checkIn, checkOut);
                    Console.WriteLine(res);
                }

            }

        }
    }
}
