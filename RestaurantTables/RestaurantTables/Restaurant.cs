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
        Tables = new List<Table>();
        Reservations = new List<Reservation>();
    }
    public Table AddTable(string name, int capacity)
    {
        var newTable = new Table(name, capacity);

        Tables.Add(newTable);
        return newTable;
    }


    public Reservation CreateReservation(string name, string phone, int partySize, DateTime dateTime)
    {
        // Check if the table is available at the specified time
        if (IsTableAvailable(tableA, dateTime, partySize))
        {
            // If available, create the reservation and return success message
            var reservation = new Reservation(name, phone, partySize, dateTime);
            tableA.ReserveTable(reservation);
            return new Reservation(true, reservation);
        }
        else
        {
            // If not available, return a failure message
            return new Reservation(false, null);
        }
    }

    private bool IsTableAvailable(Table table, DateTime dateTime, int partySize)
    {
        // Add your logic to check if the table is available at the specified time
        // You might want to check if the table is not reserved for that time slot
        // and if it can accommodate the party size.

        // For simplicity, let's assume the table is always available for now.
        return true;
    }
}