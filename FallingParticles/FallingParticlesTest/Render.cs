namespace FallingParticlesTest;

public class Render
{
    private Paddle _paddle;
    private List<Particle> _particles;

    public Render(Paddle paddle, List<Particle> particles)
    {
        _paddle = paddle;
        _particles = particles;
    }

    public void DrawGame(int score, int level)
    {
        Console.Clear();

        Console.SetCursorPosition(60, 0);
        Console.Write($"Score: {score}");
        Console.SetCursorPosition(71, 0);
        Console.Write($"Level: {level}");

        DrawPaddle();
        DrawParticles();
    }

    private void DrawPaddle()
    {
        Console.SetCursorPosition(_paddle.Position, Console.WindowHeight - 1);
        Console.Write(_paddle.Form);
    }

    private void DrawParticles()
    {
        foreach (var particle in _particles)
        {
            var particleX = (int)Math.Floor(particle.X);
            var particleY = (int)Math.Floor(particle.Y);
            Console.SetCursorPosition(particleX, particleY);
            Console.Write("0");
        }
    }
}