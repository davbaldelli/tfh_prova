namespace Assets.Scripts
{
    public class CardEffectGatewayImpl : CardEffectGateway
    {
        
        Deck deck;
        PlayerStats playerStats;

        public CardEffectGatewayImpl(Deck deck, PlayerStats playerStats)
        {
            this.deck = deck;
            this.playerStats = playerStats;
        }

        public void addLife(int amount)
        {
            playerStats.life += amount;
        }

        public void drawCard()
        {
            Card card = deck.getCardFromTop(); 
            playerStats.hand.Add(card);
        }

        public void addAttackMult(float amount)
        {
            playerStats.attackMult += amount;
        }
    }
}