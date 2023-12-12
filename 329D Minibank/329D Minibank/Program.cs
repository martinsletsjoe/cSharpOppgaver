namespace _329D_Minibank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankServer = new BankServer();

            Console.WriteLine(
            bankServer.GetPerson(1));

            //Console.WriteLine(person.GetId());
        }
    }
}