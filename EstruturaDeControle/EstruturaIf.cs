namespace CursoCsharp;

public class EstruturaIf
{
    public static void Executar()
    {
        bool boComportamento = false;
        string entrada = "";

        Console.Write("Digite a nota do aluno:");
        Double.TryParse(entrada, out double nota);

        Console.WriteLine("O aluno tem bom comportamento? (S/N)");
        entrada = Console.ReadLine();

        if (entrada == "S" || entrada == "s")
            boComportamento = true;

        if (nota >= 9 && boComportamento == true)
            Console.WriteLine("Quadro de honra!");
    }
}