namespace ConsoleApp7;

internal class StandardTicket : Ticket
{
    public string SeatNumber { get; set; } = default!;


    public StandardTicket(string movieName, double price, string seatNumber) : base(movieName, price)
    {
        SeatNumber = seatNumber;
    }
    override public string ToString()
    {
        string baseString = base.ToString();
        return baseString + $"Seat Number: {SeatNumber}";
    }

    public override void PrintTicket()
    {
        base.PrintTicket();

        Console.WriteLine(

            $"seat: {SeatNumber}"


        );




    }

    public override object Clone()
    {

        return new StandardTicket(this.MovieName, this.Price, this.SeatNumber);

    }


}
