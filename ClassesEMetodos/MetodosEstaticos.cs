namespace CursoCsharp;

public class CalculadoraEstatica
{
    //Metodo da classe ou estatico
    public static int Somar(int a, int b)
    {
        return a + b;
    }

    //Metodo de instancia
    public static int Subtrair(int a, int b)
    {
        return a - b;
    }
}

public class MetodosEstaticos
{
    public static void Executar()
    {
        var somar = CalculadoraEstatica.Somar;

        Console.WriteLine(somar(2, 3));


    }
}
