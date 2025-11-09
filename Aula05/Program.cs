namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==============CALCULADORA: 4 OPERAÇÕES BÁSICAS==============");
        Console.WriteLine("Digite um número: ");

        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());


        int sum = number1 + number2;
        int subtraction = number1 - number2;
        int multplication = number1 * number2;
        int division = number2 / number1;
        int module = number2 % number1;


        Console.WriteLine("O valor da soma é: "+ sum);
        Console.WriteLine("O valor da subtração é: "+  subtraction);
        Console.WriteLine("O valor da multiplicação é: " + multplication);
        Console.WriteLine("O valor da divisão é: "+  division);
        Console.WriteLine("O resto da divisão é: "+  module);

        Console.WriteLine("==============CALCULADORA: 4 OPERAÇÕES BÁSICAS==============");
    }
}