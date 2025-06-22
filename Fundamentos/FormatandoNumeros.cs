using System.ComponentModel;
using System.Globalization;

namespace CursoCsharp;


public class FormatandoNumeros
{
    public static void Executar()
    {
        double valor = 15.175;
        Console.WriteLine(valor.ToString("F1"));
        Console.WriteLine(valor.ToString("C"));
        Console.WriteLine(valor.ToString("P"));
        Console.WriteLine(valor.ToString("#.##"));

        CultureInfo culture = new("en-US");

        Console.WriteLine(valor.ToString(valor.ToString("c2", culture)));

        int numero = 256;
        Console.WriteLine(numero.ToString("D10"));

        float valorFloat = 1.00f;

        int valorInt = (int)valorFloat;

    }
}
