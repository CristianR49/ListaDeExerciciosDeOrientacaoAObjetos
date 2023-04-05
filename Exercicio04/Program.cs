namespace Exercicio04
{
    internal class Program
    {
        public decimal kmInicial;
        public decimal kmFinal;
        public decimal combustivel;
        
        
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.kmFinal = 100;
            carro.kmInicial = 50;
            carro.combustivel = 20;

            Console.WriteLine("Programa para calcular o consumo de combustível por Km");
            Console.WriteLine("O gasto foi de " + carro.CalcularCombustivelConsumido()  + " Litros por kilometro");
            Console.ReadLine();
        }
    }
}