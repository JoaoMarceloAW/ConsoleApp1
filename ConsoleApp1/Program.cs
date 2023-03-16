using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int espaco = (numero - 1) / 2;
            int qtdlinhas = (numero - 1) / 2;
            int qtdx = 1;
            for (int linha = 0; linha < qtdlinhas; linha++)
            { 
                for (int i = 0; i < espaco; i++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < qtdx; x++)
                {
                    Console.Write("X");
                }
                espaco = espaco - 1;
                qtdx = qtdx + 2;
                Console.WriteLine();
            }
            for (int linha = 0; linha <= qtdlinhas; linha++)
            {
                for (int i = 0; i < espaco; i++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < qtdx; x++)
                {
                    Console.Write("X");
                }
                espaco = espaco + 1;
                qtdx = qtdx - 2;
                Console.WriteLine();
            }



        }
    }
}