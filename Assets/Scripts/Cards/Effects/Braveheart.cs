using UnityEngine;

namespace Cards.Effects
{
    [CreateAssetMenu(fileName = "Braveheart", menuName = "Card/PassiveEffect/Braveheart")]
    public class Braveheart : PassiveCardEffectObject
    {
        public override void callEffect(CardEffectGateway gateway)
        {
            gateway.addLife(20);
        }
    }
}