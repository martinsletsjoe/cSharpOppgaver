namespace _329D_Minibank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankServer = new BankServer();

            var megmartin = bankServer.AddAccount("Lars", 10);

            var hentMeg = bankServer.GetAccount("Lars");
            hentMeg.AddFunds(200);
            Console.WriteLine(hentMeg.Money);

        }
    }
}