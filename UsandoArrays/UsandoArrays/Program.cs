namespace UsandoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array com 1 dimensão
            int[] meuArray = new int[3];

            meuArray[0] = 1;
            meuArray[1] = 10;
            meuArray[2] = 100;

            foreach(int i in meuArray)
            {
                Console.WriteLine(i);
            }

            //Outra maneira de declarar o Array
            int[] meuArray2 = { 1, 2, 3, 4, 5 };

            foreach(int i in meuArray2)
            {
                Console.WriteLine(i);
            }

            //Array de 2 dimensões
            int[,] meuArray2Dimensoes = new int[4, 2];

            meuArray2Dimensoes[0, 0] = 10;
            meuArray2Dimensoes[1, 0] = 100;
            meuArray2Dimensoes[2, 0] = 1000;
            meuArray2Dimensoes[3, 0] = 10000;

            meuArray2Dimensoes[0, 1] = 20;
            meuArray2Dimensoes[1, 1] = 200;
            meuArray2Dimensoes[2, 1] = 2000;
            meuArray2Dimensoes[3, 1] = 20000;

            foreach (int i in meuArray2Dimensoes)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}