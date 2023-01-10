namespace ProjetoCadastroUsandoClasse
{
    internal class InterfaceGrafica
    {
        public void Run()
        {
            BackEndTela b = new BackEndTela();
            while (true)
            {
                Console.Clear();
                string opcao = "";
                Console.WriteLine("******** Sistema de Cadastro ********");
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("C - Cadastrar");
                Console.WriteLine("P - Pesquisar");
                Console.WriteLine("E - Excluir");
                Console.WriteLine("S - Sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                switch (opcao)
                {
                    case "C":
                        //pass
                        Console.Clear();
                        MostraCliente(b.Cadastrar());
                        continue;
                    case "P":
                        //pass
                        Console.Clear();
                        IntermedMostrarClientes(b.Pesquisar());
                        Console.ReadKey(true);
                        continue;
                    case "E":
                        //pass
                        Console.Clear();
                        IntermedMostrarClientes(b.Excluir());
                        Console.ReadKey(true);
                        continue;
                    case "S":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Pressione qualquer tecla para continuar!");
                        Console.ReadKey(true);
                        continue;
                }
            }

        }

        internal void IntermedMostrarClientes(List<Cliente> clientes)
        {
            if (clientes == null || clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente encontrado!");
                Console.WriteLine("Pressione qualquer tecla para continuar!");
                Console.ReadKey(true);
                return;
            }

            MostraCliente(clientes);
        }

        internal void MostraCliente(List<Cliente> clientes)
        {
            foreach(var cli in clientes)
            {
                MostraCliente(cli);
            }
        }

        internal void MostraCliente(Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("****************************************");
            Console.WriteLine($"Nome: {cliente.nome}");
            Console.WriteLine($"Documento: {cliente.documento}");
            Console.WriteLine($"Nome da rua: {cliente.nomeRua}");
            Console.WriteLine($"Número da casa: {cliente.numeroCasa}");
            Console.WriteLine("****************************************");
        }




    }
}
