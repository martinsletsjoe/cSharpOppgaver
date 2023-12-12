namespace RestaurantTables;

public class Table
{
    public string tableName { get; set; }
    public int Capacity { get; set; }

    public Table(string tableName, int capacity)
    {
        tableName = tableName;
        Capacity = capacity;
    }

    public string GetDescription()
    {
        var person = Capacity > 1 ? "personer" : "person";
        return $"Bord {tableName} har plass til {Capacity} {person}";
    }
}