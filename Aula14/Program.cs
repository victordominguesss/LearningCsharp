namespace Aula14;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===========TABELA DE MULTIPLICAÇÃO===========");
        for (int i = 1; i <= 10; i++)
        {
            for(int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j, 5}");
            }
            Console.WriteLine();
        }

    }   
}