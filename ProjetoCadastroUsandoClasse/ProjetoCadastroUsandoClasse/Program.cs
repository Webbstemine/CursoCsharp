namespace ProjetoCadastroUsandoClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceGrafica tela = new InterfaceGrafica();
            tela.Run();
            Console.WriteLine("Pressione qualquer tecla para encerrar!");
            Console.ReadKey(true);
        }


    }
}