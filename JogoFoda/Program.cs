using System;
using JogoFoda.Lib;

namespace JogoFoda
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("Gabriel"), new Jogador2());
            jogo.IniciarJogo();
        }
    }
}
