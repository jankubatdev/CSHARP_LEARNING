using Apteka;

Console.WriteLine("Hello, World!");

var z = 5;
Console.WriteLine(z);
    
var lek = new Lek("Paracetamol", 59.99m, 10);
Console.WriteLine(lek);
Console.WriteLine(lek.CzyDostepny());

lek.Sprzedaj(4);
Console.WriteLine(lek);

var lek2 = new Lek("Ibuprom", 24.50m, 0);
Console.WriteLine(lek2.CzyDostepny());

Lek.WypiszLiczbeLekow();

try
{
    var zlyLek = new Lek("Test", -10m, 5);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Zlapano wyjatek: {ex.Message}");
}
