namespace CursoCsharp;

class Dependentes
{
    public string? Nome;
    public int Idade;
}

public class ValorVsReferencia
{
    public static void Executar()
    {
        int numero = 3;
        int copiaNumero = numero;

        Console.WriteLine($"{numero}, {copiaNumero}");

        numero++;

        Console.WriteLine($"{numero}, {copiaNumero}");

        Dependentes dep = new Dependentes
        {
            Nome = "Carlos",
            Idade = 22,
        };

        Dependentes copiaDep = dep;

        Console.WriteLine($"{copiaDep.Nome} {dep.Nome}");
        Console.WriteLine($"{copiaDep.Idade} {dep.Idade}");

        copiaDep.Nome = "Reginaldo";
        dep.Idade = 21;

        Console.WriteLine($"{copiaDep.Nome} {dep.Nome}");
        Console.WriteLine($"{copiaDep.Idade} {dep.Idade}");
    }
}
