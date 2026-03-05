

namespace ConsoleApp7;
public static class BookingHelper
{

    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double totalPrice = numberOfTickets * pricePerTicket;
        if (numberOfTickets >= 5)
        {
            return totalPrice * 0.90;
        }
        return totalPrice;


    }
    private static int _counter = 1;
    public static string GenerateBookingReference()
    {

        string reference =$"BK-{_counter}";
        _counter++;
        return reference;
    }



    public static void PrintAllItem(Iprintable[] items  )
    {
        foreach (var item in items)
        {
            item.PrintTicket();
        }

    }





}

