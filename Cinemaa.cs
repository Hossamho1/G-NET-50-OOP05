namespace ConsoleApp7;

internal partial class Cinemaa
{
    public string CinemaaName { get; set; } = default!;
    public Projector Projector { get; set; } = default!;

    private Iprintable[] tickets = new Iprintable[20];

    public Cinemaa(string CinemaaName, Projector Projector)
    {
        this.CinemaaName = CinemaaName;
        this.Projector = Projector;
    }
    public void GenerateFullReport()
    {
        Report();
    }

    partial void Report();
}


internal partial class Cinemaa
{
    public bool AddTicket(Iprintable t)
    {
        if (t == null) return false;

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

    partial void Report()
    {
        Console.WriteLine($"--- Tickets for {CinemaaName} ---");
        foreach (var ticket in tickets)
        {
            if (ticket != null)
            {
                ticket.PrintTicket();
            }
        }
    }
}