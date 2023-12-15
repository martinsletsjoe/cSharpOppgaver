namespace _329D_Minibank;

public class BankServer
{

    private List<BankAccount> _bankAccounts;

    public BankServer()
    {
        _bankAccounts = new List<BankAccount>();
    }

    public BankAccount AddAccount(string name, int money)
    {
        var account = new BankAccount(name, money);
        _bankAccounts.Add(account);
        return account;
    }

    public BankAccount GetAccount(string name)
    {
        return _bankAccounts.SingleOrDefault(b => b.Name == name);
    }
}