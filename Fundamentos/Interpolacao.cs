namespace CursoCsharp;

public class Interpolacao
{
    public static void Executar()
    {
        string nome = "Notebook gamer";
        string marca = "Dell";
        double preco = 5800.90;

        Console.WriteLine("O " + nome + " da marca " + marca + " tem o preço de " + preco + " .");
        Console.WriteLine("O {0} da marcar {1} tem o preço de {2}", nome, marca, preco);
    }
}
