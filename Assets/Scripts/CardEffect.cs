namespace Assets.Scripts
{
    public interface CardEffect
    {
        //we should define a type that describes when the effect should be raised
        //or maybe we should create different subclasses
        public void callEffect(CardEffectGateway gateway);
    }

    public interface ActiveCardEffect : CardEffect{}

    public interface PassiveCardEffect : CardEffect {}

}