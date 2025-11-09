namespace Aula03;

public class Program
{
    public static void Main()
    {
        const int data_born = 2001;
        Console.WriteLine("O valor da constante é "+data_born);

        var age = 24;
        Console.WriteLine("O valor de age é " + age);


        dynamic username = "teste@122";
        Console.WriteLine("Testando o tipo dynamic " + username);

        username = 28;
        Console.WriteLine("Testando o tipo dynamic " + username);
    }
}