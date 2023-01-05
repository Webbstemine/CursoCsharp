namespace ProjetoCadastro
{
    internal class Program
    {
        static List<Cliente> clientes;
        static void Main(string[] args)
        {
            string opcao;
            clientes = new List<Cliente>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*****Bem vindo ao sistema de cadastro*****");
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("C - Cadastrar");
                Console.WriteLine("L - Para Listar os clientes");
                Console.WriteLine("S - Sair do sistema");
                opcao = Console.ReadKey(true).KeyChar.ToString();
                switch (opcao.ToUpper())
                {
                    case "C":
                        Cadastrar();
                        continue;
                    case "L":
                        Listar();
                        continue;
                    case "S":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey(true);
                        continue;
                }
            }
        }

        static void Listar()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado!");
                Console.ReadKey(true);
                return;
            }
            Console.WriteLine($"Lista de clientes:");
            Console.WriteLine($"====================");
            foreach (var cli in clientes)
            {
                Console.WriteLine($"Nome: {cli.nome}");
                Console.WriteLine($"Genero: {cli.genero}");
                Console.WriteLine($"Data de Nascimento: {cli.dataNascimento.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Endereco: {cli.nomeRua}");
                Console.WriteLine($"Número: {cli.numeroCasa}");
                Console.WriteLine("***");
            }
            Console.WriteLine($"====================");
            Console.ReadKey(true);
        }

        static void Cadastrar()
        {
            Cliente cli = new Cliente();
            Console.WriteLine("Digite o nome do cliente:");
            cli.nome = Console.ReadLine();
            Console.WriteLine("Pressione F para Feminino e M para masculino:");
            cli.genero = Console.ReadKey(true).KeyChar.ToString().ToUpper() == "F" ? "Feminino" : "Masculino";
            Console.WriteLine("Digite a data de nascimento:");
            cli.dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a rua:");
            cli.nomeRua = Console.ReadLine();
            Console.WriteLine("Digite o numero da rua:");
            cli.numeroCasa = Convert.ToInt32(Console.ReadLine());
            clientes.Add(cli);
        }



    }
}