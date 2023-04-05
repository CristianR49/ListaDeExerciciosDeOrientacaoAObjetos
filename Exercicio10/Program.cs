namespace Exercicio10
{
    internal class Program
    {
        public double primeiraNota;
        public double segundaNota;
        static void Main(string[] args)
        {
            Notas notas = new Notas();
            notas.primeiraNota = 5;
            notas.segundaNota = 10;

            Console.WriteLine("Programa para calcular a média ponderada das duas provas de um aluno");
            Console.WriteLine("A média ponderada é:{0}", notas.CalcularMediaPonderada());
            Console.ReadLine();
        }
    }
}