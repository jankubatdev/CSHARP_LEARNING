public abstract class Zadanie
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
}