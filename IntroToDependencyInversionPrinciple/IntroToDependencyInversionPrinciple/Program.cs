using IntroToDependencyInversionPrinciple.Chat;

namespace IntroToDependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new ChatServer();

            var client1 = new ChatClient("per", server);
            var client2 = new ChatClient("Pål", server);
            var client3 = new ChatClient("Espen", server);

            client1.Say("Hello");
            // Pål og Espen får beskjed "Per sier Hello"


        }
    }
}