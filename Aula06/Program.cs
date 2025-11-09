namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=======Verificador de números pares ou ímpares=======");
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " É par");
        }
        else
        {
            Console.WriteLine(number + " É ímpar");
        }
    }
}
