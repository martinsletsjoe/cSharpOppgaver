namespace Clicker;

public class Click
{
    private ClickerGame game;
    

    public void Run()
    {
        game.GetPoints() += _pointsPerClick;
    }
}