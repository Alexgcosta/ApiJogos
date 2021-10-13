using System;

namespace ApiJogos.Repositories
{
    public class Jogo
    {
        public string Produtora { get; internal set; }
        public string Nome { get; internal set; }
        public double Preco { get; internal set; }
        public Guid Id { get; internal set; }
    }
}