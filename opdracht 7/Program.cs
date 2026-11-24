namespace opdracht_7;


using System;

class Program
{
    static void Main()
    {
        Console.Write("Raad mijn geluksgetal (een cijfer): ");

        // ReadKey() geeft een ConsoleKeyInfo terug; .KeyChar is het teken (char)
        char invoer = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (invoer == '5')
        {
            Console.WriteLine("Correct! Mijn geluksgetal is 5!");
        }
        else if (char.IsDigit(invoer))
        {
            Console.WriteLine($"{invoer} is niet juist.");
        }
        else
        {
            Console.WriteLine($"{invoer} is niet juist. Voer een cijfer in.");
        }
    }
}
