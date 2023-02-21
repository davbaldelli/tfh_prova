using System;
using UnityEngine;

namespace Assets.Scripts.Enemies.Effects
{
    [Serializable]
    public class VeryEvil : EnemyEffect
    {
        [SerializeField]
        int evilness;

        public void callEffect(EnemyEffectGateway gateway)
        {
            gateway.doEvilStuff(evilness);
        }
    }
}
