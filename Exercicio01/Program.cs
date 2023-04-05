namespace Exercicio01
{
    public class Program
    {
        public static int comprimento;
        public static int largura;
        public static int altura;
        static void Main(string[] args)
        {
            Caixa caixa1 = new Caixa();
            
            caixa1.comprimento = 5;
            caixa1.largura = 10;
            caixa1.altura = 7;
            Console.WriteLine("Programa para calcular o volume de uma caixa retangular");
                
            Console.WriteLine("O volume é:" + caixa1.CalcularVolume());
            Console.ReadLine();
        }
    }
    
}