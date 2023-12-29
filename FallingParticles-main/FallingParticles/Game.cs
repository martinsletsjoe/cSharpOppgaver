//using System;
//using System.Reflection.Emit;
//using static System.Formats.Asn1.AsnWriter;
//using System.Reflection.Metadata;

//namespace FallingParticles;

//public class Game
//{
//    private List<Particle> _particles;
//    private Paddle paddle;

//    private bool _isGameOver;
//    private int _level;
//    private int _score;
//    private int _gameRoundsBetweenSpawn;
//    private int _paddleMoveDistance;

//    private Random _random;

//    public Game(int score, int gameRoundsBetweenSpawn)
//    {
//        _paddleMoveDistance = 6; // bra
//        _particles = new List<Particle>(); // bra
//        _isGameOver = false; // bra
        
//        _score = score;
//        _gameRoundsBetweenSpawn = gameRoundsBetweenSpawn;
//        _level = _level;
//        _random = new Random(); // bra 
//    }

//    // game skal holde spillets logikk. og objectene tror jeg? Så hva er de,
//    // det som er ekstra fra det og ikke skal i under klasser skal vel tilbake i program?

//    public void mainGame()
//    {
//        Console.CursorVisible = false;
//        Console.WindowWidth = 80;
//        while (!CheckLostParticle())
//        {
//            InitializeGame();
//            var levelCount = 0;
//            var roundCount = 45;
//            while (true)
//            {
//                DrawGame();
//                MovePaddle();
//                MoveParticles();


//                if (roundCount >= _gameRoundsBetweenSpawn)
//                {
//                    SpawnParticles();
//                    InitGameRoundsBetweenSpawn();
//                    roundCount = 0;
//                }

//                roundCount++;
//                levelCount++;
//                if (levelCount == 100)
//                {
//                    levelCount = 0;
//                    _level++;
//                }
//                Thread.Sleep(100);
//            }
//            var text = "Game Over! Press ENTER to restart";
//            Console.SetCursorPosition(40 - text.Length / 2, 5);
//            Console.WriteLine(text);
//            Console.ReadLine();
//        }
//    }


//    public int InitializeGame()
//    {
//        var centerX = Console.WindowWidth / 2;
//        paddle.Position = centerX - (centerX % _paddleMoveDistance);
//        _particles.Clear();
//        _isGameOver = false;
//        _score = 0;
//        _level = 1;
//        InitGameRoundsBetweenSpawn();
//        return paddle.Position;

//    }

//    public void InitGameRoundsBetweenSpawn()
//    {
//        _gameRoundsBetweenSpawn = 50 / _level;
//    }

//    public void DrawGame()
//    {
//        Console.Clear();
//        Console.SetCursorPosition(60, 0);
//        Console.Write($"Score: {_score}");
//        Console.SetCursorPosition(71, 0);
//        Console.Write($"Level: {_level}");
//        Console.SetCursorPosition(_paddlePosition, Console.WindowHeight - 1);
//        Console.Write(_paddle);

//        foreach (var particle in _particles)
//        {
//            var particleX = (int)Math.Floor(particle.X);
//            var particleY = (int)Math.Floor(particle.Y);
//            Console.SetCursorPosition(particleX, particleY);
//            Console.Write("O");
//        }
//    }

//    public void MovePaddle() // logikk tror jeg?
//    {
//        if (Console.KeyAvailable)
//        {
//            var key = Console.ReadKey(true);
//            var moveLeft = key.Key == ConsoleKey.LeftArrow && _paddlePosition >= _paddleMoveDistance;
//            var moveRight = key.Key == ConsoleKey.RightArrow && _paddlePosition < Console.WindowWidth - _paddle.Length;
//            if (moveLeft || moveRight)
//            {
//                var direction = moveLeft ? -1 : 1;
//                _paddlePosition += direction * 3 * _paddle.Length / 4;
//            }
//        }
//    }

//    public void MoveParticles() // skal i game? tror dette er logikk
//    {
//        for (var index = _particles.Count - 1; index >= 0; index--)
//        {
//            var particle = _particles[index];
//            particle.Y += 0.5f;
//            if (particle.Y > Console.WindowHeight - 1)
//            {
//                _score++;
//                _particles.Remove(particle);
//            }
//        }
//    }

//    public bool CheckLostParticle() // skal i game? // logikk
//    {
//        foreach (var particle in _particles)
//        {
//            if ((particle.X < _paddlePosition || particle.X > _paddlePosition + _paddle.Length)
//                && particle.Y == Console.WindowHeight - 1)
//            {
//                return true;
//            }
//        }

//        return false;
//    }

//    public void SpawnParticles() // skal i game? // logikk
//    {
//        var newParticle = new Particle
//        {
//            X = _random.Next(0, Console.WindowWidth),
//            Y = 0
//        };
//        _particles.Add(newParticle);
//    }
//}