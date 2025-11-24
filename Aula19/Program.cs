namespace Aula19;

using System.IO;


public class Program
{
    public static void Main()
    {
        string path = @"C:\Users\victor.domingues\LearningCsharp\Aula19\";

        string fileName = "Lista_de_compras.txt";

        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();

        
        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));
        }

        bool onLoop = true;
        while (onLoop)
        {
            Console.WriteLine("\n============= Lista de compras =============");
            Console.WriteLine("\nDigite uma das opcões para continuar, exemplo: 1");
            Console.WriteLine("(1). Adicionar um item");
            Console.WriteLine("(2). Ler lista");
            Console.WriteLine("(3). Editar um item");
            Console.WriteLine("(4). Remover um item");
            Console.WriteLine("(5). Limpar lista");
            Console.WriteLine("(6). Salvar lista em doc e finalizar o programa");

            int optionChosen;
            try
            {
                optionChosen = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Opção inválida! Digite apenas os números disponíveis no menu");
                continue;
            }


            switch (optionChosen)
            {
                case 1:
                    Console.WriteLine("Digite o item que deseja inserir: ");

                    string itemInsert = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);

                        Console.WriteLine($"Item {itemInsert} adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Valor inválido!");
                    }
                   break;


                case 2:
                    if (shoppingList.Count > 0)
                    {
                        Console.WriteLine("Lista completa: ");

                        foreach (string items in shoppingList)
                        {
                            Console.WriteLine(items);
                        }
                    }
                    else
                    {
                        Console.WriteLine("A lista esta vazia!");
                    }
                break;


                case 3:
                    if (shoppingList.Count > 0)
                    {
                        Console.WriteLine("Digite o nome do item que deseja editar: ");
                        string itemIndexEdit = Console.ReadLine();

                        if (!string.IsNullOrEmpty(itemIndexEdit))
                        {
                            int index = shoppingList.IndexOf(itemIndexEdit);

                            if (index == -1)
                            {
                                Console.WriteLine("Item não encontrado!");
                            }
                            else
                            {
                                Console.WriteLine("Digite o valor e tecle [Enter] para confirmar a edição");
                                string itemEdit = Console.ReadLine();
                               
                                if (!string.IsNullOrEmpty(itemEdit))
                                {
                                    shoppingList[index] = itemEdit;
                                }
                                else
                                {
                                    Console.WriteLine("Valor inválido!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Valor inválido!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A lista esta vazia!");
                    }
                break;


                case 4:
                    if (shoppingList.Count > 0)
                    {
                        Console.WriteLine("Digite o item que deseja remover: ");
                        string itemRemove = Console.ReadLine();

                        if (!string.IsNullOrEmpty(itemRemove))
                        {
                            int indexItemRemove = shoppingList.IndexOf(itemRemove);

                            if (indexItemRemove == -1)
                            {
                                Console.WriteLine("Item não encontrado!");
                            }
                            else
                            {
                                shoppingList.Remove(itemRemove);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A lista esta vazia!");
                    }
                break;


                case 5:
                    if (shoppingList.Count > 0)
                    {
                        shoppingList.Clear();
                        Console.WriteLine("Lista limpa!");
                    }
                    else
                    {
                        Console.WriteLine("A lista já está vazia!");
                    }
                break;


                case 6:
                    if (shoppingList.Count > 0)
                    {
                        File.WriteAllLines(filePath, shoppingList, System.Text.Encoding.UTF8);
                        Console.WriteLine("Salvando a lista e finalizando o programa!");
                    }
                    else
                    {
                        Console.WriteLine("Finalizando o programa!");
                    }
                    onLoop = false;
                break;
            }
        }
    }
}