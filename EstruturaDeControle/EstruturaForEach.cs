namespace CursoCsharp;

public class EstruturaForEach
{
    public static void Executar()
    {
        string palavra = "Opa!";

        foreach (var letra in palavra)
        {
            Console.WriteLine(letra);
        }

        string[] alunos = ["Anna", "Bia", "carlos", "Douglas"];

        foreach (string aluno in alunos)
        {
            Console.Clear();
            Console.WriteLine(aluno);
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, 0);
            Console.Clear();
        }
    }

}
