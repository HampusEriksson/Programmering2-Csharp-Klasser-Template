using System;

namespace FirstClass
{
    // Skapa din första klass
    public class ClassName
    {
        // Attribut (egenskaper)
        private string Attribute1;
        private int Attribute2;
        private bool Attribute3;

        // Konstruktor
        public ClassName(string attribute1, int attribute2, bool attribute3)
        {
            Attribute1 = attribute1;
            Attribute2 = attribute2;
            Attribute3 = attribute3;
        }

        // ToString-metod
        public override string ToString()
        {
            return $"Attribute1: {Attribute1}, Attribute2: {Attribute2}, Attribute3: {Attribute3}";
        }

        // En  metod
        public void AMethod()
        {
            // Implementera metodens funktionalitet här
            Console.WriteLine("Denna metod gör något!");
        }

        // En annan  metod
        public void AnotherMethod()
        {
            // Implementera metodens funktionalitet här
            Console.WriteLine("Denna metod gör något!");
        }
    }

    // Huvudprogrammet där klassen används
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa ett objekt av din nya klass och kalla på metoder
        }
    }
}
