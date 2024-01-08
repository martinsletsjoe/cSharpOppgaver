namespace _329A;

public class Player
{
    private string _name;
    private int _points;

    public Player(string name, int points)
    {
        _name = name;
        _points = points;
    }

    public void Play(Player player2)
    {
        //Random random = new Random();
        //int winner = random.Next(2);
        _points++;
        player2._points--;


    }

    public void ShowNameAndPoints()
    {
        var result = $"{_name} har {_points}poeng";
        Console.WriteLine(result);

    }
}