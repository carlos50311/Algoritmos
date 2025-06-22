namespace CursoCsharp;

public class EstruturaFor
{
    public static void Executar()
    {
        double somatorio = 0;
        string entrada = "";

        Console.Write("Informe o tamanho da turma: ");
        entrada = Console.ReadLine();
        int.TryParse(entrada, out int tamanhoTurma);

        for (int i = 1; i <= tamanhoTurma; i++)
        {
            Console.WriteLine("Informe a nota do aluno {0}: ", i);
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double notaAtual);
            somatorio += notaAtual;
        }
        double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
        Console.WriteLine($"A media da turma é de: {media}");
    }
}
