namespace Exercicio02
{
    internal class Program
    {
        public decimal fahrenheit;
        public decimal celcius;
        static void Main(string[] args)
        {
            Temperatura temperatura = new Temperatura();
            temperatura.fahrenheit = 50m;
            
            Console.WriteLine("Programa para converter Fahrenheit em graus Celsius");
            Console.WriteLine( temperatura.ConverterTemperatura() + "°C");
            Console.ReadLine();

        }
    }
}