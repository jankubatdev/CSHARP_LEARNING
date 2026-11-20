using System.Security.Cryptography.X509Certificates;

namespace Model;

// konstruktor pierwotny
public class Student(string imie, int? wiek,
    string? email) {
    public string Imie { get; } = imie;
    public int? Wiek { get; } = wiek;
    public string? Email { get; } = email;

    public override string ToString() {
        string wiekTekst = Wiek?.ToString() ?? "nie podano";
        string emailTekst = Email?.ToString() ?? "brak";
        return $"{Imie}, wiek: {wiekTekst}," +
            $"email: {emailTekst}";
    }
}