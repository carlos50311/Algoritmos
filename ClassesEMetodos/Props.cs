namespace CursoCsharp;

class CarroOpcional
{
    double _desconto = 0.1;

    string? _nome;

    public string Nome
    {
        get { return "Opcional " + _nome; }
        set { _nome = value; }
    }

    public double Preco { get; set; }

    public double PrecoComDesconto
    {
        get => Preco - Preco * _desconto;
    }

    public CarroOpcional() { }

    public CarroOpcional(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

}

public class Props
{
    public static void Executar()
    {
        CarroOpcional car1 = new("Ar condicionado", 3499.9);
        Console.WriteLine(car1.PrecoComDesconto);

        CarroOpcional car2 = new();

        car2.Nome = "Direção eletrica";
        car2.Preco = 2499.8;

        Console.WriteLine(car1.Nome);
        Console.WriteLine(car1.Preco);

        Console.WriteLine(car2.Nome);
        Console.WriteLine(car2.Preco);
    }
}
