using UnityEngine;

namespace Cards.Effects
{
    [CreateAssetMenu(fileName = "Greedy", menuName = "Card/ActiveEffect/Greedy")]
    public class Greedy : ActiveCardEffectObject
    {
        public override void callEffect(ICardEffectGateway gateway)
        {
            gateway.drawCard();
        }
    }
}