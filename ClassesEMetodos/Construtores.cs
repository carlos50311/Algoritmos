namespace CursoCsharp;

public class Carro
{
    public string? Modelo;
    public string? Fabricante;
    public int Ano;

    public Carro() { }
    public Carro(string modelo, string fabricante, int ano)
    {
        Modelo = modelo;
        Fabricante = fabricante;
        Ano = ano;
    }

    public string Acelerar()
    {
        return string.Format($"O {Fabricante} {Modelo} esta acelerando!");
    }



}

public class Construtores
{
    public static void Executar()
    {
        Carro carro = new()
        {
            Fabricante = "BMW",
            Modelo = "325i",
            Ano = 2017
        };

        Console.WriteLine($"{carro.Fabricante} {carro.Modelo} {carro.Ano}");

        Carro carro2 = new("ka", "Ford", 2019);

        Console.WriteLine(carro2.Acelerar());


    }
}
