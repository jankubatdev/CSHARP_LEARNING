using Apteka;

class Program
{
    static void Apteka()
    {
        Console.WriteLine("Hello, World!");

        var z = 5;
        Console.WriteLine(z);

        var lek = new Lek("Paracetamol", 59.99m, 10);
        Console.WriteLine(lek);
        Console.WriteLine(lek.CzyDostepny());

        lek.Sprzedaj(4);
        Console.WriteLine(lek);

        var lek2 = new Lek("Ibuprom", 24.50m, 0);
        Console.WriteLine(lek2.CzyDostepny());

        Lek.WypiszLiczbeLekow();

        try
        {
            var zlyLek = new Lek("Test", -10m, 5);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Zlapano wyjatek: {ex.Message}");
        }
    }

    private static void MutateAndDisplay(MutablePoint p)
    {
        p.X = 100;
        Console.WriteLine($"Point mutated in a method: {p}");
    }

    static void MutateAndDisplay()
    {
        var p1 = new MutablePoint(1, 2);
        var p2 = p1;
        p2.Y = 200;
        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
        Console.WriteLine($"{nameof(p2)}: {p2}");
        MutateAndDisplay(p2);
        Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
    }

    static void InheritanceDemo()
    {
        var lekRp = new LekNaRecepte("Amoksycylina", 15.99m, 20, "Dr. Kowalski");
        Console.WriteLine(lekRp);
        Console.WriteLine(lekRp.CzyDostepny());
        Console.WriteLine(lekRp.Lekarz);
        lekRp.Sprzedaj(5);
        Console.WriteLine(lekRp);
    }

    static void PolymorphismDemo()
    {
        Lek lek3 = new LekNaRecepte("Ibuprofen", 12.99m, 15, "Dr. Nowak");
        Console.WriteLine(lek3);

        Lek[] magazyn = new Lek[]
        {
            new Lek("Paracetamol", 10m, 30),
            new LekNaRecepte("Tramadol", 45m, 8, "Dr. Zielińska"),
            new Lek("Witamina C", 5m, 100),
        };

        foreach (var pozycja in magazyn)
        {
            Console.WriteLine(pozycja);
        }
    }

    static void AbstractClassDemo()
    {
        var Ksztalty = new Ksztalt[]
        {
            new Kolo(5),
            new Prostokat(4, 6)
        };

        foreach (var ksztalt in Ksztalty)
        {
            Console.WriteLine($"Pole ksztaltu: {ksztalt.Pole()}");
        }

        //var Kszalt1 = new Ksztalt();
    }

    static void InterfaceDemo()
    {
        IPlatny[] doZaplaty =
        {
            new Lek("Paracetamol", 10m, 30),
            new LekNaRecepte("Tramadol", 45m, 8, "Dr. Zielińska"),
        };

        foreach (var p in doZaplaty)
            Console.WriteLine($"Koszt 3 szt.: {p.ObliczKoszt(3)}");
    }

    static void Main(string[] args)
    {
        // Apteka();
        // MutateAndDisplay();
        // InheritanceDemo();
        // PolymorphismDemo();
        // AbstractClassDemo();
        InterfaceDemo();
    }
}