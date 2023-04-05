namespace Exercicio09
{
    internal class Program
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        static void Main(string[] args)
        {
            Notas notas = new Notas();
            notas.nota1 = 7;
            notas.nota2 = 7;
            notas.nota3 = 7;
            notas.nota4 = 7;
            Console.WriteLine("Programa para calcular a média harmonica das notas de um aluno");

            Console.WriteLine("Média harmonica:{0}", notas.CalcularMediaHarmonica() );
            Console.ReadLine();
        }
    }
}