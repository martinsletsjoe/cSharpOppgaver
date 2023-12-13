namespace vacationTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var terjeAgency = new Agency("Terjes reisebyrå");
            var departureDate = new DateTime(2024, 5, 17);
            var returnDate = new DateTime(2024, 5, 25);
            var travel1 = terjeAgency.RegisterTravel("Vinsmaking i Toscana", departureDate, returnDate, 20, 9900);

            var travel2 = terjeAgency.GetTravel("Vinsmaking i Toscana");
            travel2.Book("Hansen", 5);

            var text = terjeAgency.GetAllBookingsAsText();
            Console.WriteLine(text);
        }
    }
}