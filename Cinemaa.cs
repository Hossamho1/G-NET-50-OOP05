
namespace ConsoleApp7;

internal class Cinemaa
{
    public string CinemaaName { get; set; } = default!;
    public Projector Projector { get; set; } = default!;
    private Ticket[] tickets = new Ticket[20];
    public Cinemaa(string CinemaaName , Projector Projector)
    {
        this.CinemaaName= CinemaaName;
        Projector projector = new Projector();
    }

    public bool AddTicket(Ticket t)
    {
        if (t == null)
            return false;


        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i] == null)
            {
                tickets[i] = t;
                return true;
            }
        }
        return false;
    }


    public Ticket PrintAllTickets()
    {

        foreach (var ticket in tickets)
        {
            if (ticket != null)
            {
                ticket.PrintTicket();            }
        }
        return null!;
    }

}
