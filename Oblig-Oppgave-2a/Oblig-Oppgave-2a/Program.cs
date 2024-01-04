namespace Oblig_Oppgave_2a
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
            

            Console.WriteLine(martin.GetStatus());
            martin.ChangeStatus(Status.LevertDokumentasjon);
            martin.ChangeStatus(Status.FåttTilbud);
            martin.ChangeStatus(Status.SignertKontrakt);
            Console.WriteLine(martin.GetStatus());

            if (martin.CheckHistory(Status.FåttTilbud))
            {
                Console.WriteLine("hei");
            }

            //martin.ChangeStatus(Status.IkkeStartet);
            //Console.WriteLine(martin.GetStatus());
            //martin.ChangeStatus(Status.SignertKontrakt);
            //Console.WriteLine(martin.GetStatus());
        }

    }

}
