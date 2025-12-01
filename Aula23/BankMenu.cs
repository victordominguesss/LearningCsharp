namespace Aula23;

public class BankMenu
{
    public static void BankDisplayMenu()
    {
        BankOperations bankOperations = new();

        bool on = true;

        while (on)
        {
            Console.WriteLine("========== Operações bancárias ==========");
            Console.WriteLine("1. Verificar saldo");
            Console.WriteLine("2. Realizar um depósito");
            Console.WriteLine("3. Saque");
            Console.WriteLine("4. Fechar o programa");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    bankOperations.CheckBalance();
                break;

                case 2:
                    bankOperations.Deposit();
                break;

                case 3:
                    bankOperations.WithDraw();
                break;

                case 4:
                    on = false;
                break;
            }
        }

        Console.WriteLine("Encerrando o programa..");
    }
}