namespace Aula12;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========= MENU WHILE =========");
        Console.WriteLine("Seleciona um dos exemplos abaixo: ");
        Console.WriteLine("1. WHILE adição de iterações");
        Console.WriteLine("2. WHILE subtração de iterações");
        int UserResponse = Convert.ToInt32(Console.ReadLine());

        

        switch (UserResponse)
        {
            case 1:
                int iterable = 0;
                while (iterable <= 5)
                {
                    Console.WriteLine(iterable);
                    iterable++;
                }
                break;

            case 2:
                double budget = 100;
                while(budget >= 0)
                {
                    Console.WriteLine(budget);
                    budget--;
                }
                Console.WriteLine("Saldo insuficiente!");
                break;
        }
    }
}
