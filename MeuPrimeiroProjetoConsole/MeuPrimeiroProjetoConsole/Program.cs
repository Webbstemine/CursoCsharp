namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            Int16 idade = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o número do seu documento: ");
            string documento = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua rua: ");
            string rua = Console.ReadLine();

            Console.WriteLine("Digite o número da sua casa: ");
            Int32 numeroCasa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe seu gênero (Pressione F para feminino ou M para masculino): ");
            //Readkey(true) => Serve para esconder o Char do console
            string genero = Console.ReadKey(true).KeyChar == 'F' ? "Feminino" : "Masculino";
            

            Console.WriteLine($"Olá {nome}!");
            Console.WriteLine($"Você tem {idade} anos de idade");
            Console.WriteLine($"O número do documento informado é: {documento}");
            Console.WriteLine($"O Nome da sua rua é {rua}");
            Console.WriteLine($"O número da sua casa é: {numeroCasa}");
            Console.WriteLine($"O seu gênero é: {genero}");

            Console.WriteLine($"Pressione para qualquer tecla para continuar...........");
            Console.ReadKey();



        }
    }
}