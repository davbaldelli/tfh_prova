using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Cards.Effects
{
    public class Braveheart : CardEffect
    {
        public override void callEffect(CardEffectGameGateway gateway)
        {
            gateway.addLife(20);
        }
    }
}