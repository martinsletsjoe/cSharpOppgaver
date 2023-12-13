using System.Text;

namespace vacationTour;

public class Vacation
{
    public string Name { get; set; }
    public DateTime DepartureDate { get; }
    public DateTime ReturnDate { get; }
    public int PartySize { get; }
    public int Cost { get; }
    List<Booking> _bookings { get; }

    public Vacation(string name, DateTime departureDate, 
        DateTime returnDate, int partySize, int cost)
    {
        Name = name;
        DepartureDate = departureDate;
        ReturnDate = returnDate;
        PartySize = partySize;
        Cost = cost;
        _bookings = new List<Booking>();
    }



    public string GetDescription()
    {
        return Name;
    }

    public Booking Book(string name, int size)
    {
        var booking = new Booking(name, size);
        _bookings.Add(booking);
        return booking;
    }

    public string GetAllBookingsAsText()
    {
        var text = new StringBuilder();
        var dateFormatting = "dd.MM.yyyy";
        text.AppendLine($"{Name} - fra {DepartureDate:D} til {ReturnDate:D} - {PartySize} plasser");
        foreach (var booking in _bookings)
        {
            var traveltext = booking.GetAsText();
            text.Append(traveltext);
        }
        return text.ToString();
    }
}