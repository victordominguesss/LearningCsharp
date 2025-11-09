using System.Reflection;

namespace Aula10;

public class Program
{
    public static void Main()
    {
        bool ProgramContinue = true;

        while (ProgramContinue)
        {
            Console.WriteLine("=========Calculadora Simples========= \n");

            Console.WriteLine("Digite o primeiro número: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha da uma das 4 operaçõs básicas\n");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão\n");

            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;


            if (operation == 1)
            {
                result = number1 + number2;
            }

            else if (operation == 2)
            {
                result = number1 - number2;
            }
            else if (operation == 3)
            {
                result = number1 * number2;
            }
            else if (operation == 4)
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Não é possível dividir por 0");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }

            Console.WriteLine("O resultado da operação é: " + result+"\n");
            Console.WriteLine("Deseja continuar com o programa? (S) SIM (N) NÃO");
            string response = Console.ReadLine();
            if (response?.ToUpper() == "N")
            {
                ProgramContinue = false;
            }
        }

        Console.WriteLine("Obrigado por utilizar o programa!");
    }
}