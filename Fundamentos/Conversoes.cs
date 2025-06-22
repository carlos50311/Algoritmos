﻿namespace CursoCsharp;

public class Conversoes
{
    public static void Executar()
    {
        int inteiro = 10;
        double quebrado = inteiro;
        Console.WriteLine(quebrado);

        double nota = 9.7;
        int notaTruncada = (int)nota;
        Console.WriteLine(" Nota truncada {0} ", notaTruncada);

        Console.WriteLine("Digite a sua idade: ");
        string idadeString = Console.ReadLine();
        int idadeInteiro = int.Parse(idadeString);

        idadeInteiro = Convert.ToInt32(idadeString);
        Console.WriteLine("Resultado: {0} ", idadeInteiro);

        Console.Write("Digite o primerio numero: ");
        string palavras1 = Console.ReadLine();
        int numero1;
        int.TryParse(palavras1, out numero1);
        Console.WriteLine("Resultado 1 {0} ", numero1);

        Console.Write("Digite o segundo numero: ");
        int.TryParse(Console.ReadLine(), out int numero2);
        Console.WriteLine("Resultado 2 {0}", numero2);
    }
}
