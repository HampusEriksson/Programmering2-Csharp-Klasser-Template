using System;
using System.Collections.Generic;

// Klass som ska fyllas i
// Bra klasser för denna uppgift: Bok, Film, Låt
public class ClassName
{
    // Skapa egenskaper för klassen här

    public ClassName()
    {
        // Konstruktor, initiera egenskaper här
    }

    public override string ToString()
    {
        // Returnera en strängrepresentation av objektet
        return "";
    }
}


public class Program
{
    // Lista för att lagra objekt
    private static List<ClassName> objectsList = new List<ClassName>();

    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Meny:");
            Console.WriteLine("1. Skapa objekt");
            Console.WriteLine("2. Visa alla objekt");
            Console.WriteLine("3. Avsluta program");
            Console.Write("Välj ett alternativ: ");
            
            string input = Console.ReadLine();

            if (input == "1")
            {
                // Skapa ett objekt av din klass och lägg till i listan
            }
            else if (input == "2")
            {
                // Skriv ut alla objekt från listan med en foreach-loop
            }
            else if (input == "3")
            {
                // Sätt variabeln running till false för att avsluta programmet
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Försök igen.");
            }
        }
    }

}

