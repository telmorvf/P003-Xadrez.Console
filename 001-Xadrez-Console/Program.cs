using System;
using tabuleiro;
using xadrez;

namespace _001_Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Screen.ImprimirTabuleiro(partida.Tab);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Screen.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Screen.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.Write("\nDestino: ");
                    Posicao destino = Screen.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
