using UnityEngine;
using Cards.Effects;
using System.Collections.Generic;

namespace Cards
{
    [CreateAssetMenu(fileName = "Card", menuName = "Card/Card")]
    public class CardObject : ScriptableObject, ICard
    {
        [SerializeField]
        List<ActiveCardEffectObject> _activeEffects = new List<ActiveCardEffectObject>();
        [SerializeField]
        List<PassiveCardEffectObject> _passiveEffects = new List<PassiveCardEffectObject>();
        [SerializeField]
        private int _life;
        [SerializeField]
        private string _name;
        [SerializeField]
        private Sign _sign;

        public ICardEffect[] passiveEffects => _passiveEffects.ToArray();

        public ICardEffect[] activeEffects => _activeEffects.ToArray();

        public int life { get => _life; set => _life = value; }

        public string cardName => _name;

        public Sign sign => _sign;
    }
}

