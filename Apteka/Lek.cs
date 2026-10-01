namespace Apteka;

public class Lek
{
    public static int LiczbaLekow { get; private set; } = 0;
    public string Nazwa { get; set; }
    private decimal _cena;
    public decimal Cena
    {
        get => _cena;
        set
        {
            if(value<0)
                throw new ArgumentException("Cena nie może być ujemna.");
            _cena = value;
        }
    }
    private int _iloscNaStanie;
    public int IloscNaStanie
    {
        get => _iloscNaStanie;
        set
        {
            if(value < 0)
                throw new ArgumentException("Ilość na stanie nie może być ujemna.");
            _iloscNaStanie = value;
        }
    }

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

public class LekNaRecepte : Lek
{
    public string Lekarz { get; set; }
    public LekNaRecepte(string nazwa, decimal cena, int ilosc, string lekarz) : base(nazwa, cena, ilosc)
    {
        Lekarz = lekarz;
    }
}