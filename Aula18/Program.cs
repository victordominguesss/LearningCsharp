namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        string path = @"C:\Users\victor.domingues\LearningCsharp\Aula18\";

        string fileName = "myDocument.Doc";

        string filePath = path + fileName;

        string content = "Hello world!";

        //Criar arquivo doc com conteúdo
        File.WriteAllText(filePath, content);

        Console.WriteLine("Arquivo criado com sucesso!");

        string additiolContent = "| em Csharp";

        //Adicionar conteúdo a um arquivo já existente
        File.AppendAllText(filePath, additiolContent);

        Console.WriteLine("Conteúdo adicionado com sucesso!");


        string fileContent = File.ReadAllText(filePath);

        Console.WriteLine("Conteúdo do arquivo: " + fileContent);
    }
}