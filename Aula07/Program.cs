namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========Operadores de atribuição=========");

        int x;

        x = 10;
        Console.WriteLine("\nValor inicial da variável x: "+ x);

        x = 20;
        Console.WriteLine("\nAtribuição simples (=) // x = 20 (Se lê: x RECEBE 20)");
        Console.WriteLine("\n Novo valor de x: " + x);

        x ++;
        Console.WriteLine("\nAtribuição composta incremento (++) // x = 20 + 1 (Se lê: x RECEBE x mais um)");
        Console.WriteLine("\n Novo valor de x: " + x);
         
        x += 10;
        Console.WriteLine("\nAtribuição composta incremento (+=) // x = 21 + 10 (Se lê: x RECEBE x mais 10)");
        Console.WriteLine("\n Novo valor de x: " + x);
        
        x -= 10;
        Console.WriteLine("\nAtribuição composta decremento (-=) // x = 21 - 10 (Se lê: x RECEBE x menos 10)");
        Console.WriteLine("\n Novo valor de x: " + x);
        
        x *= 10;
        Console.WriteLine("\nAtribuição composta incremento (*=) // x = 21 * 10 (Se lê: x RECEBE x vezes 10)");
        Console.WriteLine("\n Novo valor de x: " + x);

        x /= 10;
        Console.WriteLine("\nAtribuição composta incremento (/=) // x = 210 / 10 (Se lê: x RECEBE x divido por 10)");
        Console.WriteLine("\n Novo valor de x: " + x);

    }
}
