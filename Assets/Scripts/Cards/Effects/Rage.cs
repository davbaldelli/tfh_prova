using UnityEngine;

namespace Cards.Effects
{
    [CreateAssetMenu(fileName = "Rage", menuName = "Card/ActiveEffect/Rage")]
    public class Rage : ActiveCardEffectObject
    {
        public override void callEffect(ICardEffectGateway gateway)
        {
            gateway.addAttackMult(0.2f);
        }
    }
}