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
            deck.drawCard(); 
        }

        public void moultiplyAttack(int amount)
        {
            playerStats.attackMult += amount;
        }
    }
}