using JokenPoNerd.API.Enums;
using JokenPoNerd.API.Models;

namespace JokenPoNerd.API.Entity
{
    public class Pedra : JokenPoAbstract
    {
        public Pedra(ETipo jogador2)
        {
            Jogador2 = jogador2;
        }

        public override string VerificarGanhador()
        {
            if (Jogador2 == ETipo.Lagarto || Jogador2 == ETipo.Tesoura)
                return "Jogador 1 ganhou";

            else if (Jogador2 == ETipo.Pedra)
                return "Empate";

            return "Jogador 2 ganhou";
        }
    }
}
