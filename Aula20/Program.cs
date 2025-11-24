namespace Aula20;

public class Program
{
    public static void Main()
    {
        Car fiatUno = new Car();

        fiatUno.Id = 37896;
        fiatUno.Color = "Silver";
        fiatUno.Year = 2021;
        fiatUno.Model = "Uno Fire";
        fiatUno.Brand = "Fiat";

        Console.WriteLine("====== Infos Car ======");
        Console.WriteLine($"Id: {fiatUno.Id}");
        Console.WriteLine($"Cor: {fiatUno.Color}");
        Console.WriteLine($"Ano: {fiatUno.Year}");
        Console.WriteLine($"Modelo: {fiatUno.Model}");
        Console.WriteLine($"Marca: {fiatUno.Brand}");

        Car hondaCivic = new Car();

        hondaCivic.Id = 57986;
        hondaCivic.Color = "Black";
        hondaCivic.Year = 2020;
        hondaCivic.Model = "Touring";
        hondaCivic.Brand = "Honda";

        Console.WriteLine("====== Infos Car ======");
        Console.WriteLine($"Id: {hondaCivic.Id}");
        Console.WriteLine($"Cor: {hondaCivic.Color}");
        Console.WriteLine($"Ano: {hondaCivic.Year}");
        Console.WriteLine($"Modelo: {hondaCivic.Model}");
        Console.WriteLine($"Marca: {hondaCivic.Brand}");


        var carList = new List<Car>();

        carList.Add(fiatUno);
        carList.Add(hondaCivic);

        Console.Write("====== List Cars ======\n");

        foreach(Car car in carList)
        {
            Console.WriteLine($"Id: {car.Id}");
            Console.WriteLine($"Cor: {car.Color}");
            Console.WriteLine($"Ano: {car.Year}");
            Console.WriteLine($"Modelo: {car.Model}");
            Console.WriteLine($"Marca: {car.Brand}");
            Console.WriteLine("====== List Cars ======");
        }
    }
}
