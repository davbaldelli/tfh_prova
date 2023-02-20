using Assets.Scripts.Cards.Effects;

namespace Assets.Scripts.Cards
{
    public class Renegade : Card
    {
        private PassiveCardEffect[] passives = new PassiveCardEffect[] {};
        private ActiveCardEffect[] actives = new ActiveCardEffect[] { new Greedy() };
        public CardEffect[] getActiveEffects()
        {
            return actives;
        }

        public CardEffect[] getPassiveEffects()
        {
            return passives;
        }
    }
}