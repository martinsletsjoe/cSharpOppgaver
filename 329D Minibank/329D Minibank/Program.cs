namespace _329D_Minibank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minibank = new Minibank();

            var insertCard = minibank.VerifyId(1111234567);

            //var enterPin = minibank.CheckPin("0123");

        }
    }
}

//Console.WriteLine("Write your PIN");
//var UserInput = Console.ReadLine();
//var UserInputToInt = Int32.Parse(UserInput);


//var UserAccount = bankServer.GetAccount(UserInputToInt);
//UserAccount.AddFunds(200);
//Console.WriteLine(UserAccount.Money);


//var text = bankServer.GetAllAccounts();
////Console.WriteLine(text);