namespace _329B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cell = new VirtualScreenCell();
            cell.AddLowerLeftCorner();
            cell.AddVertical();
            Console.WriteLine(cell.GetCharacter());
        }
    }
}
