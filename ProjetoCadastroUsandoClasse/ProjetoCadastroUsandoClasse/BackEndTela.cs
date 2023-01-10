namespace ProjetoCadastroUsandoClasse
{
    internal class BackEndTela : IBackEndTela
    {
        BaseDeDados bd;

        public BackEndTela()
        {
            bd = new BaseDeDados();
        }

        public Cliente Cadastrar()
        {
            Cliente temp = new Cliente();
            Console.WriteLine("Digite o nome:");
            temp.nome = Console.ReadLine();
            Console.WriteLine("Digite o documento:");
            temp.documento = Console.ReadLine();
            Console.WriteLine("Digite o nome da rua:");
            temp.nomeRua = Console.ReadLine();
            Console.WriteLine("Digite o número da casa:");
            temp.numeroCasa = Convert.ToUInt32(Console.ReadLine());
            return bd.insertClientes(temp);
        }

        public List<Cliente> Excluir()
        {
            string documento = "";
            Console.WriteLine("Digite o documento do cliente para exluir:");
            documento = Console.ReadLine();
            return bd.deleteClientes(documento);
        }

        public List<Cliente> Pesquisar()
        {
            string documento = "";
            Console.WriteLine("Digite o documento do cliente:");
            documento = Console.ReadLine();
            return bd.getClientes(documento);
        }
    }
}
