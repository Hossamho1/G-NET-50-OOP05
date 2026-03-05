using System.Diagnostics;
using System.Transactions;

namespace ConsoleApp7;

    internal class Program
    {
         static void Main(string[] args)
        {



        Question.q1();
        Question.q2();
        Question.q3();
        Question.q4();


        Console.WriteLine("========Cinema Simulation=========");



        Cinemaa cinemaa = new Cinemaa("Metro", new Projector());  
         
        Projector projector = new Projector();
        projector.Start();

     


        Console.WriteLine("====== All Tickets");






        StandardTicket standard = new StandardTicket("Avatar 2", 100, "A15");
        VIPTicket vip = new VIPTicket("Oppenheimer", 150, true);
        IMAXTicket imax = new IMAXTicket("Interstellar", 120, true);
        standard.BookTicket();
        vip.BookTicket();
        imax.BookTicket();
        cinemaa.AddTicket(standard);
        cinemaa.AddTicket(vip);
        cinemaa.AddTicket(imax);
        cinemaa.PrintAllTickets();

        Console.WriteLine(value: " --Clone Test--");

        var  Clone= vip.Clone();
        Console.WriteLine("Original VIP Ticket:");
        vip.PrintTicket();
        Console.WriteLine("Cloned VIP Ticket:");
        ((VIPTicket)Clone).MovieName="Tito";
        ((VIPTicket)Clone).PrintTicket();
        Console.WriteLine(value: " --After Cancellation  --");

        standard.CancelBooking();





        Console.WriteLine("======BookingHelper.PrintAll====");
        Iprintable[] items = new Iprintable[] { standard, vip, imax };

        BookingHelper.PrintAllItem(items);










        projector.Stop();
















    }
}




    

