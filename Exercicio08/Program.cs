namespace Exercicio08
{
    internal class Program
    {
        public double raio;
        public double altura;
        static void Main(string[] args)
        {

            LataDeOleo lata = new LataDeOleo();
            lata.altura = 20;
            lata.raio = 15;
            Console.WriteLine("Programa para calcular o volume de uma lata de óleo");
            Console.Write("Volume:{0}", lata.CalcularVolume());
            Console.ReadLine();
        }
    }
}