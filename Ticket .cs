using System.Net.Sockets;
using System.Reflection.Emit;

namespace ConsoleApp7
{
    public abstract class Ticket :   Iprintable,IBookable
    {

        public  string MovieName
        {

            get
            {
                return _movieName;
            } 

            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _movieName = value;
                }
                
            }
        }
        public double Price
        { 
            get 
            {
                return _price;
            } 
            
            set 
            {
                if ( value>0)
                {
                    _price=value;
                }

            }
        }

        public bool IsBooked { get; private set; } 
        private string _movieName;
        private double _price;


        public bool BookTicket()
        {
            if (IsBooked)
              return false;
            IsBooked = true;
            return true;
        }

        public bool CancelBooking()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }
        public void Setprice(double price)
        {
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");

            Price = price;
        }

        public void Setprice(double price, double multiplier) => Price =price* multiplier;




        public double GetPrice()
        {
            return Price;
        }

        public double PriceAfterTax=>  Price * 1.14;


        public int TicketId { get;} 
        private static int _ticketCounter = 0;

        public Ticket(string movieName, double price )
        {
            MovieName = movieName;
          
            Price = price;
            IsBooked = this.IsBooked;
            _ticketCounter++;
            this.TicketId = _ticketCounter;
        }

     

        public static int GetTotalTickets() => _ticketCounter;

        public double CalcTotal(double taxPercent)
        {

            double total = Price + (Price * taxPercent / 100);

            return total;
        }


        public double ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }

            return discountAmount;

        }


        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Movie: {MovieName}, Price: {Price} , Booked{IsBooked}";
        }
        public virtual void PrintTicket()
        {
            Console.WriteLine(
                $"TicketId  : {TicketId}  |  " +
                $"MovieName  : {MovieName} |  " +
                $"Price :{Price}   |  " +
                $" Total after tex (14% tax)  |   : {CalcTotal(14)}" +
                $"|  Booked {IsBooked}"

            );
        }

        public static void ProcessTicket(Ticket ticket)
        {
            ticket.PrintTicket();
        }

      

        public abstract double CalculateFinalPrice();


    }
}
