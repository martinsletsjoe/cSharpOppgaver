namespace _329D_Minibank;

public class BankAccount
{
    public string Name { get; set; }
    public int Money { get; set; }

    public BankAccount(string name, int money)
    {
        Name = name;
        Money = money;
    }
}