namespace codealong;

public class Car
{
    public int speed;
    public int Position;

    public Car()
    {
        Position = 0;
        speed = 10;
    }

    public bool RaceTrack()
    {
        if (Position >= 1000)
        {
            return false;
        }
        return true;
    }

    public void Accelerate()
    {
        speed += 10;
    }

    public void UpdateSpeed()
    {
        if (Position >= 500 && speed != 0)
        {
            speed -= 10;
        }
        Position += speed;
    }
}
