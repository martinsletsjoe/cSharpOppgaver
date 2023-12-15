namespace _329D_Minibank;

public class BankAccount
{
    public string Name { get; set; }
    public int Money { get; set; }
    public int Id { get; set; }


    public BankAccount(string name, int money, int id)
    {
        Name = name;
        Money = money;
        Id = id;
    }

    public void AddFunds(int funds)
    {
        Money += funds;
    }
}