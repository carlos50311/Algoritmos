using System.Collections;
using System.Runtime.CompilerServices;

namespace CursoCsharp;

public class ColecoesArrayList
{
    public static void Executar()
    {
        var arrayList = new ArrayList();

        arrayList.Add(1);
        arrayList.Add("Carlos");
        arrayList.Add(9);
        arrayList.Add("caio");

        arrayList.Add(3.14);

        foreach (var itens in arrayList)
        {
            Console.WriteLine($"{itens} => {itens.GetType()}");
        }
    }
}
