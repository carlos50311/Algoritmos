using System.Security;

namespace CursoCsharp;

public class OperadoresAritimeticos
{
    public static void Executar()
    {
        var preco = 1000.0;
        var imposto = 355;
        var desconto = 0.1;

        double total = preco + imposto;
        double totalComDesconto = total - total * desconto;
        Console.WriteLine("Resultado com desconto {0}", totalComDesconto);

        // Calculo do Imc 
        double altura = 1.82;
        double peso = 91.2;
        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine("O valor do IMC: {0}", imc);

        // Numero par/impar
        int par = 24;
        int impar = 55;
        Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
        Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
    }
}
