namespace RestaurantTables;

public class Reservation
{
    private string Name { get; set; }
    private string Phone { get; set; }
    private int PartySize { get; set; }
    public DateTime DateTime { get; set; }
    public bool Occupied { get; set; }



    public Reservation(string name, string phone, int partySize, DateTime dateTime)
    {
        Name = name;
        Phone = phone;
        DateTime = dateTime;
        PartySize = partySize;
    }


    //public Reservation GetDescription()
    //{


    //        var dateOfArrival = DateTime.ToString("dd.MM.yyyy");
    //        var hourOfArrival = DateTime.ToString("HH:mm");
    //        return $"Reservert bord til {PartySize} personer {dateOfArrival} kl.{hourOfArrival}";



    //    return null;
    //}

    //public Restaurant GetReservation()
    //{
    //    foreach (var VARIABLE in Reservation)
    //    {
    //        //Restaurant.Reservations;

    //        return Restaurant;

    //    }
    //}

}