namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor1 = 10, valor2 = 10;

            int div = valor1 / valor2;
            int mult = valor1 * valor2;

            Console.WriteLine("Escolha uma operação");

            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");


            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 3)
            {
                Console.WriteLine($"Você escolhei a opção: {operacao} - Divisão: 10 / 10  = {div}");
            }

            else if (operacao == 4)
            {
                Console.WriteLine($"Você escolheu a opção: {operacao} - Multiplicação: 10 * 10 = {mult}");

            }
            else
            {
                Console.WriteLine("Você escolheu uma opção inválida");
            }
        }
    }
}