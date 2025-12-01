namespace Aula22;

public class Person
{
    public string Name;
    public int Age;

    public string IfLegalPerson(int age, string name)
    {
        string response = string.Empty;

        if (age >= 18)
        {
            response = $"Confirmado, {name} é maior de idade";
            return response;
        }
        else
        {
            response = $"{name} não é maior de idade";
            return response;
        }
    }
}