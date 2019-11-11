using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador : iJogador
    {
        public Jogador(string nome)
        {
            this.Nome = nome;

        }
        public string Nome { get; set; }

        public string Chuta()
        {
            return $"{Nome} está chutando.";
        }

        public string Corre()
        {
            return $"{Nome} está correndo.";
        }

        public string Passa()
        {
            return $"{Nome} está passando.";
        }
    }
}