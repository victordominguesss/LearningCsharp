using System.Runtime.InteropServices.Swift;

namespace Aula08;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==========================Operadores Relacionais==========================\n");
        
        Console.WriteLine("Digite um número (x): ");
        int x = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("Digite outro número (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n");

        // Operador de igualdade (==) e operador de diferença (!=)
        if (x == y)
        {
            Console.WriteLine(x + " é (==) a " + y);
        }
        else if (x != y)
        {
            Console.WriteLine(x + " é (!=) de " + y);
        }
          
        // Operador de maior que (>)
        if (x > y)
        {
            Console.WriteLine(x + " é (>) que " + y);
        }
        else
        {
            Console.WriteLine(x + " não é (>) que " + y);
        }


        // Operador de menor que (<)
        if (x < y)
        {
            Console.WriteLine(x + " é (<) que " + y);
        }
        else
        {
            Console.WriteLine(x + " não é (<) que " + y);
        }

        // operador maior ou igual (>=) e menor ou igual (<=)
        if (x >= y)
        {
            Console.WriteLine(x + " é (>=) a " + y);
        }
        else if (x <= y)
        {
            Console.WriteLine(x + " é (<=) a " + y);
        }
        
        Console.WriteLine("==========================Operadores Relacionais==========================");
    }
}