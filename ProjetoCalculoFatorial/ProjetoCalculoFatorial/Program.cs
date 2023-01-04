namespace ProjetoCalculoFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 numero = 0;

            ///Limite da variavel single 
            ///-3,402823E38 a -1,401298E-45 para valores negativos
            ///1,401298E-45 a 3,402823E38 para valores positivos
            Single resultado = 0;

            Console.WriteLine("********Bem Vindo ao Programa-Fatorial********");
            Console.WriteLine("Digite um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = numero;i > 0; i --)
            {
                if (resultado == 0)
                    resultado += numero;
                else
                    resultado *= i;
            }

            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey(true);
        }
    }
}