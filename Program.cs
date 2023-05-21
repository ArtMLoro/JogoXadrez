using System;
using System.Xml;
using tabuleiro;
using Xadrez;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}   