using System.Runtime.CompilerServices;

namespace CursoCsharp;

public class DesafioAtributo
{
    int a = 10;
    public static void Executar()
    {
        DesafioAtributo desafio = new();
        Console.WriteLine(desafio.a);
    }
}
