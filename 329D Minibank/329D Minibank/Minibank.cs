namespace _329D_Minibank;

public class Minibank
{
    private BankServer _bankServer;

    public Minibank()
    {
        _bankServer = new BankServer();
    }

    public void ATM()
    {


        var megmartin = _bankServer.AddAccount("Martin", 10, 1111234567, 0123);
        var megLars = _bankServer.AddAccount("Lars", 112, 222234567, 1234);
        var megSimen = _bankServer.AddAccount("Simen", 11, 333234567, 2345);
    }
    //private BankServer _bankServers;

    //public Minibank(int Id)
    //{
    //    _bankServers = new BankServer(Id);
    //}


    //public static object verifyId(int Id)
    //{


    //    // gå gjennom alle bank kontoene, hvordan?
    //    // kanskje minibanken er program? lurer på det
    //}
    public BankAccount VerifyId(int Id)
    {
        return _bankServer.GetAccount(Id);
    }

    public object CheckPin(int pin)
    {
        return _bankServer.PinIsReal(pin);

    }
}

// Skal kunne ta imot kort
// sjekke id
// vise hvor mye penger id har.