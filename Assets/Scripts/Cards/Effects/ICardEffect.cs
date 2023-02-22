namespace Cards.Effects {
    public interface ICardEffect
    {
        public void callEffect(ICardEffectGateway gateway);
    }
    public interface IActiveCardEffect : ICardEffect { }
    public interface IPassiveCardEffect : ICardEffect { }
}

