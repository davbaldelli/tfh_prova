namespace Cards.Effects {
    public interface CardEffect
    {
        public void callEffect(CardEffectGateway gateway);
    }
    public interface ActiveCardEffect : CardEffect { }
    public interface PassiveCardEffect : CardEffect { }
}

