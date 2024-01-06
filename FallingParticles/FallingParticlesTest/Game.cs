namespace FallingParticlesTest;

public class Game
{
    private readonly List<Particle> _particles;
    private readonly Paddle _paddle;
    private readonly Render _render;

    private bool _isGameOver;
    private int _level;
    private int _score;

    private readonly int _paddleMoveDistance;
    public int WindowWidth { get; set; }
    private int _gameRoundsBetweenSpawn;

    private readonly Random _random;

    private int _levelCount;
    private int _roundCount;


    public Game(int windowWidth = 80)
    {
        _isGameOver = false;
        WindowWidth = windowWidth;
        _particles = new List<Particle>();
        _paddle = new Paddle();
        _render = new Render(_paddle, _particles);


        _paddleMoveDistance = 6;

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
        _paddle.ChangePosition(centerX - (centerX % _paddleMoveDistance));
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
        _render.DrawGame( _score, _level);
    }

    private void MovePaddle()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true);
            var moveLeft = key.Key == ConsoleKey.LeftArrow && _paddle.Position >= _paddleMoveDistance;
            var moveRight = key.Key == ConsoleKey.RightArrow && _paddle.Position < Console.WindowWidth - _paddle.Form.Length;
            if (moveLeft || moveRight)
            {
                var direction = moveLeft ? -1 : 1;
                _paddle.ChangePosition(_paddle.Position + direction * 3 * _paddle.Form.Length / 4); 
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
            if ((particle.X < _paddle.Position || particle.X > _paddle.Position + _paddle.Form.Length)
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