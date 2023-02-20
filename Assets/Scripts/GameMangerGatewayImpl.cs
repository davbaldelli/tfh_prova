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
            if (playerStats.hand.Count < 5)
            {
                for (int i = 0; i < 5 - playerStats.hand.Count; i++)
                    deck.getCardFromTop();
            }
        }

        public void finishTurn()
        {
            //do stuff
        }

        public void startGame(Card[] statringCards)
        {

            playerStats.life = 100;
            playerStats.attackMult = 1;

            //shuffle cards then insert them

            foreach (Card card in statringCards)
            {
                deck.addCardToTop(card);
            }

            for (int i = 0; i < 5; i++)
            {
                deck.getCardFromTop();
            }
        }

    }
}