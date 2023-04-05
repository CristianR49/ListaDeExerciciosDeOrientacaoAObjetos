namespace Exercicio03
{
    internal class Program
    {
        public decimal raio;
        public decimal altura;
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();
            cilindro.raio = 5;
            cilindro.altura = 10;

            Console.WriteLine("Programa para calcular o volume de um cilindro");
            Console.Write("Volume:" + cilindro.CalcularVolume() );
            Console.ReadLine();
        }
    }
}