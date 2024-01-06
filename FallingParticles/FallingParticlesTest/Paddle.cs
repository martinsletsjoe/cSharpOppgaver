namespace FallingParticlesTest;

public class Paddle
{
    public int Position { get; private set; }
    public string Form { get; }

    public Paddle()
    {
        Position = 0;
        Form = "========";
    }

    public void ChangePosition(int newPosition)
    {
        Position = newPosition;
    }
}