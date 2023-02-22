using Cards.Effects;

namespace Cards
{
    public interface ICard
    {
        public ICardEffect[] passiveEffects { get; }
        public ICardEffect[] activeEffects { get; }
        public int life { get; set; }
        public string cardName { get; }
        public Sign sign { get; }
    }
}