namespace Assets.Scripts
{
    public class CardEffectGatewayImpl : CardEffectGateway
    {

        MatchData matchData;

        public CardEffectGatewayImpl(MatchData matchData)
        {
            this.matchData = matchData;
        }

        public void addLife(int amount)
        {
            matchData.playerHealth += amount;
        }

        public void drawCard()
        {
            matchData.playerHand.Add(matchData.discardDeck.Pop());
        }

        public void addAttackMult(float amount)
        {
            matchData.playerAttackMultiplier += amount;
        }
    }
}