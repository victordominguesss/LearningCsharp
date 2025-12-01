namespace Aula22;

public class Program
{
   public static void Main()
    {
        Person person = new Person();

        Console.WriteLine("Digite seu nome");
        string name = Console.ReadLine(); 

        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string response = person.IfLegalPerson(age, name);
        Console.WriteLine(response);
    }
}