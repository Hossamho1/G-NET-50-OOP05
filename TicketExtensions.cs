

namespace ConsoleApp7;

public static  class TicketExtensions
{
    public static void PrintTicketDetails(this Ticket ticket)
    {
        Console.WriteLine($" ------------ Extension Method: Receipt --------   "
           + "========== RECEIPT ==========\r\n" +
            $"Movie: {ticket.MovieName}" +
            $", Price: {ticket.Price} EGP" +
            $"Final {ticket.CalculateFinalPrice()}" +
            $", status: {ticket.IsBooked}");

    }

    public static double TotalRevenue(this List<Ticket> tickets)
    {
        double totalRevenue = 0;
        foreach (var ticket in tickets)
        {
            totalRevenue += ticket.CalcTotal(14);
        }
        return totalRevenue;
    }


}
