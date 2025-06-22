namespace CursoCsharp;

public class Params
{
    static public void Recepcionar(params string[] pessoas)
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Seja bem vindo! {pessoa}");
        }
    }
    static public void Executar()
    {
        Recepcionar("Carlos", "Roberto", "Vanesa", "Joyce");
    }
}
