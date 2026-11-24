namespace opdracht_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies 1, 2 of 3:");
            int keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 1:
                    Console.WriteLine("1 is gekozen");
                    break;
                case 2:
                    Console.WriteLine("2 is gekozen");
                    break;
                case 3:
                    Console.WriteLine("3 is gekozen");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
