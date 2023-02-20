using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Cards.Effects
{
    public class Braveheart : PassiveCardEffect
    {
        public void callEffect(CardEffectGateway gateway)
        {
            gateway.addLife(20);
        }
    }
}