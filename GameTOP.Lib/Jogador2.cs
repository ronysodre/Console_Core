using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return"Maradona Estas Chuta \n";
        }

        public string Corre()
        {
            return"Maradona Estas coriendo \n";
        }

        public string Passe()
        {
            return"Maradona estas passando \n";
        }
    }
}