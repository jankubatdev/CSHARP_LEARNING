namespace HR_SCHEMA;

using Model;

class Program {
    static void Main(String[] args) {
        Console.Write("Podaj imię: ");
        string imie = Console.ReadLine() ?? "Anonim";

        Console.Write("Podaj wiek: ");
        string? wejscie = Console.ReadLine();

        // TryParse – próbuje zamienić tekst na liczbę, NIE rzuca wyjątku
        // Wykonanie dwóch rzeczy na raz
        // TryParse zwraca bool + wynik zapisuje do zmiennej liczba
        // "20" -> true, liczba = 20 -> wiek = 20
        // "abc" -> false, liczba = 0 -> else
        int? wiek = null;
        if (int.TryParse(wejscie, out int liczba))
            wiek = liczba;
        else
            Console.WriteLine("To nie jest liczba – wiek pominięty.");

        Student s = new(imie, wiek, null);
        Console.WriteLine(s);
    }
}