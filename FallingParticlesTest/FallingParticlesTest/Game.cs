namespace FallingParticlesTest;

public class Game
{
    private List<Particle> _particles;
    private Paddle paddle;

    private bool _isGameOver;
    private int _level;
    private int _score;

    private int _paddleMoveDistance;
    public int WindowWidth { get; set; }
    private int _gameRoundsBetweenSpawn;

    private Random _random;

    private int _levelCount;
    private int _roundCount;


    public Game(int windowWidth = 80)
    {
        WindowWidth = windowWidth;
        _particles = new List<Particle>();

        paddle = new Paddle();
        _paddleMoveDistance = 6;

        _isGameOver = false;
        _level = 1;
        _score = 0;

        _random = new Random();
    }

    public void GameLoop()
    {
        _levelCount = 0;
        _roundCount = 45;
        while (!CheckLostParticle())
        {
            DrawGame();
            MovePaddle();
            MoveParticles();
            if (_roundCount >= _gameRoundsBetweenSpawn)
            {
                SpawnParticles();
                InitGameRoundsBetweenSpawn();
                _roundCount = 0;
            }

            _roundCount++;
            _levelCount++;
            if (_levelCount == 100)
            {
                _levelCount = 0;
                _level++;
            }
            Thread.Sleep(100);
        }
    }

    public void InitializeGame()
    {
        var centerX = Console.WindowWidth / 2;
        paddle.ChangePosition(centerX - (centerX % _paddleMoveDistance));
        _particles.Clear();
        _isGameOver = false;
        _score = 0;
        _level = 1;
        InitGameRoundsBetweenSpawn();
    }

    private void InitGameRoundsBetweenSpawn()
    {
        _gameRoundsBetweenSpawn = 50 / _level;
    }

    private void DrawGame()
    {
        Console.Clear();
        Console.SetCursorPosition(60, 0);
        Console.Write($"Score: {_score}");
        Console.SetCursorPosition(71, 0);
        Console.Write($"Level: {_level}");
        Console.SetCursorPosition(paddle.Position, Console.WindowHeight - 1);
        Console.Write(paddle.Form);

        foreach (var particle in _particles)
        {
            var particleX = (int)Math.Floor(particle.X);
            var particleY = (int)Math.Floor(particle.Y);
            Console.SetCursorPosition(particleX, particleY);
            Console.Write("0");
        }
    }

    private void MovePaddle()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true);
            var moveLeft = key.Key == ConsoleKey.LeftArrow && paddle.Position >= _paddleMoveDistance;
            var moveRight = key.Key == ConsoleKey.RightArrow && paddle.Position < Console.WindowWidth - paddle.Form.Length;
            if (moveLeft || moveRight)
            {
                var direction = moveLeft ? -1 : 1;
                paddle.ChangePosition(paddle.Position + direction * 3 * paddle.Form.Length / 4); 
            }
        }
    }

    private void MoveParticles()
    {
        for (int index = _particles.Count - 1; index >= 0; index--)
        {
            var particle = _particles[index];
            particle.ChangeParticle(particle.X, particle.Y + 0.5f);
            if (particle.Y > Console.WindowHeight - 1)
            {
                _score++;
                _particles.Remove(particle);
            }
        }
    }

    private bool CheckLostParticle()
    {
        foreach (var particle in _particles)
        {
            if ((particle.X < paddle.Position || particle.X > paddle.Position + paddle.Form.Length)
                && particle.Y == Console.WindowHeight - 1)
            {
                return true;
            }
        }
        return false;
    }

    private void SpawnParticles()
    {
        var newParticle = new Particle();
        newParticle.ChangeParticle(_random.Next(0, Console.WindowWidth), 0);
        _particles.Add(newParticle);
    }
}