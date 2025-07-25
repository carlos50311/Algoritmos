namespace CursoCsharp;

public class ParametrosPorReferencia
{
    static void AlterarRef(ref int numero)
    {
        numero = numero + 1000;
    }

    void AlterarOut()
    {

    }

    public static void Executar()
    {
        int a = 3;
        AlterarRef(ref a);
        Console.WriteLine(a);
    }
}
