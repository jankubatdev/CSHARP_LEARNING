namespace Apteka;

public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

public struct Dawka
{
    public int Mg { get; set; }
    public Dawka(int mg) => Mg = mg;
}

class DawkaKlasa
{
    public int Mg { get; set; }
    public DawkaKlasa(int mg) => Mg = mg;
}