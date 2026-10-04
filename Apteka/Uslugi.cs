namespace Apteka;

public class Usluga : IPlatny, IOpisywalny
{
    public string Nazwa { get; set; }
    public int CzasTrwania { get; set; }
    public decimal Cena { get; set; }

    public Usluga(string nazwa, int czasTrwania, decimal cena)
    {
        Nazwa = nazwa;
        CzasTrwania = czasTrwania;
        Cena = cena;
    }

    public string Opisz()
    {
        return $"Usługa: {Nazwa}, Czas trwania: {CzasTrwania} minut, Cena: {Cena} zł";
    }

    public decimal ObliczKoszt(int ilosc)
    {
        return Cena * ilosc;
    }

}