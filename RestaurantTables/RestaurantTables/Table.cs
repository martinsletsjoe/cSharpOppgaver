namespace RestaurantTables;

public class Table
{
    private string TableName { get; set; }
    private int Capacity { get; set; }
    public List<Reservation> Reservations;

    public Table(string tableName, int capacity)
    {
        TableName = tableName;
        Capacity = capacity;
    }

    public string GetDescription()
    {
        var person = Capacity > 1 ? "personer" : "person";
        return $"Bord {TableName} har plass til {Capacity} {person}";
    }

    public void ReserveTable(Reservation reservation)
    {

    }
}