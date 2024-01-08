namespace consoleApplikasjonTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var points = 0;
            

            var questions = new Question[]
            {
                new Question("Hva er 2+2?", "2", "3", "4", "b"),
                new Question("Hvilken by er norsk?","Oslo", "Ohio", "Omaha", "a"),
                new Question("Hvilken farge er ikke i den norske flagget?", "Rød", "Grønn", "Blå", "b")
            };
            foreach (var question in questions)
            {
                question.Show();
                points += question.CheckAnswer();
            }

            Console.WriteLine($"Du fikk {points} riktige.");

        }
    }
}
