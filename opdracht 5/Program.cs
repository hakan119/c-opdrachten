namespace opdracht_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de breedte: ");
            double breedte = double.Parse(Console.ReadLine());

            Console.Write("Geef de hoogte: ");
            double hoogte = double.Parse(Console.ReadLine());

            double oppervlakte = breedte * hoogte;

            Console.WriteLine("De oppervlakte is: " + string.Format("{0:F2}", oppervlakte));
            Console.ReadLine();
        }
    }
        }
    

