namespace CursoCsharp;

public class Moto
{
    public string? Modelo;
    public string? Fabricante;
    public int Ano;

    public Moto() { }
    public Moto(string modelo, string fabricante, int ano)
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
        Moto Moto = new()
        {
            Fabricante = "BMW",
            Modelo = "325i",
            Ano = 2017
        };

        Console.WriteLine($"{Moto.Fabricante} {Moto.Modelo} {Moto.Ano}");

        Moto Moto2 = new("ka", "Ford", 2019);

        Console.WriteLine(Moto2.Acelerar());


    }
}
