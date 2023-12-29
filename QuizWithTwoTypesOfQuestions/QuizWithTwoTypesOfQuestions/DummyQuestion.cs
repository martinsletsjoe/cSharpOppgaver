namespace QuizWithTwoTypesOfQuestions;

public class DummyQuestion : IQuestion
{
    public bool Run()
    {
        Console.WriteLine("Dummy");
        return true;
    }
}