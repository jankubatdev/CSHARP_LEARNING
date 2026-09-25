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
