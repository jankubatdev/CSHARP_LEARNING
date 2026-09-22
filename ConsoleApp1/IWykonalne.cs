public interface IWykonalne
{
    int SzacowanyCzasSekund();
    void Zakoncz();
    bool Zakonczone { get; }
}