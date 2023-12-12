namespace _329D_Minibank;

public class BankAccount
{
    private int Id { get; }
    public int Money { get; }

    public BankAccount(int id, int money)
    {
        Id = id;
        Money = money;
    }

    public int GetId()
    {
        return Id;
    }
}