namespace Apteka;

public class Lek
{
    public static int LiczbaLekow { get; private set; } = 0;
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int IloscNaStanie { get; set; }

    public Lek(string nazwa, decimal cena, int ilosc)
    {
        Nazwa = nazwa;
        Cena = cena;
        IloscNaStanie = ilosc;
        LiczbaLekow++;
    }

    public override string ToString()
    {
        return $"Lek: {Nazwa}, Cena: {Cena}, Ilość na stanie: {IloscNaStanie}";
    }

    public bool CzyDostepny()
    {
        return IloscNaStanie > 0;
    }

    public void Sprzedaj(int ilosc)
    {
        IloscNaStanie -= ilosc;
    }
    
    public static void WypiszLiczbeLekow()
    {
        Console.WriteLine($"Mamy {LiczbaLekow} lekow w aptece.");
    }
}