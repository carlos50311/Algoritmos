namespace CursoCsharp;

// Uma das diferenças entre struct e classes e esta no momento da atribuição para outros objetos, uma class ela tera uma atribuição do tipo referencia 
// já na struct o tipo de atribuição sera do tipo valor.

public struct Sponto
{
    public int X;
    public int Y;
}

public class Cponto
{
    public int X;
    public int Y;
}

public class StructVsClass
{
    public static void Executar()
    {
        var ponto1 = new Sponto { X = 1, Y = 3 };
        var copiaPonto = ponto1; // Atribuição por valor!!!
        ponto1.X = 3;

        Console.WriteLine($"Ponto 1 X: {ponto1.X}");
        Console.WriteLine($"Copia Ponto X: {copiaPonto.X}");


        Cponto ponto2 = new Cponto { X = 2, Y = 4 };
        var copiaPonto2 = ponto2; // Atribuição por referencia!!!
        ponto2.X = 4;

        Console.WriteLine($"Ponto 2  X: {ponto2.X}");
        Console.WriteLine($"Copia Ponto X: {copiaPonto2.X}");


    }
}
