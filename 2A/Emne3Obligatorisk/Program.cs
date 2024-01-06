namespace Emne3Obligatorisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student("Martin"),
                new Student("Lars"),
            };
            var martin = students[0];

            // Hent nåværende status
            Console.WriteLine(martin.GetStatus());

            // lovlig status bytte
            martin.ChangeStatus(Status.LevertDokumentasjon);
            Console.WriteLine(martin.GetStatus());

            // ulovlig status bytte, ingen forandring skal skje
            martin.ChangeStatus(Status.SignertKontrakt);
            Console.WriteLine(martin.GetStatus());

            // sjekke studentens status historie
            StudentHistory(martin, Status.Brutt);
            Console.WriteLine(martin.CheckHistory(Status.Brutt));
        }

        private static void StudentHistory(Student martin, Status status)
        {
            var statusText = martin.CheckHistory(status) ? "" : "ikke";
            var history = $"{martin.Name} {statusText} har hatt denne statusen.";

            Console.WriteLine(history);
        }
    }
}
