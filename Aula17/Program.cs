using System.Diagnostics.Tracing;

namespace Aula17;

public class Program
{
    public static void Main()
    {
        //Declarar lista com inicialização de valores
        List<string> words = new List<string>()
        {
            "Caneta",
            "Borracha",
            "Porta"
        };

        //Acessar valor específico por Índice
        Console.WriteLine(words[1]);


        //Acessar os valores
        foreach(string word in words)
        {
            Console.WriteLine(word);

        }

        //Adicionar elementos
        words.Add("Mesa");

        //Remover elementos
        words.Remove("Borracha");

        //Contar elementos

        Console.WriteLine("Quantida de palavras: " + words.Count);

        //Modificar elementos
        words[1] = "Sapato";

        //Limpar lista
        words.Clear();

        // Declarar listar sem inicializar
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(130);
        numbers.Add(323);

        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}