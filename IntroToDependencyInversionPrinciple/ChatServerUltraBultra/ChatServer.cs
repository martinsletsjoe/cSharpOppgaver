namespace IntroToDependencyInversionPrinciple.Chat;

public class ChatServer
{
    private readonly List<IChatClient> _clients;

    public ChatServer()
    {
        _clients = new List<IChatClient>();
    }

    public void Broadcast(IChatClient client, string message)
    {
        foreach (var chatClient in _clients)
        {
            if (chatClient != client)
            {
                chatClient.Receive(message);
            }
        }
    }

    public void Register(IChatClient client)
    {
        _clients.Add(client);
    }
}