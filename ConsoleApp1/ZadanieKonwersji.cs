public class ZadanieKonwersji : Zadanie
{
    public string Format { get; }

    public ZadanieKonwersji(string nazwa, int priorytet, string format)
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