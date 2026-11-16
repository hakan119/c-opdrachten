namespace opdracht3
{
    internal class opdracht_3
    {
        static void Main(string[] args)
        {
            string invoer = "42"; // eerst string invoer 42 daarna int resultaat = getal x 2; dat is 84. en de oranje staat het dubbele is en 42 dus 42x2 is 84
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;

            Console.WriteLine("Het dubbele is: " + resultaat);
            Console.ReadLine(); 
        }
    }
}
