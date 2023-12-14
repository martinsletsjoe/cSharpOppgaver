namespace _329D_Minibank;

public class BankServer
{
    List<BankAccount> _bankAccounts;

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
}