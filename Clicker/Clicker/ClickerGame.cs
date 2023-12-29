namespace Clicker;

public class ClickerGame : ICommand
{
    private int _points;
    private int _pointsPerClick;
    private int _pointsPerClickIncrease;

    public ClickerGame(int points = 0, int pointsPerClick = 1, int pointsPerClickIncrease = 1)
    {
        _points = points;
        _pointsPerClick = pointsPerClick;
        _pointsPerClickIncrease = pointsPerClickIncrease;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void Exit()
    {
        Environment.Exit(0);
    }

    public void Click()
    {
        _points += _pointsPerClick;
    }

    public void Upgrade()
    {
            _points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
    }

    public void BigUpgrade()
    {
            _points -= 100;
            _pointsPerClickIncrease++;
    }
}