namespace RestaurantTables;

public class Restaurant
{
    public string Name { get; }
    public int Opening { get; }
    public int Closing { get; }
    public List<Table> Tables;
    public List<Reservation> Reservations;


    public Restaurant(string name, int opening, int closing)
    {
        Name = name;
        Opening = opening;
        Closing = closing;
    }
    public Table AddTable(string name, int capacity)
    {
        var newTable = new Table(name, capacity);

        Tables.Add(newTable);
        return newTable;
    }


    public Reservation CreateReservation(string surname, string contactInfo, int people, DateTime timeOfDay)
    {
        var newcustomer = new Reservation(surname, contactInfo, people, timeOfDay);
        foreach (var reservation in Reservations)
        {
            if (reservation.ReservationTime == timeOfDay) return null;
            Reservations.Add(newcustomer);
        }
        return newcustomer;

    }
}