namespace Aula11;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========================== MENU PRINCIPAL ==========================");
        Console.WriteLine("Selecione um dos 2 programas abaixo:");
        Console.WriteLine("1.(Programa) Dias da semana");
        Console.WriteLine("2.(Programa) Boletim");

        int ProgramSelect = Convert.ToInt32(Console.ReadLine());
        bool ProgramContinue = true;


        while (ProgramContinue)
        {
            switch (ProgramSelect)
            {
                case 1:
                    Console.WriteLine("============= DIAS DA SEMANA =============");
                    Console.WriteLine("Digite um número de 1 a 7: ");
                    int DayOfWeek = Convert.ToInt32(Console.ReadLine());

                    switch (DayOfWeek)
                    {
                        case 1:
                            Console.WriteLine("Dia da semana correspondente: Domingo");
                            break;
                        case 2:
                            Console.WriteLine("Dia da semana correspondente: Seguinda-feira");
                            break;
                        case 3:
                            Console.WriteLine("Dia da semana correspondente: Terça-feira");
                            break;
                        case 4:
                            Console.WriteLine("Dia da semana correspondente: Quarta-feira");
                            break;
                        case 5:
                            Console.WriteLine("Dia da semana correspondente: Quinta-feira");
                            break;
                        case 6:
                            Console.WriteLine("Dia da semana correspondente: Sexta-feira");
                            break;
                        case 7:
                            Console.WriteLine("Dia da semana correspondente: Sábado");
                            break;
                        case 8:
                            Console.WriteLine("Dia inválido!");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("============= Boletim: Prova =============");
                    Console.WriteLine("Digite sua nota: ");
                    int score = Convert.ToInt32(Console.ReadLine());

                    switch (score)
                    {
                        case 10:
                        case 9:
                            Console.WriteLine("Ótimo!");
                            break;
                        case 8:
                        case 7:
                            Console.WriteLine("Bom");
                            break;
                        case 6:
                        case 5:
                            Console.WriteLine("Regular");
                            break;
                        case 4:
                        case 3:
                            Console.WriteLine("Ruim");
                            break;
                        case 2:
                        case 1:
                        case 0:
                            Console.WriteLine("Muito ruim");
                            break;
                    }
                    break;
            }

            Console.WriteLine("========================== MENU ==========================");
            Console.WriteLine("1. Executar o mesmo programa novamente");
            Console.WriteLine("2. Mudar de programa");
            Console.WriteLine("3. Finalizar execução");

            int UserResponse = Convert.ToInt32(Console.ReadLine());

            if (UserResponse == 1) 
                ProgramContinue = true;
   
            else if (UserResponse == 2)
            {
                if (ProgramSelect == 1)
                {
                    ProgramSelect = 2;
                }
                else
                {
                    ProgramSelect = 1;
                }
            }

            else if (UserResponse == 3)
            {
                ProgramContinue = false;
                Console.WriteLine("Finalizando o programa!");
            }

        }

    }
}