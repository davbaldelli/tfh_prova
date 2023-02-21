using System;
using UnityEngine;

namespace Cards.Effects { 
    [CreateAssetMenu(fileName = "Revenant", menuName = "Card/PassiveEffect/Revenant")]
    public class Revenant : PassiveCardEffectObject
    {
        public override void callEffect(CardEffectGateway gateway)
        {
            throw new NotImplementedException();
        }
    }
}