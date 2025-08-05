namespace CursoCsharp;

public class Carro
{
    protected readonly int VelocidadeMaxima;
    int VelocidadeAtual;

    public Carro(int velocidadeMaxima)
    {
        VelocidadeMaxima = velocidadeMaxima;
    }

    protected int AlterarVelocidade(int delta)
    {
        int novaVelocidade = VelocidadeAtual + delta;

        if (novaVelocidade < 0)
        {
            VelocidadeAtual = 0;
        }
        else if (novaVelocidade > VelocidadeMaxima)
        {
            VelocidadeAtual = VelocidadeMaxima;
        }
        else
        {
            VelocidadeAtual = novaVelocidade;
        }

        return VelocidadeAtual;
    }

    public virtual int Acelerar()
    {
        return AlterarVelocidade(5);
    }

    public int Frear()
    {
        return AlterarVelocidade(-5);
    }

}

public class Uno : Carro
{
    public Uno() : base(200) // Defina a velocidade máxima desejada para o Uno
    {
    }
}

public class Ferrari : Carro
{
    public Ferrari() : base(350)
    {
    }

    public override int Acelerar()
    {
        return AlterarVelocidade(15);
    }

    public new int Frear()
    {
        return AlterarVelocidade(-15);
    }
        
    
}
public class Heranca
{
    public static void Exeutar()
    {
        Console.WriteLine("Uno...");
        Uno carro1 = new();

        Console.WriteLine(carro1.Acelerar());
        Console.WriteLine(carro1.Acelerar());
        Console.WriteLine(carro1.Acelerar());

        Console.WriteLine(carro1.Frear());
        Console.WriteLine(carro1.Frear());
        Console.WriteLine(carro1.Frear());
        Console.WriteLine(carro1.Frear());

        Console.WriteLine("Ferrari...");
        Ferrari carro2 = new();

        Console.WriteLine(carro2.Acelerar());
        Console.WriteLine(carro2.Acelerar());
        Console.WriteLine(carro2.Acelerar());

    }
}
