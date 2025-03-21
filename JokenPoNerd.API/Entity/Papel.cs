using JokenPoNerd.API.Enums;
using JokenPoNerd.API.Models;

namespace JokenPoNerd.API.Entity
{
    public class Papel : JokenPoAbstract
    {
        public Papel(ETipo jogador2)
        {
            Jogador2 = jogador2;
        }

        public override string VerificarGanhador()
        {
            if (Jogador2 == ETipo.Pedra || Jogador2 == ETipo.Spock)
                return "Jogador 1 ganhou";

            else if (Jogador2 == ETipo.Papel)
                return "Empate";

            return "Jogador 2 ganhou";
        }
    }
}
