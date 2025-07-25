namespace CursoCsharp;

interface Ponto
{
    void MoverNaDiagonal(int delta);
}

struct Coordenada : Ponto
{
    public int X;
    public int Y;

    public void MoverNaDiagonal(int delta)
    {
        X += delta;
        Y += delta;
    }

    public Coordenada(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class ExemploStruct
{
    public static void Executar()
    {
        Coordenada cordenadaInicial;
        cordenadaInicial.X = 2;
        cordenadaInicial.Y = 2;

        Console.WriteLine($"X = {cordenadaInicial.X}");
        Console.WriteLine($"Y = {cordenadaInicial.Y}");

        var cordenadaFinal = new Coordenada(9, 1);
    }
}
