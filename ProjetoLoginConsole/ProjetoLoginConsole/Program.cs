namespace ProjetoLoginConsole
{
    internal class Program
    {
        struct UsuarioSt
        {
            public string login;
            public string senha;
        }

        static void Main(string[] args)
        {
            UsuarioSt usuario;

            while (true)
            {
                Console.WriteLine("********Bem vindo ao sistema********");
                Console.WriteLine("Login:");
                usuario.login = Console.ReadLine();
                Console.WriteLine("Senha:");
                usuario.senha = Console.ReadLine();

                if (string.IsNullOrEmpty(usuario.login) || string.IsNullOrEmpty(usuario.senha))
                {
                    Console.WriteLine("Necessário informar os dados do login!");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }else if(usuario.login == "Admin" && usuario.senha == "1234")
                {
                    Console.WriteLine("Logado com sucesso!");
                    break;
                }
                else
                {
                    Console.WriteLine("Acesso negado!");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
            }










        }
    }
}