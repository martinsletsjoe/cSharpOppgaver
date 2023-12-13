namespace RestaurantTables;

public class Reservation
{
    private string Surname { get; set; }
    private string ContactInfo { get; set; }
    private int NumberOfPeople { get; set; }
    public DateTime ReservationTime { get; set; }


    public Reservation(string surname, string contactInfo, int numberOfPeople, DateTime reservationTime)
    {
        Surname = surname;
        ContactInfo = contactInfo;
        ReservationTime = reservationTime;
        NumberOfPeople = numberOfPeople;
    }


    public Reservation GetDescription()
    {

        
            var dateOfArrival = ReservationTime.ToString("dd.MM.yyyy");
            var hourOfArrival = ReservationTime.ToString("HH:mm");
            return $"Reservert bord til {NumberOfPeople} personer {dateOfArrival} kl.{hourOfArrival}";
        
        

        return null;
    }

    public Restaurant GetReservation()
    {
        foreach (var VARIABLE in Reservation)
        {
            //Restaurant.Reservations;

            return Restaurant;

        }
    }
}