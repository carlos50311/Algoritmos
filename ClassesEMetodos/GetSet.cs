namespace CursoCsharp;

public class GetSet
{
    class Moto
    {
        private string Marca;
        private string Modelo;

        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public uint GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada)
        {
            //Primeira opção
            // if (cilindrada > 0)
            //     Cilindrada = cilindrada;

            //Segunda opção
            // Cilindrada = Math.Abs(cilindrada);

            Cilindrada = cilindrada;
        }
    }

    public static void Executar()
    {
        Moto moto1 = new("Honda", "CG Titan", 160);

        Console.WriteLine(moto1.GetMarca());
        Console.WriteLine(moto1.GetModelo());
        Console.WriteLine(moto1.GetCilindrada());

        Moto moto2 = new();
        moto2.SetMarca("Yamaha");
        moto2.SetModelo("YBR");
        moto2.SetCilindrada(125);

        Console.WriteLine(moto2.GetModelo() + " " + moto2.GetMarca() + " " + moto2.GetCilindrada());
    }
}
