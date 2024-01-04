namespace FallingParticlesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var game = new Game();
            Console.CursorVisible = false;
            Console.WindowWidth = game.WindowWidth;



            while (true)
            {
                game.InitializeGame();

                game.GameLoop();

                var text = "Game Over! Press ENTER to restart";
                Console.SetCursorPosition(40 - text.Length / 2, 5);
                Console.WriteLine(text);
                Console.ReadLine();

            }
        }
    }
}
