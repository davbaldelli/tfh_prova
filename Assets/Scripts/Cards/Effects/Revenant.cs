using System;
using UnityEngine;

namespace Cards.Effects { 
    [CreateAssetMenu(fileName = "Revenant", menuName = "Card/PassiveEffect/Revenant")]
    public class Revenant : PassiveCardEffectObject
    {
        public override void callEffect(ICardEffectGateway gateway)
        {
            throw new NotImplementedException();
        }
    }
}