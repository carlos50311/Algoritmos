using System.Runtime.CompilerServices;

namespace CursoCsharp;

public class OperadoresAtribuicao
{
    public static void Executar()
    {
        int num1 = 3;
        num1 = 7;
        num1 += 10;
        num1 -= 3;
        num1 *= 5;
        num1 /= 2;

        Console.WriteLine(num1);

        int a = 4;
        int b = a;

        a++;
        b--;

        Console.WriteLine("{0} {1}", a, b);

        dynamic c = new System.Dynamic.ExpandoObject();

        c = "Carlos";

        dynamic d = c;
        d = "João";

        Console.WriteLine(d);
    }
}
