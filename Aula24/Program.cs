namespace Aula24;

public class Program
{
    public static void Main()
    {
        Car HondaCivic = new(1, "Honda", "Touring", 2020, "Silver");

        Car FiatUno = new(2, "Fiat", "UnoFire", 2021, "Black");

        var carList = new List<Car> { HondaCivic, FiatUno };

        foreach(Car car in carList)
        {
            Console.WriteLine("========= Cars =========");
            Console.WriteLine($"Id: {car.Id}");
            Console.WriteLine($"Marca: {car.Brand}");
            Console.WriteLine($"Modelo: {car.Model}");
            Console.WriteLine($"Ano: {car.Year}");
            Console.WriteLine($"Cor: {car.Color}");
        }
    }
}