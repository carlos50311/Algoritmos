namespace CursoCsharp;

public class ExemploArray
{
    public static void Executar()
    {
        string[] alunos = new string[5];
        alunos[0] = "Aline";
        alunos[1] = "Carlos";
        alunos[2] = "Jairo";
        alunos[3] = "Anderson";
        alunos[4] = "Kaio";

        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        double somatorio = 0;
        double[] notas = { 9.7, 4.8, 5.4, 8.8, 9.0 };

        foreach (var nota in notas)
        {
            somatorio += nota;
        }

        double media = somatorio / notas.Length;

        Console.WriteLine(media);

        char[] letras = { 'A', 'r', 'r', 'a', 'y' };
        string palavra = new(letras);
        Console.WriteLine(palavra);
    }
}
