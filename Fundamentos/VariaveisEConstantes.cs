using System.ComponentModel.DataAnnotations;

namespace CursoCsharp;

public class VariaveisEConstantes
{
    public static void Executar()
    {
        double raio = 4.5;
        const double pi = 3.14;

        raio = 5.5;
        // pi = 3.145; O valor de pi não pode ser alterado por ele ser uma constante 

        double area = pi * (raio * raio);

        System.Console.WriteLine(area);
        System.Console.WriteLine("Esse é o valor da área: " + area);

        // tipos internos

        bool estaChovendo = true;
        Console.WriteLine("Esta chovendo? " + estaChovendo);

        byte idade = 45;
        Console.WriteLine("O valor da idade é: " + idade);

        sbyte saldoDeGols = sbyte.MinValue;
        Console.WriteLine("O saldo de gols é: " + saldoDeGols);

        short salario = short.MaxValue;
        Console.WriteLine("O valor do salrio é: " + salario);

        int menorValorInt = int.MinValue;
        Console.WriteLine("O menor svalor do inteiro é:" + menorValorInt); // E o mais usado dos inteiros

        uint populacaoBrasileira = 20_600_000;
        Console.WriteLine("População Brasileira: " + populacaoBrasileira);

        long menorValorLong = long.MinValue;
        Console.WriteLine("O menor valor de long: " + menorValorLong);

        ulong populacaoMundial = 7_600_000_000;
        Console.WriteLine("A população Mundial" + populacaoMundial);

        float valorDeMercadoDaApple = 1_000_000_000_000.00f;
        Console.WriteLine("Valor da apple: " + valorDeMercadoDaApple);

        decimal distanciasEstrelas = decimal.MaxValue;
        Console.WriteLine("A distancia das estrelas " + distanciasEstrelas);

        char letra = 'a';
        Console.WriteLine("Letra " + letra);
        

    }
}
