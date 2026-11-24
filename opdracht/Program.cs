namespace opdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] naam = new string[5];

            naam[0] = "Alice";
            naam[1] = "Bob";
            naam[2] = "Charlie";
            naam[3] = "David";
            naam[4] = "Eve";
     
            Console.WriteLine(string.Join(", ", naam));
        }
        
    }
}
