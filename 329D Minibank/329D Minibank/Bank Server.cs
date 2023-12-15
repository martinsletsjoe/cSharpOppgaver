using System.Text;

namespace _329D_Minibank;

public class BankServer
{

    private List<BankAccount> _bankAccounts;

    public BankServer()
    {
        _bankAccounts = new List<BankAccount>();
    }

    public BankAccount AddAccount(string name, int money, int Id)
    {
        var account = new BankAccount(name, money, Id);
        _bankAccounts.Add(account);
        return account;
    }

    public BankAccount GetAccount(int Id)
    {
        return _bankAccounts.SingleOrDefault(b => b.Id == Id);
    }

    public string GetAllAccounts()
    {
        var text = new StringBuilder();
        text.AppendLine("Her er alle som har konto hos oss");
        foreach (var account in _bankAccounts)
        {
            var accountName = account.Name;
            accountName.ToString();
            text.Append(accountName + " ");
        }

        return text.ToString();
    }
}