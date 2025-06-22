namespace CursoCsharp;

public class OperadoresRelacionais
{
    public static void Executar()
    {
        double nota = 6.0;
        double notaDeCorte = 7.0;

        Console.WriteLine("A nota e invalidade? {0}", nota > 10.0);
        Console.WriteLine("A nota e invalida? {0}", nota < 0.0);
        Console.WriteLine("Perfeito? {0}", nota == 10.0);
        Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
        Console.WriteLine("Passou por media? {0}", nota >= notaDeCorte);
        Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
    }
}
