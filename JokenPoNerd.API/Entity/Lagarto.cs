using JokenPoNerd.API.Enums;
using JokenPoNerd.API.Models;

namespace JokenPoNerd.API.Entity
{
    public class Lagarto : JokenPoAbstract
    {

        public Lagarto(ETipo jogador2)
        {
            Jogador2 = jogador2;
        }
        public override string VerificarGanhador()
        {
            if (Jogador2 == ETipo.Spock || Jogador2 == ETipo.Papel)
                return "Jogador 1 ganhou";

            else if (Jogador2 == ETipo.Lagarto)
                return "Empate";

            return "Jogador 2 ganhou";
        }

    }
}
