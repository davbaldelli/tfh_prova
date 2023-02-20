using Assets.Scripts.Cards.Effects;
using System.Collections;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

namespace Assets.Scripts.Cards
{
    public class Gunslinger : Card
    {
        private PassiveCardEffect[] passives = new PassiveCardEffect[] {new Braveheart()};
        private ActiveCardEffect[] actives = new ActiveCardEffect[] { new Rage()};
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