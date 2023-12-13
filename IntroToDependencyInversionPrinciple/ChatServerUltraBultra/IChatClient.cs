namespace IntroToDependencyInversionPrinciple.Chat;

public interface IChatClient
{
    void Receive(string message);
}