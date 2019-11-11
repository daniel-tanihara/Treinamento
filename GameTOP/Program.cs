using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogoFODA = new JogoFODA(new Jogador("Ronaldo"),
                                        new Jogador("Adriano"));
            jogoFODA.IniciarJogo();
        }
    }
}
