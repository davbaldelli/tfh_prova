
using Cards.Effects;

namespace Cards
{
    public class Card : ICard
    {
        int _life;
        Sign _sign;
        string _cardName;
        ICardEffect[] _passives;
        ICardEffect[] _actives;

        public Card(int life, Sign sign, string cardName, ICardEffect[] passives, ICardEffect[] acrives)
        {
            _life = life;
            _sign = sign;
            _cardName = cardName;
            _passives = passives;
            _actives = acrives;
        }

        public Card(ICard card)
        {
            _life = card.life;
            _sign = card.sign;
            _cardName = card.cardName;
            _passives = card.passiveEffects;
            _actives = card.activeEffects;
        }

        public ICardEffect[] passiveEffects => _passives;

        public ICardEffect[] activeEffects => _actives;

        public string cardName => _cardName;

        public Sign sign => _sign;

        public int life { get => _life; set => _life = value; }
    }
}

