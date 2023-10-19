using System;
using tabuleiro;

namespace _001_Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine("Posição: " + P);
            Console.ReadLine();

        }
    }
}
