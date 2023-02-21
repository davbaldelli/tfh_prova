using UnityEngine;

namespace Assets.Scripts.Cards.Effects
{
    [CreateAssetMenu(fileName = "Greedy", menuName = "Card/ActiveEffect/Greedy")]
    public class Greedy : ActiveCardEffectObject
    {
        public override void callEffect(CardEffectGateway gateway)
        {
            gateway.drawCard();
        }
    }
}