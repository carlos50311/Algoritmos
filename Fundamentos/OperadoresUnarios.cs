namespace CursoCsharp;

public class OperadoresUnarios
{
    public static void Executar()
    {
        var numerosNegativos = -5;
        var numero1 = 2;
        var numero2 = 3;
        bool boleano = true;


        Console.WriteLine(-numerosNegativos);
        Console.WriteLine(!boleano);

        Console.WriteLine(numero1++ == --numero2);

        numero1++;
        --numero2;

    }
}
