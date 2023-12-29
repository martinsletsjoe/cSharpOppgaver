namespace QuizWithTwoTypesOfQuestions;

public class MultipleChoiceQuestion : IQuestion
{
    private readonly string _question;
    private readonly string[] _answers;
    private readonly int _correctAnserNo;

    public MultipleChoiceQuestion(string question, int correctAnserNo, params string[] answers)
    {
        _question = question;
        _answers = answers;
        _correctAnserNo = correctAnserNo;
    }

    public bool Run()
    {
        Console.WriteLine(_question);
        Console.WriteLine("Svaralternativer:");
        for (int index = 0; index < _answers.Length; index++)
        {
            var answerNo = index + 1;
            var answer = _answers[index];
            Console.WriteLine(answerNo + " : " + answer);
        }

        Console.WriteLine("Velg svaralternativ: ");
        var selectedAnswerNoStr = Console.ReadLine();
        var selectedAnswerNo = Convert.ToInt32(selectedAnswerNoStr);
        return selectedAnswerNo == _correctAnserNo;

    }
}