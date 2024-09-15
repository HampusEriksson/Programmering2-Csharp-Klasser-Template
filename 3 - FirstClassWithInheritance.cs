using System;

// I denna uppgift ska du skapa dina första klasser som använder arv
// Skapa en basklass som innehåller attribut och metoder
// Skapa en sub-klasse som ärver från basklassen och lägg till egna attribut och metoder
// Skapa en till sub-klasse som ärver från basklassen och lägg till egna attribut och metoder
// Exempel 1 på klasser som passar bra: Vehicle (fordon) som basklass och Car (bil) och Boat (båt) som sub-klasser
// Exempel 2 på klasser som passar bra: Animal (djur) som basklass och Dog (hund) och Cat (katt) som sub-klasser
// Exempel 3 på klasser som passar bra: Person som basklass och Employee och Customer som sub-klasser
// Exempel 4 på klasser som passar bra: Shape (form) som basklass och Circle och Square som sub-klasser
// Exempel 5 på klasser som passar bra: Media (media) som basklass och Book och Movie som sub-klasser

namespace FirstClass
{
    // Skapa en basklass
    public class BaseClass
    {
        // Attribut (egenskaper) i basklassen
        protected string Attribute1;
        protected int Attribute2;

        // Parameterlös konstruktor i basklassen
        public BaseClass()
        {
            Attribute1 = "Unknown";
            Attribute2 = 0;
        }

        // ToString-metod i basklassen
        public override string ToString()
        {
            return $"Attribute1: {Attribute1}, Attribute2: {Attribute2}";
        }

        // En metod i basklassen
        public void BaseMethod()
        {
            Console.WriteLine("Denna metod finns i basklassen och gör något!");
        }
    }

    // Skapa en sub-klass som ärver från BaseClass
    public class DerivedClass : BaseClass
    {
        // Extra attribut i sub-klassen
        private bool Attribute3;

        // Konstruktor
        public DerivedClass(string attribute1, int attribute2, bool attribute3)
        {
            Attribute1 = attribute1;
            Attribute2 = attribute2;
            Attribute3 = attribute3;
        }

        // Override av ToString-metoden för att inkludera sub-klassens attribut
        public override string ToString()
        {
            return $"Attribute1: {Attribute1}, Attribute2: {Attribute2}, Attribute3: {Attribute3}";
        }

        // En metod specifik för sub-klassen
        public void DerivedMethod()
        {
            Console.WriteLine("Denna metod finns bara i sub-klassen och gör något specifikt!");
        }
    }

    // Skapa en sub-klass som ärver från BaseClass
    public class DerivedClass2 : BaseClass
    {
        // Extra attribut i sub-klassen
        private bool Attribute3;

        // Konstruktor
        public DerivedClass2(string attribute1, int attribute2, bool attribute3)
        {
            Attribute1 = attribute1;
            Attribute2 = attribute2;
            Attribute3 = attribute3;
        }

        // Override av ToString-metoden för att inkludera sub-klassens attribut
        public override string ToString()
        {
            return $"Attribute1: {Attribute1}, Attribute2: {Attribute2}, Attribute3: {Attribute3}";
        }

        // En metod specifik för sub-klassen
        public void DerivedMethod()
        {
            Console.WriteLine("Denna metod finns bara i sub-klassen och gör något specifikt!");
        }
    }

    // Huvudprogrammet där klassen används
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
