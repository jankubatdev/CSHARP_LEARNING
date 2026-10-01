namespace Apteka;

public abstract class Ksztalt
{
    public abstract double Pole();

    public void Opisz()
    {
        Console.WriteLine($"Pole tego ksztaltu to {Pole()}");
    }
}

public class Kolo : Ksztalt
{
    public double Promien { get; set; }
    public Kolo(double promien) => Promien = promien;
    public override double Pole() => Math.PI * Promien * Promien;
}

public class Prostokat : Ksztalt
{
    public double Szerokosc { get; set; }
    public double Wysokosc { get; set; }
    public Prostokat(double szerokosc, double wysokosc)
    {
        Szerokosc = szerokosc;
        Wysokosc = wysokosc;
    }
    public override double Pole()
    {
        return Szerokosc * Wysokosc;
    }
}