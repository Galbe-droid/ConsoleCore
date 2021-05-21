using System;
using JogoFoda.Interface;

namespace JogoFoda.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string Nome;

        public Jogador1(string nome)
         {
            Nome = nome;
         }
            
        public string Ataque()
        {
            return $"{Nome} esta Atacando \n";
        }
            
        public string Defesa()
        {
            return $"{Nome} esta Defendendo \n";
        }

        public string Correr()
        {
            return $"{Nome} esta Correndo \n";
        }
    }
}