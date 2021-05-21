using System;
using JogoFoda.Interface;

namespace JogoFoda
{
    public class JogoFODA
    {
        public readonly IJogador _Jogador1;

        public readonly IJogador _Jogador2;


        public JogoFODA(IJogador jogador1, IJogador jogador2)
        {
            _Jogador1 = jogador1;
            _Jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_Jogador1.Ataque());
            Console.WriteLine(_Jogador1.Defesa());
            Console.WriteLine(_Jogador1.Correr());
            
            Console.WriteLine(_Jogador2.Ataque());
            Console.WriteLine(_Jogador2.Defesa());
            Console.WriteLine(_Jogador2.Correr());
        }        
    }
} 