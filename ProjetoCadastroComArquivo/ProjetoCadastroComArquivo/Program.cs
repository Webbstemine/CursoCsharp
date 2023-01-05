using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoCadastroComArquivo
{

    internal class Program
    {
        struct ClienteStrct
        {
            public string nome;
            public string genero;
            public DateTime dataNasc;
            public string rua;
            public int numeroRua;
        }

        const string DelimitadorInicio = "##Inicio##";
        const string DelimitadorFim = "##Fim##";
        const string TagNome = "Nome:";
        const string TagGenero = "Genero:";
        const string TagData = "Data de Nascimento:";
        const string TagRua = "Rua:";
        const string TagNumeroRua = "Número da casa:";

        const string Arquivo = "Clientes.txt";

        private static List<ClienteStrct> Clientes;

        static void Main(string[] args)
        {
            Clientes = new List<ClienteStrct>();
            while (true)
            {
                try
                {
                    VerificarArquivo();
                    if (!Menu())
                        return;
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }

        private static bool Menu()
        {
            string menu = "";
            menu += "***********Bem vindo ao sistema de cadastro***********\n";
            menu += "Selecione uma opção para continuar:\n";
            menu += "1 - Cadastrar clientes\n";
            menu += "2 - Listar clientes\n";
            menu += "3 - Sair do sistema\n";
            Console.WriteLine(menu);
            int opcao = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
            switch (opcao)
            {
                case 1:
                    Cadastrar();
                    return true;
                case 2:
                    Listar();
                    return true;
                case 3:
                    return false;
                default:
                    return false;
            }
        }

        private static void Cadastrar()
        {
            ClienteStrct cli = IniciarCliente();
            Console.WriteLine("Digite o nome:");
            cli.nome = Console.ReadLine();
            Console.WriteLine("Pressione F para feminino e M para masculino:");
            cli.genero = Console.ReadKey(true).KeyChar.ToString().ToUpper() == "F" ? "Feminino" : "Masculino";
            string data = "";
            do
            {
                Console.WriteLine("Digite a data de nascimento: (Padrão dd/mm/yyyy)");
                data = Console.ReadLine();
            } while (!ValidaData(data));
            cli.dataNasc = DateTime.Parse(data);
            Console.WriteLine("Digite a rua:");
            cli.rua = Console.ReadLine();
            Console.WriteLine("Digite o numero:");
            cli.numeroRua = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cadastro efetuado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar....");
            Console.ReadKey();
            Clientes.Add(cli);
            Salvar();
        }

        private static void Salvar()
        {
            string arqStr = "";
            foreach (var c in Clientes)
            {
                arqStr += DelimitadorInicio + "\n";
                arqStr += TagNome + c.nome + "\n";
                arqStr += TagGenero + c.genero + "\n";
                arqStr += TagData + c.dataNasc.ToString("dd/MM/yyyy") + "\n";
                arqStr += TagRua + c.rua + "\n";
                arqStr += TagNumeroRua + c.numeroRua + "\n";
                arqStr += DelimitadorFim + "\n";
            }

            File.WriteAllText(Arquivo, arqStr);
        }

        private static bool ValidaData(string data)
        {
            DateTime datatemp;
            return DateTime.TryParse(data, out datatemp);
        }

        private static ClienteStrct IniciarCliente()
        {
            ClienteStrct cli;
            cli.nome = "";
            cli.genero = "";
            cli.dataNasc = new DateTime();
            cli.rua = "";
            cli.numeroRua = 0;
            return cli;
        }


        private static void Listar()
        {
            string arq = File.ReadAllText(Arquivo, Encoding.UTF8);
            Console.WriteLine(arq);
            Console.WriteLine("\r\nPressione qualquer tecla para continuar.....");
            Console.ReadKey(true);
        }

        private static void VerificarArquivo()
        {
            FileStream st;
            for (int i = 0; i <= 1; i++)
            {
                if (!File.Exists(Arquivo))
                {
                    if (i == 0)
                    {
                        st = File.Create(Arquivo);
                        st.Close();
                    }
                    else
                        throw new Exception("Houve um erro ao tentar criar o arquivo!");
                }
            }

        }





    }


}