namespace consoleApplikasjonTest;

public class Question
{
    private string _text;
    private string _answer;
    private string _alternativ1;
    private string _alternativ3;
    private string _alternativ2;

    public Question(string text, string alternativ1, string alternativ3, string alternativ2, string answer)
    {
        _text = text;
        _answer = answer;
        _alternativ1 = alternativ1;
        _alternativ3 = alternativ3;
        _alternativ2 = alternativ2;
        


    }



    public void Show()
    {
        Console.WriteLine(_text);
        Console.WriteLine($" A: {_alternativ1}");
        Console.WriteLine($" B: {_alternativ2}");
        Console.WriteLine($" C: {_alternativ3}");
    }

    public int CheckAnswer()
    {
        Console.Write("Skriv inn a, b eller c: ");

        var answer1 = Console.ReadLine();
        if (answer1 == _answer)
        {
            Console.WriteLine("Riktig!");
            return 1;
        }
        else
        {
            Console.WriteLine("Feil");
            return 0;
        }

    }
}