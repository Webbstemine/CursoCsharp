namespace SegundoProjeto_Locadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=====> Bem Vindo a Locadora de Filmes <=====");
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1 - Ver lista de filmes\n2 - Sair");
                string Opcao = Console.ReadKey(true).KeyChar.ToString();

                switch (Opcao)
                {
                    case "1":
                        MostraFilmes();
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.ReadKey(true);
                Console.Clear();
                
            }
        
        }

        private static void MostraFilmes()
        {
            Console.WriteLine("******* Escolha uma das opções *******");
            Console.WriteLine("1 - Top Gun");
            Console.WriteLine("2 - Rocky");
            Console.WriteLine("3 - O Poderoso Chefão");
            Console.WriteLine("4 - O Irlandês");
            string Opcao = Console.ReadKey(true).KeyChar.ToString();
            switch (Opcao)
            {
                case "1":
                    Console.WriteLine("Voce escolheu Top Gun");
                    break;
                case "2":
                    Console.WriteLine("Voce escolheu Rocky");
                    break;
                case "3":
                    Console.WriteLine("Voce escolheu O Poderoso Chefão");
                    break;
                case "4":
                    Console.WriteLine("Voce escolheu O Irlandês");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;  
            }
        }

    }
}