public class ZadanieRenderu : Zadanie
{
    public int Klatki { get; }

    public ZadanieRenderu(string nazwa, int priorytet, int klatki)
        : base(nazwa, priorytet)
    {
        Klatki = klatki;
    }

    public override int SzacowanyCzasSekund() => Klatki * 2;

    public override string ToString()
    {
        return base.ToString() + $"[{Klatki} klatek]";
    }
}






