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
                    try
                    {
                        Console.Clear();

                        Screen.ImprimirPartida(partida);


                        Console.Write("\nOrigem: ");
                        Posicao origem = Screen.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Screen.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                        
                        Console.Write("\nDestino: ");
                        Posicao destino = Screen.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }
                }
                Console.Clear();
                Screen.ImprimirPartida(partida);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
