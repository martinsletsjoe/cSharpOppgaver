namespace _329D_Minibank;

public class BankServer
{
    private List<BankAccount> _people = new List<BankAccount>()
    {
        new BankAccount(1,1001),
        new BankAccount(2,1002),
        new BankAccount(3,1003),
        new BankAccount(4,1000),
        new BankAccount(5,1000),
    };



    public int? GetPerson(int id)
    {
        foreach (var person in _people)
        {
            if (id != person.GetId())continue;
            return person.Money;
        }

        return null;
    }
}