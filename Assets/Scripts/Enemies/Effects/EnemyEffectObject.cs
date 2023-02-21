using UnityEngine;

namespace Enemies.Effects
{
    public abstract class EnemyEffectObject : ScriptableObject, EnemyEffect
    {
        public abstract void callEffect(EnemyEffectGateway gateway);
    }
}