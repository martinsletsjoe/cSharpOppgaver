using System.Text;

namespace vacationTour;

public class Agency
{
    private string _name;
    List<Vacation> _vacations;


    public Agency(string name)
    {
        _name = name;
        _vacations = new List<Vacation>();
    }


    public Vacation RegisterTravel(string title, DateTime departureDate, 
        DateTime returnDate, int capacity, int cost)
    {
        var newVacation = new Vacation(title, departureDate,
            returnDate, capacity, cost);

        _vacations.Add(newVacation);
        return newVacation;
    }

    public Vacation GetTravel(string name)
    {
        return _vacations.SingleOrDefault(v => v.Name == name);
    }

    public string GetAllBookingsAsText()
    {
        var text = new StringBuilder();
        foreach (var vacation in _vacations)
        {
            var traveltext = vacation.GetAllBookingsAsText();
            text.Append(traveltext);
        }
        return text.ToString();
    }
}

/* 
    public DateTime departureDate;
   public DateTime returnDate;
   public int partySize;
   public int cost;
*/