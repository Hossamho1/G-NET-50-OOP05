

namespace ConsoleApp7;

public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, double price, bool is3D)
        : base(movieName, is3D ? price + 30 : price)
    {
        Is3D = is3D;
    }

    public override string ToString()
    {
        return base.ToString() + $", 3D: {Is3D}";
      
    }

    public override void PrintTicket()
    {
        base.PrintTicket();
        Console.WriteLine(
            $" | IMAX 3D: {Is3D}"

            );
    }


    public override double CalculateFinalPrice() => Price * 1.2;
}
