namespace RestaurantTables;

public class Reservation
{
    public string Surname { get; set;  }
    public string ContactInfo { get; set; }
    public int NumberOfPeople { get; set; }
    public DateTime ReservationTime { get; set; }

    public Reservation(string surname, string contactInfo, int numberOfPeople, DateTime reservationTime)
    {
        Surname = surname;
        ContactInfo = contactInfo;
        ReservationTime = reservationTime;
        NumberOfPeople = numberOfPeople;
    }


    public string GetDescription()
    {
        var dateOfArrival = ReservationTime.ToString("dd.MM.yyyy");
        var hourOfArrival = ReservationTime.ToString("HH:mm");
        return $"Reservert bord til {NumberOfPeople} personer {dateOfArrival} kl.{hourOfArrival}";
    }

    public object GetReservation()
    {
        return GetDescription();
    }
}