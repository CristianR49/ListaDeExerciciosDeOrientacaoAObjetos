namespace Exercicio06
{
    internal class Program
    {
        public decimal celcius;
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.celcius = 30;

            Console.Clear();
            Console.WriteLine("Programa para converter graus Celsius para Fahrenheit ");
            Console.WriteLine("{0}°F",temperatura.ConverterTemperatura());
            Console.ReadLine();
        }
    }
}