namespace _329D_Minibank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankServer = new BankServer();

            var megmartin = bankServer.AddAccount("martin", 10);
            Console.WriteLine(megmartin.Name + megmartin.Money);
        }
    }
}