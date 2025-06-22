namespace CursoCsharp;

public class EstruturaWhile
{
    public static void Executar()
    {
        int palpite = 0;
        Random ramdom = new();

        int numeroSecreto = ramdom.Next(1, 16);
        bool numeroEncontrado = false;
        int tentativasRestantes = 5;
        int tentativas = 0;

        while (tentativasRestantes > 0 && !numeroEncontrado)
        {
            Console.Write("Digite o seu palpite: ");
            string? entrada = Console.ReadLine();
            int.TryParse(entrada, out palpite);

            tentativas++;
            tentativasRestantes--;

            if (numeroSecreto == palpite)
            {
                numeroEncontrado = true;
                var corAnterior = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O numero foi enontrado {tentativas} em tentativas");
                Console.ForegroundColor = corAnterior;
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("Menor ... Tente novamente!");
                Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
            }
            else
            {
                Console.WriteLine("Maior ... Tente novamente!");
                Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
            }

        }
    }
}
