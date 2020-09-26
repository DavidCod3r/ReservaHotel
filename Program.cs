using Hotel.Entities;
using Hotel.Entities.Exceptions;
using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation res = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(res);
                Console.WriteLine();
                Console.WriteLine("Enter data to udate teh reservation: ");

                Console.Write("Check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                res.UpdateDates(checkIn, checkOut);

                Console.WriteLine(res);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }

        }
    }
}
