using System.Collections;

namespace CursoCsharp;

public class ColecoesStack
{
    public static void Executar()
    {
        var pilha = new Stack();

        pilha.Push(2);
        pilha.Push(3);
        pilha.Push("Palavra");
        pilha.Push(true);

        foreach (var item in pilha)
        {
            Console.WriteLine($"{item}");
        }

        pilha.Pop();

        foreach (var item in pilha)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine($"\n Peek: {pilha.Peek()}");
        Console.WriteLine(pilha.Count);
    }
}
