namespace opdracht_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je geboortejaar: ");
            int geboortejaar = int.Parse(Console.ReadLine);

            int huidigJaar = DateTime.Now.Year;
            int leeftijd = huidigJaar - geboortejaar;

            Console.WriteLine("Je bent " + leeftijd + " jaar oud.");
        }
    }
   
        }    

