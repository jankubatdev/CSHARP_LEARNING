namespace Apteka;

public class Lek
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int IloscNaStanie { get; set; }

    public Lek(string nazwa, decimal cena, int ilosc)
    {
        Nazwa = nazwa;
        Cena = cena;
        IloscNaStanie = ilosc;
    }

    public override string ToString()
    {
        return $"Lek: {Nazwa}, Cena: {Cena}, Ilość na stanie: {IloscNaStanie}";
    }
}