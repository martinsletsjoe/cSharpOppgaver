namespace ChatSimulator
{
    public class ChatServer
    {
        private List<ChatClient> _clients;


        public ChatServer()
        {
            _clients = new List<ChatClient>();
        }

        public void Broadcast(ChatClient client, string message)
        {
            foreach (var chatClient in _clients)
            {
                if (chatClient != client)
                {
                    chatClient.Receive(message);
                }
            }
        }



        public void Register(ChatClient chatClient)
        {
            _clients.Add(chatClient);
        }
    }
}