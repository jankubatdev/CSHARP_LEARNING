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



public sealed class ZadanieUploadu : Zadanie
{
    public int MegaBajty { get; }

    public ZadanieUploadu(string nazwa, int priorytet, int megaBajty)
        : base(nazwa, priorytet) => MegaBajty = megaBajty;

    public sealed override int SzacowanyCzasSekund() => MegaBajty / 5;

    public override string ToString() =>
        base.ToString() + $" [{MegaBajty} MB]";
}


public sealed class ZadanieKonwersji : Zadanie
{
    public string Format {  get; }

    public ZadanieKonwersji(string nazwa, int priorytet,  string format)
        : base(nazwa, priorytet)
    {
        Format = format;
    }

    public sealed override int SzacowanyCzasSekund()
    {
        return 30;
    }

    public override string ToString()
    {
        return base.ToString() + $" [{Format}]";
    }
}