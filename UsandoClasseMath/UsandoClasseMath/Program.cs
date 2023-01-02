namespace UsandoClasseMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Potenciação
            double potencia = Math.Pow(4, 5);
            Console.WriteLine(potencia);

            //Radiciação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1/raiz);
            Console.WriteLine(radiciacao);

            //Máximo
            double maximo = Math.Max(18, 12);
            Console.WriteLine(maximo);

            //Mínimo
            double minimo = Math.Min(323, 231);
            Console.WriteLine(minimo);

            //Módulo
            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);

            //Operações trigonométricas
            double angulo = 30 * (2 * Math.PI) / 360;
            Console.WriteLine(angulo);

            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);


            Console.ReadKey(true);
        }
    }
}