namespace Exercicio05
{
    internal class Program
    {
        public decimal raio;
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 5;

            Console.WriteLine("Programa para calcular o volume de uma esfera");
            Console.Write("Volume: " + esfera.CalcularVolume());
            Console.ReadLine();
        }
    }
}