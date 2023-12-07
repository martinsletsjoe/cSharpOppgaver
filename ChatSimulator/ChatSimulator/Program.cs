namespace ChatSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new ChatServer();

            var client1 = new ChatClient("Karl", server);
            var client2 = new ChatClient("Eirik", server);
            var client3 = new ChatClient("Linn", server);


            client1.Say("Hei");
        }
    }
}