namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("===============Operadores lógicos===============");

        bool isLogged = true;
        bool hasAdminAccess = false;

        Console.Write("Informações do usuário:\n");
        Console.WriteLine("Usuário logado no sistema: "+ isLogged);
        Console.WriteLine("Acesso ao painel de admin: "+ hasAdminAccess);

        Console.WriteLine("\nPermissões:");

        //Operador (||) - OU (or)
        if (isLogged || hasAdminAccess)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }


        //Operador (&&) - E (and)
        if (isLogged && hasAdminAccess)
        {
            Console.WriteLine("Acesso ao painel de administrador concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de administrador negado");
        }

        //Operador (!) - "Não é.. tal coisa" (not) -- Operador de negação -- CONVERTE o bool (se esta true passa a ser falso)
        // EXEMPLO: Se isLogged foi definido como true a pergunta fica "O usuário não está logado? " > Não! O usuário ESTA logado,
        //Portanto if se torna FALSO e o programa cai para o else
        if (!isLogged)
        {
            Console.WriteLine("Usuário não esta logado");
        }
        else
        {
            Console.WriteLine("Usuário esta logado");
        }
    }
}
