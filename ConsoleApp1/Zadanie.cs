public abstract class Zadanie : IWykonalne, IComparable<Zadanie>
{
    public string Nazwa {  get; set; }
    public int Priorytet { get; set; }
    public bool Zakonczone { get; private set; }
    public DateTime DataUtworzenia { get; }

    public Zadanie(string nazwa, int priorytet)
    {
        Nazwa = nazwa;
        Priorytet = priorytet;
        Zakonczone = false;
        DataUtworzenia = DateTime.Now;
    }

    public void Zakoncz() => Zakonczone = true;

    public override string ToString() =>
        $"[{(Zakonczone ? "x" : " ")}] {Nazwa} (p{Priorytet})  {DataUtworzenia}";

    public abstract int SzacowanyCzasSekund();

    public int CompareTo(Zadanie? inne)
    {
        if (inne is null) return 1;
        return Priorytet.CompareTo(inne.Priorytet);
    }
}