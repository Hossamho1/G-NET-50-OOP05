

namespace ConsoleApp7;


public class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; set; } = 50;

    public VIPTicket(string movieName, double price, bool loungeAccess)
        : base(movieName, price + 50)
    {
        LoungeAccess = loungeAccess;
    }

    public override string ToString()
    {
        return base.ToString() +
               $", Lounge Access: {LoungeAccess}, Service Fee: {ServiceFee} EGP";
    }
    public override void PrintTicket()
    {

        base.PrintTicket() ;
        Console.WriteLine(
            $"  Lounge :{LoungeAccess}  |" +
            $"  service fee {ServiceFee} " 

        );
    }
    public override object Clone()
    {
        return new VIPTicket(this.MovieName, this.Price, this.LoungeAccess);
    }
}