using UnityEngine;

namespace Cards.Effects
{

    public abstract class ActiveCardEffectObject : ScriptableObject, IActiveCardEffect
    {
        public abstract void callEffect(ICardEffectGateway gateway);
    }

    public abstract class PassiveCardEffectObject : ScriptableObject, IPassiveCardEffect
    {
        public abstract void callEffect(ICardEffectGateway gateway);
    }

}