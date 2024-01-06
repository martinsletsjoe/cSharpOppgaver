namespace FallingParticlesTest;

public class Particle
{
    public float X { get; private set; }
    public float Y { get; private set; }

    public void ChangeParticle(float newX, float newY)
    {
        X = newX;
        Y = newY;
    }
}