namespace CursoCsharp;

public class CaculadoraComun
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Subtrair(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a, int b)
    {
        return a / b;
    }
}

class CalculadoraCadeia
{
    int memoria;

    public CalculadoraCadeia Somar(int a)
    {
        memoria += a;
        return this;
    }

    public CalculadoraCadeia Multiplicar(int a)
    {
        memoria *= a;
        return this;
    }

    public CalculadoraCadeia Limpar()
    {
        memoria = 0;
        return this;
    }

    public CalculadoraCadeia Imprimir()
    {
        Console.WriteLine(memoria);
        return this;
    }
}


public class MetodosComRetorno
{
    public static void Executar()
    {
        CaculadoraComun calculadora = new();

        calculadora.Somar(2, 3);

        CalculadoraCadeia calculadoraCadeia = new();

        calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();
    }
}
