using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma tulostaa maatalousnäyttelyn lipun hinnan");

            Ticket firstTicket = new Ticket();
            firstTicket.PrintTicketPrice();
        }
    }
}
