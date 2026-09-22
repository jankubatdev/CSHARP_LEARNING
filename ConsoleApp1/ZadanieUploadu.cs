public class ZadanieUploadu : Zadanie
{
    public int MegaBajty { get; }

    public ZadanieUploadu(string nazwa, int priorytet, int megaBajty)
        : base(nazwa, priorytet) => MegaBajty = megaBajty;

    public sealed override int SzacowanyCzasSekund() => MegaBajty / 5;

    public override string ToString() =>
        base.ToString() + $" [{MegaBajty} MB]";
}