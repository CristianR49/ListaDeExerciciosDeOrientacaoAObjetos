namespace Exercicio07
{
    internal class Program
    {

        public int salario;
        public int numeroDeVendas;
        public int comissao;

        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.salario = 300;
            vendedor.numeroDeVendas = 5;
            vendedor.comissao = 500;

            Console.WriteLine("Programa para calcular o salário total de um vendedor");
            Console.WriteLine("Salário total: {0}" ,vendedor.CalcularSalarioTotal());
            Console.ReadLine();
        }
    }
}