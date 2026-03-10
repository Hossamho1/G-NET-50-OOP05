using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ConsoleApp7;

    internal class Program
    {
         static void Main(string[] args)
        {





        Console.WriteLine("========Cinema Simulation=========");


        //// ERROR: Cannot create instance of abstract type 'Ticket'
        //Ticket ticket = new Ticket();



        Cinemaa cinemaa = new Cinemaa("Metro", new Projector());  
         
        Projector projector = new Projector();
        projector.Start();

     


        Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");







        Ticket standard = new StandardTicket("Avatar 2", 100, "A15");
        Ticket vip = new VIPTicket("Oppenheimer", 150, true);
        Ticket imax = new IMAXTicket("Interstellar", 120, true);
        standard.BookTicket();
        vip.BookTicket();
        imax.BookTicket();
        cinemaa.AddTicket(standard);
        cinemaa.AddTicket(vip);
        cinemaa.AddTicket(imax);


        cinemaa.GenerateFullReport();





        Ticket[] tickets = new Ticket[]
        {
            new StandardTicket("Avatar 2", 100, "A15"),
            new VIPTicket("Oppenheimer", 150, true),
            new IMAXTicket("Interstellar", 120, true)
        };

        Console.WriteLine("======= Polymorphism in Action =======");

        foreach (var t in tickets) {

            t.BookTicket();
            Console.WriteLine($"Ticket Type: {t.GetType().Name} | Movie: {t.MovieName} |  Final Price: {t.CalculateFinalPrice()} EGP");
                

        }
        Console.WriteLine("--- Extension Method: Receipt ---");

        TicketExtensions.PrintTicketDetails(standard);

        Console.WriteLine("--- Extension Method: Total Revenue ---");

        List<Ticket> ticketList = new List<Ticket> { standard, vip, imax };
        double totalRevenue = TicketExtensions.TotalRevenue(ticketList);
        Console.WriteLine($"Total Revenue from Tickets: {totalRevenue} EGP");











        projector.Stop();
















    }
}




    

