namespace Aula16;

public class Program
{
    public static void Main()
    {
        //Declarar Array: Com valores (Inicizalizado)
        string[] peripherals = { "Mouse", "Teclado", "Fone" };

        //Acessar um valor do array
        Console.WriteLine(peripherals[1]);

        //Verificar a quantidade de índices de um array
        Console.WriteLine("Quantidade de Índices do array: " + peripherals.Length);

        //Alterar os valores
        peripherals[4] = "MousePad";
        Console.WriteLine(peripherals[2]);

        //Declarar Array: Sem valores (Sem inicializar)
        int[] numberInts = new int[10];

        numberInts[8] = 222;

        Console.WriteLine(numberInts[8]);

        foreach (int number in numberInts)
        {
            Console.WriteLine(number);
        }
    }
}