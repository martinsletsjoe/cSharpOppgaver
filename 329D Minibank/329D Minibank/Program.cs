namespace _329D_Minibank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankServer = new BankServer();

            var megmartin = bankServer.AddAccount("Martin", 10, 1);
            var megLars = bankServer.AddAccount("Lars", 112, 2);
            var megSimen = bankServer.AddAccount("Simen", 11, 3);

            Console.WriteLine("Write your PIN");
            var UserInput = Console.ReadLine();
            var UserInputToInt = Int32.Parse(UserInput);


            var UserAccount = bankServer.GetAccount(UserInputToInt);
            UserAccount.AddFunds(200);
            Console.WriteLine(UserAccount.Money);


            var text = bankServer.GetAllAccounts();
            Console.WriteLine(text);

        }
    }
}