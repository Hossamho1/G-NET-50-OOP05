
namespace ConsoleApp7;

public  interface IBookable
{


    bool IsBooked { get; }
    bool BookTicket();
    bool CancelBooking();
}
