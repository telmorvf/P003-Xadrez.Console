using System;
using tabuleiro;

namespace _001_Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            
            Screen.ImprimeTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
