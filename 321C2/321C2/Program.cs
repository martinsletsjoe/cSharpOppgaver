namespace _321C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coinCountArray = CoinCount.GetCoinCountArray();

            var totalValue = 0;
            foreach (var coin in coinCountArray)
            {
                totalValue += coin.Coins();
            }

            Console.WriteLine(totalValue);
        }
    }
}