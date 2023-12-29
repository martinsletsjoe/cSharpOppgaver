namespace FallingParticlesTest;

public class Paddle
{
    public int Position { get; set; }
    public string Form { get; }

    public Paddle()
    {
        Position = 0;
        Form = "========";
    }
}