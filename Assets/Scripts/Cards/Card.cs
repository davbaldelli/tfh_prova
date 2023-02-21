using Cards.Effects;

namespace Cards
{
    public interface Card
    {
        public CardEffect[] passiveEffects { get; }
        public CardEffect[] activeEffects { get; }
        public int life { get; }
        public string cardName { get; }
    }
}