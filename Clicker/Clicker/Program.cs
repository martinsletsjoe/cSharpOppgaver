namespace Clicker
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var clickerGame = new ClickerGame();

            

            while (true)
            {
                var points = clickerGame.GetPoints();
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n - SPACE = klikk (og få poeng)\r\n"
                + " - K = kjøp oppgradering \r\n       øker poeng per klikk \r\n       "
                + "koster 10 poeng\r\n - S = kjøp superoppgradering \r\n       "
                + "øker \"poeng per klikk\" for den vanlige oppgraderingen.\r\n       "
                + "koster 100 poeng\r\n - X = avslutt applikasjonen");
                Console.WriteLine($"Du har {points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");
                var command = Console.ReadKey().KeyChar;
                if (command == 'X') clickerGame.Exit();
                else if (command == ' ') clickerGame.Click();
                else if (command == 'K' && points >= 10)
                {
                    clickerGame.Upgrade();
                }
                else if (command == 'S' && points >= 100)
                {
                    clickerGame.BigUpgrade();
                }
            }
        }
    }
}
