using UnityEngine;
using Cards.Effects;
using System.Collections.Generic;

namespace Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Card/Card")]
    public class CardObject : ScriptableObject, Card
    {
        [SerializeField]
        List<ActiveCardEffectObject> _activeEffects = new List<ActiveCardEffectObject>();
        [SerializeField]
        List<PassiveCardEffectObject> _passiveEffects = new List<PassiveCardEffectObject>();
        [SerializeField]
        private int _life;
        [SerializeField]
        private string _name;

        public CardEffect[] passiveEffects => _passiveEffects.ToArray();

        public CardEffect[] activeEffects => _activeEffects.ToArray();

        public int life => _life;

        public string cardName => _name;
    }
}

