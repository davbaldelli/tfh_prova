namespace Assets.Scripts.Cards.Effects
{
    public class Greedy : ActiveCardEffect
    {
        public void callEffect(CardEffectGateway gateway)
        {
            gateway.drawCard();
        }
    }
}