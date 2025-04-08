using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;

            string film = Console.ReadLine();

            while (film != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int ticketsSold = 0;

                int studentTickets = 0;
                int standardTickets = 0;
                int kidTickets = 0;

                while (ticketsSold < freePlaces)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                        break;

                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidTickets++;
                            break;
                    }

                    ticketsSold++;
                }

                double percentFull = (ticketsSold / (double)freePlaces) * 100;
                Console.WriteLine($"{film} - {percentFull:F2}% full.");


                totalStudent += studentTickets;
                totalStandard += standardTickets;
                totalKid += kidTickets;

                film = Console.ReadLine(); 
            }

            int totalTickets = totalStudent + totalStandard + totalKid;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(totalStudent / (double)totalTickets) * 100:F2}% student tickets.");
            Console.WriteLine($"{(totalStandard / (double)totalTickets) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(totalKid / (double)totalTickets) * 100:F2}% kids tickets.");
        }
    }
}
