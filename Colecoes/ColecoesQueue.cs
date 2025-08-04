namespace CursoCsharp;

public class ColecoesQueue
{
    public static void Executar()
    {
        var fila = new Queue<string>();

        fila.Enqueue("Fulano");
        fila.Enqueue("Beltrano");
        fila.Enqueue("Sicrano");

        Console.WriteLine(fila.Peek());
        Console.WriteLine(fila.Count);

        fila.Dequeue();
        Console.WriteLine(fila.Count);

        Console.WriteLine("---------------------------");

        var salada = new Queue<object>();
        salada.Enqueue(3);
        salada.Enqueue("Item");
        salada.Enqueue(true);

        Console.WriteLine(salada.Contains("item"));
        Console.WriteLine(salada.Contains("Item"));

        Console.WriteLine(salada.Dequeue());
        Console.WriteLine(salada.Dequeue());
        Console.WriteLine(salada.Dequeue());

    }
}
