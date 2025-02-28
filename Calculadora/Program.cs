namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, resultado;
            string operacao;




            Console.WriteLine("Calculadora");

            Console.WriteLine("/");
            Console.WriteLine("*");

            Console.Write("Escolha uma opção: ");
            operacao = (Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operacao)
            {
                case "/":
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado {resultado}");
                        break;
                    }

                case "*":
                    {
                        resultado = (num1 * num2);
                        Console.WriteLine($"Resultado{resultado}");
                        break;
                    }

             }


     
            // usuario ira escolher a operacao matematica que deseja realizar
            Console.WriteLine("Calculadora");

            Console.WriteLine("Escolha uma operação (+, -): ");
            operacao = Console.ReadLine();

            // solicitar os numeros que usuario deseja 
            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo núemro: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // realização da operação
            switch (operacao) 
            {
                case "+":
                resultado = num1 + num2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "-":
                resultado = num1 - num2;
                Console.WriteLine("Resultado: " + resultado);
                break;
                   
            }

            // pausar operação para devolver resultado
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }

}