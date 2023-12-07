namespace oppgave._329A;

public class Player
{
    public string Name { get; }
    public int Points { get; private set; }


    public Player(string name, int points)
    {
        Name = name;
        Points = points;
    }
    public void Play(Player player2)
    {
        Random random = new Random();
        int num = random.Next(20);

        if (num % 2 == 0)
        {
            player2.Points++;
            Points--;
        }
        else
        {
            player2.Points--;
            Points++;
        }
    }

    public void ShowNameAndPoints()
    {
        Console.WriteLine($"{Name} har {Points} poeng");
    }
}