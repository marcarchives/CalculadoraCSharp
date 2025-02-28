using System.Net;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, resultado;
            string operacao;




            Console.WriteLine("Calculadora");


            do
            {
                Console.WriteLine("Escolha uma operação (+, -, /,* ): ");
                operacao = Console.ReadLine();

                if (operacao != "+" && operacao != "-" && operacao != "/" && operacao != "*")
                {
                    Console.WriteLine("Escolha operacao válida");
                }


            }
            while (operacao != "+" && operacao != "-" && operacao != "/" && operacao != "*");

            Console.WriteLine("Digite o primeiro número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());


            switch (operacao)
            {
                case "/":
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {resultado} ");
                        break;
                    }

                case "*":
                    {
                        resultado = (num1 * num2);
                        Console.WriteLine($"Resultado: {resultado} ");
                        break;
                    }

                case "+":
                    {
                        resultado = num1 + num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    }

                case "-":
                    {
                        resultado = num1 - num2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    }



            }
        }
    }
}




        

    
            

