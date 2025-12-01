namespace Aula23;

public class BankOperations
{
    private decimal balance = 3000;

    public void CheckBalance()
    {
        Console.WriteLine($"Saldo: R${balance}");
    }

    public void Deposit()
    {
        Console.WriteLine("Digite o valor que gostaria de depositar");
        
        if(decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0 )
        {
            balance  += amount;
            Console.WriteLine($"Valor {amount} depositado com sucesso!\nSaldo após a transação: {balance}");
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
    }

    public void WithDraw()
    {
        Console.WriteLine("Digite o valor a ser retirado");

        if(decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Valor {amount} retirado com sucesso!\nSaldo após a transação: {balance}");
            }
            else
            {
                Console.WriteLine("Saldo excedido!");
            }
        }
        else
        {
            Console.WriteLine("Valor inválido!");
        }
    }
}