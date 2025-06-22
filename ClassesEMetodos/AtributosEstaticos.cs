using System.Net.NetworkInformation;

namespace CursoCsharp;

public class Prouduto
{
    public string Nome;
    public double Preco;
    public static double Desconto ;

    public Prouduto(string nome, double preco, double desconto)
    {
        Nome = nome;
        Preco = preco;
        Desconto = desconto;
    }

    public Prouduto()
    {

    }

    public double CalcularDesconto()
    {
        return Preco - Preco * Desconto;
    }
}

public class AtributosEstaticos
{
    public static void Executar()
    {
        var produto1 = new Prouduto()
        {
            Nome = "Caneta",
            Preco = 3.2,
            //Desconto = 0.1
        };

        var produto2 = new Prouduto("Borracha", 5.3, 0.1);

        Console.WriteLine("Preço com desconto: {0}", produto1);
        Console.WriteLine("Preço com desconto: {0}", produto2);

        Prouduto.Desconto = 0.5;
    }
}
