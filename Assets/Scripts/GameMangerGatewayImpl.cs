namespace Assets.Scripts
{
    public class GameMangerGatewayImpl : GameManagerGateway
    {
        Deck deck;
        PlayerStats playerStats;

        public GameMangerGatewayImpl(Deck deck, PlayerStats playerStats)
        {
            this.deck = deck;
            this.playerStats = playerStats;
        }

        public void drawCards()
        {
            if (playerStats.hand.Length < 5)
            {
                for (int i = 0; i < 5 - playerStats.hand.Length; i++)
                    deck.drawCard();
            }
        }

        public void finishTurn()
        {
            //do stuff
        }

        public void startGame()
        {
            playerStats.life = 100;
            playerStats.attackMult = 1;
            for (int i = 0; i < 5; i++)
            {
                deck.drawCard();
            }
        }

    }
}