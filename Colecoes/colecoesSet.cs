namespace CursoCsharp;


public class ColecoesSet
{
    public static void Executar()
    {
        var livro = new Produto("Game of Thrones", 49.0);
        var carrinho = new HashSet<Produto>();
        carrinho.Add(livro);

        var combo = new HashSet<Produto>
        {
            new Produto("Playstation 5", 5000.0),
            new Produto("Senhor dos aneis", 89.0),
            new Produto("Garrafa termica", 57.0)
        };

        carrinho.UnionWith(combo);
        Console.WriteLine(carrinho.Count);
        carrinho.Add(livro);
        Console.WriteLine(carrinho.Count);

        // carrinho.RemoveAt(3);

        foreach (var item in carrinho)
        {
            //  Console.Write(carrinho.IndexOf(item));
            Console.WriteLine($"{item.Nome} {item.Preco}");
        }
    }
}
