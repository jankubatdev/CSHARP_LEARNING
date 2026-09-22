var kolejka = new List<Zadanie>
{
    new ZadanieRenderu("batch nocny", 1, 240),
    new ZadanieUploadu("wysyłka wyników", 3, 500),
    new ZadanieRenderu("test", 2, 10),
    new ZadanieKonwersji("test2", 23, "jpg"),
};

int suma = 0;
foreach (var z in kolejka)
{
    if (z is ZadanieRenderu render)
        Console.WriteLine($"{render.Nazwa}: {render.Klatki} klatek");
}
Console.WriteLine($"Łącznie: {suma}s");

int ile = kolejka.Count(z => z is ZadanieRenderu);

Console.WriteLine($"Zadan renderu jest {ile}");
Console.WriteLine($"Łącznie: {kolejka.Sum(z => z.SzacowanyCzasSekund())}");

kolejka.Sort();

static void WypiszStatus(IWykonalne element)
{
    Console.WriteLine($"zakonczone: {element.Zakonczone}, czas {element.SzacowanyCzasSekund()}");
}