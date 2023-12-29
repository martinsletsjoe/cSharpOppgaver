namespace QuizWithTwoTypesOfQuestions;

public class SingleAnswerQuestion : IQuestion
{
    private readonly string _question;
    private readonly string _correctAnswer;

    public SingleAnswerQuestion(string question, string correctAnswer)
    {
        _question = question;
        _correctAnswer = correctAnswer;
    }

    public bool Run()
    {
        Console.WriteLine(_question + " ");
        var answer = Console.ReadLine();
        return answer == _correctAnswer;
    }
}