namespace codealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            while (car.RaceTrack())
            {
                Console.WriteLine(car.Position);
                car.UpdateSpeed();
                if (car.Position <= 500)
                {
                    car.Accelerate();
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine("Du er færri, gratulars");
        }
    }
}
